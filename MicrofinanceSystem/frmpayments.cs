using MicrofinanceSystem.My;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace MicrofinanceSystem;

public partial class frmPayments : Form
{
    private int selectedUserId = -1;

    public frmPayments()
    {
        InitializeComponent();
        cmbPaymentMethod.SelectedIndex = 0;
    }

    // The form is hidden (not closed) when you go back to the dashboard, so Load only
    // runs once. Refresh every time it becomes visible, otherwise it keeps showing the
    // previous user's loans after a logout/login or after new loans are added.
    protected override void OnVisibleChanged(EventArgs e)
    {
        base.OnVisibleChanged(e);

        // Never touch the database while the form is open in the Visual Studio designer.
        if (DesignMode || !Visible)
        {
            return;
        }

        selectedUserId = frmLoans.GetUserIDByUsername(frmlogin.LoggedInUsername);
        if (selectedUserId == -1)
        {
            MessageBox.Show("❌ User not found.");
            BeginInvoke(new MethodInvoker(Close));
            return;
        }

        // Payment date: today by default, and no future dates.
        DateTimePicker1.MaxDate = DateTime.Today;
        DateTimePicker1.Value = DateTime.Today;

        txtAmount.Clear();
        LoadLoanIDs();
    }

    private void LoadLoanIDs()
    {
        List<string> ids = new List<string>();

        try
        {
            MySQLConnect.OpenConnection();
            using (MySqlCommand cmd = new MySqlCommand(
                "SELECT loan_id FROM loans WHERE status = 'active' AND user_id = @uid",
                MySQLConnect.conn))
            {
                cmd.Parameters.AddWithValue("@uid", selectedUserId);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ids.Add(reader["loan_id"].ToString());
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("❌ Error loading loan IDs: " + ex.Message);
        }
        finally
        {
            MySQLConnect.CloseConnection();
        }

        // Fill the list only after the connection is closed: selecting an item
        // triggers a balance query that needs the connection itself.
        cmbLoanIDs.Items.Clear();
        foreach (string id in ids)
        {
            cmbLoanIDs.Items.Add(id);
        }

        if (cmbLoanIDs.Items.Count > 0)
        {
            btnPay.Enabled = true;
            cmbLoanIDs.SelectedIndex = 0;
        }
        else
        {
            btnPay.Enabled = false;
            lblStatus.Text = "No active loans found.";
        }
    }

    private void cmbLoanIDs_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cmbLoanIDs.SelectedItem != null && int.TryParse(cmbLoanIDs.SelectedItem.ToString(), out int loanId))
        {
            ShowRemainingBalance(loanId);
        }
    }

    private void ShowRemainingBalance(int loanId)
    {
        try
        {
            MySQLConnect.OpenConnection();
            using (MySqlCommand cmd = new MySqlCommand(
                "SELECT balance FROM loans WHERE loan_id = @lid AND user_id = @uid",
                MySQLConnect.conn))
            {
                cmd.Parameters.AddWithValue("@lid", loanId);
                cmd.Parameters.AddWithValue("@uid", selectedUserId);
                object result = cmd.ExecuteScalar();
                decimal balance = (result == null || result is DBNull) ? 0m : Convert.ToDecimal(result);
                lblStatus.Text = "Remaining Balance: ₱" + balance.ToString("N2");
            }
        }
        catch (Exception ex)
        {
            lblStatus.Text = "Remaining Balance: ₱0.00";
            MessageBox.Show("❌ Error retrieving balance: " + ex.Message);
        }
        finally
        {
            MySQLConnect.CloseConnection();
        }
    }

    private void btnPay_Click(object sender, EventArgs e)
    {
        if (cmbLoanIDs.SelectedItem == null || !int.TryParse(cmbLoanIDs.SelectedItem.ToString(), out int loanId))
        {
            MessageBox.Show("⚠ Please select a loan to pay.");
            return;
        }

        if (!decimal.TryParse(txtAmount.Text.Trim(), NumberStyles.Number, CultureInfo.CurrentCulture, out decimal amount) || amount <= 0m)
        {
            MessageBox.Show("⚠ Please enter a valid payment amount.");
            return;
        }
        amount = Math.Round(amount, 2);

        bool paid = false;
        MySqlTransaction tx = null;

        try
        {
            MySQLConnect.OpenConnection();
            tx = MySQLConnect.conn.BeginTransaction();

            // Lock the loan row and confirm it belongs to this user and is still active.
            decimal currentBalance;
            using (MySqlCommand balanceCmd = new MySqlCommand(
                "SELECT balance FROM loans WHERE loan_id = @lid AND user_id = @uid AND status = 'active' FOR UPDATE",
                MySQLConnect.conn, tx))
            {
                balanceCmd.Parameters.AddWithValue("@lid", loanId);
                balanceCmd.Parameters.AddWithValue("@uid", selectedUserId);
                object result = balanceCmd.ExecuteScalar();
                if (result == null || result is DBNull)
                {
                    tx.Rollback();
                    MessageBox.Show("⚠ This loan was not found or is no longer active.");
                    return;
                }
                currentBalance = Convert.ToDecimal(result);
            }

            if (amount > currentBalance)
            {
                tx.Rollback();
                MessageBox.Show("⚠ Payment exceeds remaining balance of ₱" + currentBalance.ToString("N2"));
                return;
            }

            using (MySqlCommand insertCmd = new MySqlCommand(
                "INSERT INTO payments (loan_id, amount_paid, payment_date, payment_method) VALUES (@lid, @amt, @pdate, @method)",
                MySQLConnect.conn, tx))
            {
                insertCmd.Parameters.AddWithValue("@lid", loanId);
                insertCmd.Parameters.AddWithValue("@amt", amount);
                insertCmd.Parameters.AddWithValue("@pdate", DateTimePicker1.Value.Date);
                insertCmd.Parameters.AddWithValue("@method", cmbPaymentMethod.SelectedItem.ToString());
                insertCmd.ExecuteNonQuery();
            }

            using (MySqlCommand updateCmd = new MySqlCommand(
                "UPDATE loans SET balance = balance - @amt WHERE loan_id = @lid",
                MySQLConnect.conn, tx))
            {
                updateCmd.Parameters.AddWithValue("@amt", amount);
                updateCmd.Parameters.AddWithValue("@lid", loanId);
                updateCmd.ExecuteNonQuery();
            }

            if (currentBalance - amount <= 0m)
            {
                using (MySqlCommand completeCmd = new MySqlCommand(
                    "UPDATE loans SET status = 'completed' WHERE loan_id = @lid",
                    MySQLConnect.conn, tx))
                {
                    completeCmd.Parameters.AddWithValue("@lid", loanId);
                    completeCmd.ExecuteNonQuery();
                }
            }

            // Payment, balance and status all succeed together or not at all.
            tx.Commit();
            paid = true;
        }
        catch (Exception ex)
        {
            try
            {
                if (tx != null)
                {
                    tx.Rollback();
                }
            }
            catch (Exception)
            {
                // Rollback can fail if the connection is already gone; nothing more to do.
            }
            MessageBox.Show("❌ Error: " + ex.Message);
        }
        finally
        {
            MySQLConnect.CloseConnection();
        }

        if (paid)
        {
            MessageBox.Show("✅ Payment successful.");
            txtAmount.Clear();
            LoadLoanIDs();

            frmTransactionHistory history = Application.OpenForms.OfType<frmTransactionHistory>().FirstOrDefault();
            if (history != null)
            {
                history.LoadAllTransactions();
            }
        }
    }

    private void picBack_Click(object sender, EventArgs e)
    {
        MyProject.Forms.frmDashboard.Show();
        Hide();
    }
}