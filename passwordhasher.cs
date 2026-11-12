using System;
using System.Security.Cryptography;
using System.Text;

namespace MicrofinanceSystem;

/// <summary>
/// Hashes and verifies passwords (PBKDF2-SHA256 with a random salt per password).
/// Stored format:  PBKDF2$iterations$salt(base64)$hash(base64)
/// Old accounts that still have a plain-text password are recognised by the missing
/// "PBKDF2$" prefix, so they can still log in once and then be upgraded.
/// </summary>
public static class PasswordHasher
{
    private const string Prefix = "PBKDF2$";
    private const int SaltSize = 16;
    private const int KeySize = 32;
    private const int Iterations = 210000;

    // Returns a string safe to store in users.password (about 85 characters).
    public static string Hash(string password)
    {
        byte[] salt = RandomNumberGenerator.GetBytes(SaltSize);
        byte[] key = Rfc2898DeriveBytes.Pbkdf2(password, salt, Iterations, HashAlgorithmName.SHA256, KeySize);
        return Prefix + Iterations + "$" + Convert.ToBase64String(salt) + "$" + Convert.ToBase64String(key);
    }

    // True if the stored value is already a hash (false = old plain-text password).
    public static bool IsHashed(string stored)
    {
        return stored != null && stored.StartsWith(Prefix, StringComparison.Ordinal);
    }

    // Checks a typed password against what is stored. Works for both new hashed
    // passwords and old plain-text ones.
    public static bool Verify(string password, string stored)
    {
        if (string.IsNullOrEmpty(stored) || password == null)
        {
            return false;
        }

        if (!IsHashed(stored))
        {
            // Legacy plain-text account.
            return CryptographicOperations.FixedTimeEquals(
                Encoding.UTF8.GetBytes(password),
                Encoding.UTF8.GetBytes(stored));
        }

        string[] parts = stored.Split('$');
        if (parts.Length != 4 || !int.TryParse(parts[1], out int iterations))
        {
            return false;
        }

        try
        {
            byte[] salt = Convert.FromBase64String(parts[2]);
            byte[] expected = Convert.FromBase64String(parts[3]);
            byte[] actual = Rfc2898DeriveBytes.Pbkdf2(password, salt, iterations, HashAlgorithmName.SHA256, expected.Length);
            return CryptographicOperations.FixedTimeEquals(actual, expected);
        }
        catch (FormatException)
        {
            return false;
        }
    }

    // True if this stored password should be re-saved as a fresh hash after a
    // successful login (old plain text, or a hash made with weaker settings).
    public static bool NeedsRehash(string stored)
    {
        if (!IsHashed(stored))
        {
            return true;
        }

        string[] parts = stored.Split('$');
        return parts.Length != 4 || !int.TryParse(parts[1], out int iterations) || iterations < Iterations;
    }
}