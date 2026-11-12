using System;
using System.Windows.Forms;
using MicrofinanceSystem.My;
using MySql.Data.MySqlClient;

namespace MicrofinanceSystem;

public partial class frmRegistration : Form
{
    private const int MinPasswordLength = 6;

    public frmRegistration()
    {
        InitializeComponent();
    }

    // The form is hidden (not closed) after use, so start with empty fields every time
    // it is shown instead of keeping a half-filled form (and typed passwords) around.
    protected override void OnVisibleChanged(EventArgs e)
    {
        base.OnVisibleChanged(e);

        if (!DesignMode && Visible)
        {
            ClearFields();
            txtRusername.Focus();
        }
    }

    private void ClearFields()
    {
        txtRusername.Clear();
        txtEmail.Clear();
        txtRpassword.Clear();
        txtConfirmPass.Clear();
    }

    private static bool IsValidEmail(string email)
    {
        try
        {
            System.Net.Mail.MailAddress addr = new System.Net.Mail.MailAddress(email);
            return addr.Address == email && addr.Host.Contains(".");
        }
        catch (FormatException)
        {
            return false;
        }
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
        string username = txtRusername.Text.Trim();
        string password = txtRpassword.Text.Trim();
        string confirm = txtConfirmPass.Text.Trim();
        string email = txtEmail.Text.Trim();

        if (username == "" || password == "" || confirm == "" || email == "")
        {
            MessageBox.Show("Please fill in all fields.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }

        if (!IsValidEmail(email))
        {
            MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }

        if (password != confirm)
        {
            MessageBox.Show("Passwords do not match.", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (password.Length < MinPasswordLength)
        {
            MessageBox.Show("Password must be at least " + MinPasswordLength + " characters long.", "Password Too Short", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }

        bool registered = false;

        try
        {
            MySQLConnect.OpenConnection();

            using (MySqlCommand checkCmd = new MySqlCommand(
                "SELECT COUNT(*) FROM users WHERE username = @u",
                MySQLConnect.conn))
            {
                checkCmd.Parameters.AddWithValue("@u", username);
                if (Convert.ToInt32(checkCmd.ExecuteScalar()) > 0)
                {
                    MessageBox.Show("Username already taken.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            // SECURITY NOTE: the password is still saved as plain text, because the login
            // form compares plain text. Hashing has to be changed here AND in frmlogin together.
            using (MySqlCommand insertCmd = new MySqlCommand(
                "INSERT INTO users (username, password, email) VALUES (@u, @p, @e)",
                MySQLConnect.conn))
            {
                insertCmd.Parameters.AddWithValue("@u", username);
                insertCmd.Parameters.AddWithValue("@p", password);
                insertCmd.Parameters.AddWithValue("@e", email);
                insertCmd.ExecuteNonQuery();
            }

            registered = true;
        }
        catch (MySqlException ex) when (ex.Number == 1062)
        {
            // Duplicate key: someone registered the same username a moment ago.
            MessageBox.Show("Username already taken.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            MySQLConnect.CloseConnection();
        }

        if (registered)
        {
            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
            Hide();
            MyProject.Forms.frmlogin.Show();
        }
    }

    private void picBack_Click(object sender, EventArgs e)
    {
        MyProject.Forms.frmlogin.Show();
        Hide();
    }
}