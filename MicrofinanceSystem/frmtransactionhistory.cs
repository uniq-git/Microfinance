using System;
using System.Windows.Forms;
using MicrofinanceSystem.My;
using MySql.Data.MySqlClient;

namespace MicrofinanceSystem;

public partial class frmTransactionHistory : Form
{
    public frmTransactionHistory()
    {
        InitializeComponent();
    }

    // The form is hidden (not closed) when you go back to the dashboard, so Load only
    // runs once. Reload every time it becomes visible so the list is never stale and
    // always belongs to whoever is logged in now.
    protected override void OnVisibleChanged(EventArgs e)
    {
        base.OnVisibleChanged(e);

        // Never touch the database while the form is open in the Visual Studio designer.
        if (!DesignMode && Visible)
        {
            LoadAllTransactions();
        }
    }

    // Public because frmPayments calls it after a payment to refresh this list.
    // Shows only the payments made on the logged-in user's own loans.
    // (To show every user's payments again, remove the JOIN and WHERE lines.)
    public void LoadAllTransactions()
    {
        dgvHistory.Rows.Clear();
        decimal total = 0m;
        int count = 0;

        try
        {
            MySQLConnect.OpenConnection();
            using (MySqlCommand cmd = new MySqlCommand(
                "SELECT p.payment_id, p.loan_id, p.amount_paid, p.payment_method, p.payment_date " +
                "FROM payments p " +
                "INNER JOIN loans l ON l.loan_id = p.loan_id " +
                "WHERE l.user_id = @uid " +
                "ORDER BY p.payment_date DESC, p.payment_id DESC",
                MySQLConnect.conn))
            {
                cmd.Parameters.AddWithValue("@uid", frmlogin.LoggedInUserID);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        decimal amount = reader["amount_paid"] is DBNull ? 0m : Convert.ToDecimal(reader["amount_paid"]);
                        string date = reader["payment_date"] is DBNull ? "" : Convert.ToDateTime(reader["payment_date"]).ToString("yyyy-MM-dd");

                        dgvHistory.Rows.Add(reader["payment_id"], reader["loan_id"], amount, reader["payment_method"], date);
                        total += amount;
                        count++;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("❌ Error loading transaction history: " + ex.Message);
        }
        finally
        {
            MySQLConnect.CloseConnection();
        }

        lblSummary.Text = count == 0
            ? "No transactions yet."
            : count + (count == 1 ? " transaction" : " transactions") + "   |   Total paid: ₱" + total.ToString("N2");
    }

    private void picBack_Click(object sender, EventArgs e)
    {
        MyProject.Forms.frmDashboard.Show();
        Hide();
    }
}