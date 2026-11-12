using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MicrofinanceSystem;

/// <summary>
/// Two-step password reset. There is no email/SMS in this app, so identity is verified against
/// the details already saved in the user's Clients profile (contact number + birthdate).
/// </summary>
public partial class frmForgotPassword : Form
{
    // TODO: move this to App.config / environment config and use a non-root DB user with a password.
    private const string ConnectionString = "server=localhost;user id=root;password=;database=microfinance_db";

    private const int MaxFailedAttempts = 5;
    private const int LockMinutes = 5;
    private const int MinPasswordLength = 6;

    // Static so closing and reopening the dialog doesn't reset the attempt counter.
    private static int failedAttempts;
    private static DateTime lockedUntil = DateTime.MinValue;

    private static readonly Color ErrorColor = Color.FromArgb(220, 38, 38);
    private static readonly Color SuccessColor = Color.FromArgb(22, 128, 61);
    private static readonly Color MutedColor = Color.FromArgb(71, 85, 105);

    private int verifiedUserId = -1;

    /// <summary>Set before ShowDialog to pre-fill the username box.</summary>
    public string PrefillUsername { get; set; } = "";

    /// <summary>The username whose password was reset (valid when the dialog returns OK).</summary>
    public string ResetUsername { get; private set; } = "";

    public frmForgotPassword()
    {
        InitializeComponent();
    }

    // =====================================================================
    //  Form events
    // =====================================================================
    private void frmForgotPassword_Load(object sender, EventArgs e)
    {
        dtpBirthdate.MaxDate = DateTime.Today;
        dtpBirthdate.Value = DateTime.Today.AddYears(-18);
        txtUsername.Text = PrefillUsername;
        SetStep2Enabled(false);
        ActiveControl = txtUsername.TextLength > 0 ? txtContact : txtUsername;
    }

