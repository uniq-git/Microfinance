using System;
using System.Windows.Forms;
using MicrofinanceSystem.My;
using MySql.Data.MySqlClient;

namespace MicrofinanceSystem;

public partial class frmDashboard : Form
{
    // TODO: move this to App.config / environment config and use a non-root DB user with a password.
    private const string ConnectionString = "server=localhost;user id=root;password=;database=microfinance_db";

    private frmClients clientsForm;
    private bool isRefreshing;
    private bool errorShown;

    public frmDashboard()
    {
        InitializeComponent();
    }

    // =====================================================================
    //  Data
    // =====================================================================
    public void RefreshDashboard()
    {
        // Guard: showing a MessageBox re-activates this form, which would call us again forever.
        if (isRefreshing) return;
        isRefreshing = true;

        try
        {
            txtLoggedInUser.Text = "Hi, " + frmlogin.LoggedInUsername + "!";

            using var conn = new MySqlConnection(ConnectionString);
            conn.Open();

            decimal balance = 0m;
            using (var cmd = new MySqlCommand("SELECT SUM(balance) FROM loans WHERE user_id = @uid AND status = 'active'", conn))
            {
                cmd.Parameters.AddWithValue("@uid", frmlogin.LoggedInUserID);
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                    balance = Convert.ToDecimal(result);
            }
            lblTotalBalance.Text = "₱" + balance.ToString("N2");

            using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM clients", conn))
            {
                lblTotalClients.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString("N0");
            }

            using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM loans WHERE user_id = @uid AND status = 'active'", conn))
            {
                cmd.Parameters.AddWithValue("@uid", frmlogin.LoggedInUserID);
                lblActiveLoans.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString("N0");
            }

            errorShown = false;
        }
        catch (Exception ex)
        {
            lblTotalBalance.Text = "N/A";
            lblTotalClients.Text = "N/A";
            lblActiveLoans.Text = "N/A";

            if (!errorShown)
            {
                errorShown = true;
                MessageBox.Show("Could not load dashboard data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        finally
        {
            isRefreshing = false;
        }
    }

    private bool IsUserRegistered(string username)
    {
        try
        {
            using var conn = new MySqlConnection(ConnectionString);
            conn.Open();
            using var cmd = new MySqlCommand("SELECT COUNT(*) FROM clients WHERE full_name = @name", conn);
            cmd.Parameters.AddWithValue("@name", username);
            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error checking registration: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }

    // =====================================================================
    //  Events
    // =====================================================================
    private void frmDashboard_Activated(object sender, EventArgs e)
    {
        RefreshDashboard();
    }

    private void btnClients_Click(object sender, EventArgs e)
    {
        // Reuse one Clients form instead of creating a new hidden copy every click.
        if (clientsForm == null || clientsForm.IsDisposed)
            clientsForm = new frmClients();

        clientsForm.Show();
        Hide();
    }

    private void btnLoans_Click(object sender, EventArgs e)
    {
        if (!IsUserRegistered(frmlogin.LoggedInUsername))
        {
            MessageBox.Show("You are not registered in the Clients form. Please register first.", "Not Registered", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }
        MyProject.Forms.frmLoans.Show();
        Hide();
    }

    private void btnPayments_Click(object sender, EventArgs e)
    {
        MyProject.Forms.frmPayments.Show();
        Hide();
    }

    private void btnHistory_Click(object sender, EventArgs e)
    {
        MyProject.Forms.frmTransactionHistory.Show();
        Hide();
    }

    private void btnFeedback_Click(object sender, EventArgs e)
    {
        MyProject.Forms.frmFeedBack.Show();
        Hide();
    }

    private void btnCredits_Click(object sender, EventArgs e)
    {
        MyProject.Forms.frmCredits.Show();
        Hide();
    }

    private void btnLogout_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            return;

        frmlogin.LoggedInUsername = "";
        frmlogin.LoggedInUserID = -1;
        MyProject.Forms.frmlogin.txtUsername.Clear();
        MyProject.Forms.frmlogin.txtPassword.Clear();
        MyProject.Forms.frmlogin.Show();
        Hide();
    }
}