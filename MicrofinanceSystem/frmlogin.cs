using System;
using System.Drawing;
using System.Windows.Forms;
using MicrofinanceSystem.My;
using MySql.Data.MySqlClient;

namespace MicrofinanceSystem;

public partial class frmlogin: Form
{
    // TODO: move this to App.config / environment config and use a non-root DB user with a password.
    private const string ConnectionString = "server=localhost;user id=root;password=;database=microfinance_db";

    private const int MaxFailedAttempts = 5;
    private const int LockSeconds = 30;

    // Kept public/static because other forms read them.
    public static string LoggedInUsername = "";
    public static int LoggedInUserID = -1;

    private static readonly Color ErrorColor = Color.FromArgb(220, 38, 38);
    private static readonly Color SuccessColor = Color.FromArgb(22, 128, 61);

    private int failedAttempts;
    private DateTime lockedUntil = DateTime.MinValue;

    public frmlogin()
    {
        InitializeComponent();
    }

    // =====================================================================
    //  Form events
    // =====================================================================
    private void frmlogin_VisibleChanged(object sender, EventArgs e)
    {
        // Runs on first show and every time we come back here (e.g. after logout).
        if (!Visible) return;
        lblError.Visible = false;
        ActiveControl = txtUsername.TextLength > 0 ? txtPassword : txtUsername;
    }

    private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
    {
        txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
    }

    private void errorTimer_Tick(object sender, EventArgs e)
    {
        errorTimer.Stop();
        lblError.Visible = false;
    }

    private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        MyProject.Forms.frmRegistration.Show();
        Hide();
    }

    private void lnkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        using var dialog = new frmForgotPassword { PrefillUsername = txtUsername.Text.Trim() };
        if (dialog.ShowDialog(this) == DialogResult.OK)
        {
            txtUsername.Text = dialog.ResetUsername;
            txtPassword.Clear();
            ShowMessage("Password updated. You can sign in now.", SuccessColor);
            txtPassword.Focus();
        }
    }

    // =====================================================================
    //  Login
    // =====================================================================
    private void btnLogin_Click(object sender, EventArgs e)
    {
        if (DateTime.Now < lockedUntil)
        {
            int seconds = (int)Math.Ceiling((lockedUntil - DateTime.Now).TotalSeconds);
            ShowMessage("Too many attempts. Try again in " + seconds + " second(s).", ErrorColor);
            return;
        }

        string username = txtUsername.Text.Trim();
        string password = txtPassword.Text.Trim();

        if (username.Length == 0)
        {
            ShowMessage("Please enter your username.", ErrorColor);
            txtUsername.Focus();
            return;
        }
        if (password.Length == 0)
        {
            ShowMessage("Please enter your password.", ErrorColor);
            txtPassword.Focus();
            return;
        }

        btnLogin.Enabled = false;
        try
        {
            int userId = -1;
            string storedUsername = null;
            string storedPassword = null;

            using (var conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                using var cmd = new MySqlCommand("SELECT id, username, password FROM users WHERE username = @u LIMIT 1", conn);
                cmd.Parameters.AddWithValue("@u", username);
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    userId = Convert.ToInt32(reader["id"]);
                    storedUsername = Convert.ToString(reader["username"]);
                    storedPassword = Convert.ToString(reader["password"]);
                }
            }

            // Compared here with an ordinal check. MySQL's default collation is case-insensitive,
            // so "password = @p" in SQL would accept "PASSWORD" for "password".
            bool ok = userId >= 0
                && storedPassword != null
                && string.Equals(storedPassword.Trim(), password, StringComparison.Ordinal);

            if (ok)
            {
                LoggedInUsername = storedUsername;
                LoggedInUserID = userId;
                failedAttempts = 0;
                errorTimer.Stop();
                lblError.Visible = false;
                txtPassword.Clear();

                MyProject.Forms.frmDashboard.Show();
                Hide();
            }
            else
            {
                failedAttempts++;
                if (failedAttempts >= MaxFailedAttempts)
                {
                    failedAttempts = 0;
                    lockedUntil = DateTime.Now.AddSeconds(LockSeconds);
                    ShowMessage("Too many failed attempts. Please wait " + LockSeconds + " seconds.", ErrorColor);
                }
                else
                {
                    ShowMessage("Incorrect username or password.", ErrorColor);
                }
                txtPassword.SelectAll();
                txtPassword.Focus();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Could not sign in. Is MySQL running?\r\n\r\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            btnLogin.Enabled = true;
        }
    }

    private void ShowMessage(string text, Color color)
    {
        lblError.ForeColor = color;
        lblError.Text = text;
        lblError.Visible = true;
        errorTimer.Stop();
        errorTimer.Start();
    }
}