    private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
    {
        // allow digits, +, -, space and control keys (backspace etc.)
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '+' && e.KeyChar != '-' && e.KeyChar != ' ')
            e.Handled = true;
    }

    private void chkShow_CheckedChanged(object sender, EventArgs e)
    {
        txtNewPassword.UseSystemPasswordChar = !chkShow.Checked;
        txtConfirm.UseSystemPasswordChar = !chkShow.Checked;
    }

    // =====================================================================
    //  Step 1: verify identity
    // =====================================================================
    private void btnVerify_Click(object sender, EventArgs e)
    {
        if (DateTime.Now < lockedUntil)
        {
            int minutes = (int)Math.Ceiling((lockedUntil - DateTime.Now).TotalMinutes);
            SetStatus("Too many failed attempts. Try again in about " + minutes + " minute(s).", ErrorColor);
            return;
        }

        string username = txtUsername.Text.Trim();
        string contact = CanonicalPhone(txtContact.Text);

        if (username.Length == 0)
        {
            SetStatus("Please enter your username.", ErrorColor);
            txtUsername.Focus();
            return;
        }
        if (contact.Length == 0)
        {
            SetStatus("Please enter the contact number from your Clients profile.", ErrorColor);
            txtContact.Focus();
            return;
        }

        try
        {
            int userId = -1;
            string actualUsername = null;

            using var conn = new MySqlConnection(ConnectionString);
            conn.Open();

            using (var cmd = new MySqlCommand("SELECT id, username FROM users WHERE username = @u LIMIT 1", conn))
            {
                cmd.Parameters.AddWithValue("@u", username);
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    userId = Convert.ToInt32(reader["id"]);
                    actualUsername = Convert.ToString(reader["username"]);
                }
            }

            bool verified = false;
            if (userId >= 0)
            {
                using var cmd = new MySqlCommand("SELECT contact_no, birthdate FROM clients WHERE full_name = @name LIMIT 1", conn);
                cmd.Parameters.AddWithValue("@name", actualUsername);
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string storedContact = CanonicalPhone(Convert.ToString(reader["contact_no"]));
                    bool contactMatches = storedContact.Length > 0 && string.Equals(storedContact, contact, StringComparison.Ordinal);

                    bool birthMatches = reader["birthdate"] != DBNull.Value
                        && Convert.ToDateTime(reader["birthdate"]).Date == dtpBirthdate.Value.Date;

                    verified = contactMatches && birthMatches;
                }
            }

            if (verified)
            {
                failedAttempts = 0;
                verifiedUserId = userId;
                ResetUsername = actualUsername;

                txtUsername.ReadOnly = true;
                txtContact.ReadOnly = true;
                dtpBirthdate.Enabled = false;
                btnVerify.Enabled = false;

                SetStatus("Identity verified. Choose a new password below.", SuccessColor);
                SetStep2Enabled(true);
                txtNewPassword.Focus();
            }
            else
            {
                failedAttempts++;
                if (failedAttempts >= MaxFailedAttempts)
                {
                    failedAttempts = 0;
                    lockedUntil = DateTime.Now.AddMinutes(LockMinutes);
                    SetStatus("Too many failed attempts. Please wait " + LockMinutes + " minutes and try again.", ErrorColor);
                }
                else
                {
                    // Same message for every failure so this can't be used to find which usernames exist.
                    SetStatus("We couldn't verify those details. If you haven't completed your Clients profile, please contact the administrator.", ErrorColor);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Could not verify your details. Is MySQL running?\r\n\r\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // =====================================================================
    //  Step 2: set the new password
    // =====================================================================
    private void btnReset_Click(object sender, EventArgs e)
    {
        if (verifiedUserId < 0)
        {
            SetStatus("Please verify your identity first.", ErrorColor);
            return;
        }

        string newPassword = txtNewPassword.Text.Trim();
        string confirm = txtConfirm.Text.Trim();

        if (newPassword.Length < MinPasswordLength)
        {
            SetStatus("Your new password must be at least " + MinPasswordLength + " characters.", ErrorColor);
            txtNewPassword.Focus();
            return;
        }
        if (!string.Equals(newPassword, confirm, StringComparison.Ordinal))
        {
            SetStatus("The two passwords don't match.", ErrorColor);
            txtConfirm.Focus();
            return;
        }

        try
        {
            using var conn = new MySqlConnection(ConnectionString);
            conn.Open();

            // TODO: passwords are stored as plain text everywhere in this app (login/registration use the same scheme).
            // Switch all three to a salted hash together; changing only this form would lock users out.
            using var cmd = new MySqlCommand("UPDATE users SET password = @p WHERE id = @id AND username = @u", conn);
            cmd.Parameters.AddWithValue("@p", newPassword);
            cmd.Parameters.AddWithValue("@id", verifiedUserId);
            cmd.Parameters.AddWithValue("@u", ResetUsername);
            int rows = cmd.ExecuteNonQuery();

            if (rows < 1)
            {
                SetStatus("Could not update the password. Please try again.", ErrorColor);
                return;
            }

            MessageBox.Show("Your password has been updated. You can now sign in.", "Password Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Could not reset the password: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // =====================================================================
    //  Helpers
    // =====================================================================
    private void SetStep2Enabled(bool enabled)
    {
        lblStep2.Enabled = enabled;
        lblNewPassword.Enabled = enabled;
        txtNewPassword.Enabled = enabled;
        lblConfirm.Enabled = enabled;
        txtConfirm.Enabled = enabled;
        chkShow.Enabled = enabled;
        btnReset.Enabled = enabled;
        btnReset.BackColor = enabled ? Color.FromArgb(37, 99, 235) : Color.FromArgb(147, 176, 240);
    }

    private void SetStatus(string text, Color color)
    {
        lblStatus.Text = text;
        lblStatus.ForeColor = color;
    }

    // Makes "+63 917-123-4567", "63917...", and "0917..." all compare equal.
    private static string CanonicalPhone(string raw)
    {
        string s = Regex.Replace(raw ?? string.Empty, @"[\s\-]", "");
        if (s.StartsWith("+63")) s = "0" + s.Substring(3);
        else if (s.StartsWith("63") && s.Length == 12) s = "0" + s.Substring(2);
        return s;
    }
}