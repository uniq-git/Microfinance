using System;
using System.Drawing;
using System.Windows.Forms;
using MicrofinanceSystem.My;
using MySql.Data.MySqlClient;

namespace MicrofinanceSystem;

public partial class frmLoans : Form
{
    // TODO: move this to App.config / environment config and use a non-root DB user with a password.
    private const string ConnectionString = "server=localhost;user id=root;password=;database=microfinance_db";

    private const string Peso = "₱";
    private const int MaxActiveLoans = 5;

    // Kept public/static because other forms may read it.
    public static int selectedUserId = -1;

    private int selectedClientId = -1;

    private static readonly Color Navy = Color.FromArgb(31, 58, 95);
    private static readonly Color Muted = Color.FromArgb(71, 85, 105);

    public frmLoans()
    {
        InitializeComponent();
    }

    // =====================================================================
    //  Form events
    // =====================================================================
    private void frmLoans_Load(object sender, EventArgs e)
    {
        ConfigureGrid();
        dtStart.Value = DateTime.Today;
        txtLoggedInUser.Text = "Signed in as " + frmlogin.LoggedInUsername;

        selectedUserId = GetUserIDByUsername(frmlogin.LoggedInUsername);
        if (selectedUserId == -1)
        {
            MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ReturnToDashboard();
            return;
        }

        if (!LoadClientID())
        {
            MessageBox.Show("Please register your personal info in the Clients section before applying for a loan.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            ReturnToDashboard();
            return;
        }

        LoadLoans();
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
        MyProject.Forms.frmDashboard.Show();
        Close();
    }

    private void btnPay_Click(object sender, EventArgs e)
    {
        MyProject.Forms.frmPayments.Show();
        Close();
    }

    private void LoanInput_TextChanged(object sender, EventArgs e)
    {
        CalculateMonthlyPayment();
    }

    private void DecimalInput_KeyPress(object sender, KeyPressEventArgs e)
    {
        // digits, one decimal point, thousands comma and control keys only
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            e.Handled = true;
    }

    private void IntegerInput_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            e.Handled = true;
    }

    // Closing from inside Load can throw, so do it right after Load finishes.
    private void ReturnToDashboard()
    {
        BeginInvoke(new Action(() =>
        {
            MyProject.Forms.frmDashboard.Show();
            Close();
        }));
    }

    // =====================================================================
    //  Grid
    // =====================================================================
    private void ConfigureGrid()
    {
        if (dgvloans.Columns.Count > 0) return;

        dgvloans.Columns.Add("loan_id", "Loan ID");
        dgvloans.Columns.Add("amount", "Amount");
        dgvloans.Columns.Add("interest_rate", "Interest");
        dgvloans.Columns.Add("term_months", "Term (Months)");
        dgvloans.Columns.Add("monthly_payment", "Monthly Payment");
        dgvloans.Columns.Add("balance", "Balance");
        dgvloans.Columns.Add("start_date", "Start Date");
        dgvloans.Columns.Add("status", "Status");

        dgvloans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvloans.Columns["loan_id"].FillWeight = 55;
        dgvloans.ColumnHeadersHeight = 40;
        dgvloans.RowTemplate.Height = 34;

        dgvloans.ColumnHeadersDefaultCellStyle.BackColor = Navy;
        dgvloans.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        dgvloans.ColumnHeadersDefaultCellStyle.SelectionBackColor = Navy;
        dgvloans.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

        dgvloans.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
        dgvloans.DefaultCellStyle.SelectionForeColor = Navy;
        dgvloans.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(247, 249, 252);

        foreach (string name in new[] { "amount", "interest_rate", "term_months", "monthly_payment", "balance" })
        {
            dgvloans.Columns[name].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvloans.Columns[name].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
    }

    private static string Money(object value)
    {
        return value == null || value == DBNull.Value ? "" : Peso + Convert.ToDecimal(value).ToString("N2");
    }

    private static Color StatusColor(string status)
    {
        switch ((status ?? "").ToLowerInvariant())
        {
            case "active": return Color.FromArgb(22, 128, 61);
            case "pending": return Color.FromArgb(180, 83, 9);
            default: return Muted;
        }
    }

    // =====================================================================
    //  Data access
    // =====================================================================
    public static int GetUserIDByUsername(string username)
    {
        try
        {
            using var conn = new MySqlConnection(ConnectionString);
            conn.Open();
            using var cmd = new MySqlCommand("SELECT id FROM users WHERE username = @username LIMIT 1", conn);
            cmd.Parameters.AddWithValue("@username", username);
            object result = cmd.ExecuteScalar();
            return result == null || result == DBNull.Value ? -1 : Convert.ToInt32(result);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error getting user ID: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return -1;
        }
    }

    private bool LoadClientID()
    {
        try
        {
            using var conn = new MySqlConnection(ConnectionString);
            conn.Open();
            using var cmd = new MySqlCommand("SELECT client_id FROM clients WHERE full_name = @name LIMIT 1", conn);
            cmd.Parameters.AddWithValue("@name", frmlogin.LoggedInUsername);
            object result = cmd.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                selectedClientId = Convert.ToInt32(result);
                return true;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error fetching client ID: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return false;
    }

    private void LoadLoans()
    {
        dgvloans.Rows.Clear();
        try
        {
            using var conn = new MySqlConnection(ConnectionString);
            conn.Open();
            const string sql = "SELECT loan_id, amount, interest_rate, term_months, monthly_payment, balance, start_date, status FROM loans WHERE user_id = @uid ORDER BY loan_id DESC";
            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@uid", selectedUserId);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string status = Convert.ToString(reader["status"]);
                string startDate = reader["start_date"] is DateTime dt ? dt.ToString("yyyy-MM-dd") : "";
                string rate = reader["interest_rate"] == DBNull.Value ? "" : Convert.ToDecimal(reader["interest_rate"]).ToString("0.##") + "%";

                int row = dgvloans.Rows.Add(
                    Convert.ToString(reader["loan_id"]),
                    Money(reader["amount"]),
                    rate,
                    Convert.ToString(reader["term_months"]),
                    Money(reader["monthly_payment"]),
                    Money(reader["balance"]),
                    startDate,
                    status);

                dgvloans.Rows[row].Cells["status"].Style.ForeColor = StatusColor(status);
                dgvloans.Rows[row].Cells["status"].Style.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error loading loans: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private int GetActiveLoanCount()
    {
        try
        {
            using var conn = new MySqlConnection(ConnectionString);
            conn.Open();
            using var cmd = new MySqlCommand("SELECT COUNT(*) FROM loans WHERE user_id = @uid AND status = 'active'", conn);
            cmd.Parameters.AddWithValue("@uid", selectedUserId);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error checking active loans: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return -1;
        }
    }

    // =====================================================================
    //  Loan calculation (flat rate: total = amount + amount * rate%)
    // =====================================================================
    private static decimal TotalRepayable(decimal amount, decimal rate)
    {
        return amount + amount * rate / 100m;
    }

    private static decimal MonthlyPayment(decimal total, int months)
    {
        return Math.Round(total / months, 2, MidpointRounding.AwayFromZero);
    }

    private void CalculateMonthlyPayment()
    {
        // Live preview. Never divide by a zero term.
        if (decimal.TryParse(txtamount.Text, out decimal amount) && amount > 0
            && decimal.TryParse(txtinterest.Text, out decimal rate) && rate >= 0
            && int.TryParse(txtterm.Text, out int months) && months > 0)
        {
            decimal total = TotalRepayable(amount, rate);
            txtmonthly.Text = MonthlyPayment(total, months).ToString("F2");
            lblSummary.Text = "Total repayable: " + Peso + total.ToString("N2") + " over " + months + " month(s).";
        }
        else
        {
            txtmonthly.Text = "";
            lblSummary.Text = "Enter the loan details to see the total repayable amount.";
        }
    }

    // =====================================================================
    //  Save
    // =====================================================================
    private void btnSave_Click(object sender, EventArgs e)
    {
        if (selectedUserId < 0 || selectedClientId < 0)
        {
            MessageBox.Show("User ID or Client ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (!TryReadInputs(out decimal amount, out decimal rate, out int term))
            return;

        int activeLoans = GetActiveLoanCount();
        if (activeLoans < 0) return;
        if (activeLoans >= MaxActiveLoans)
        {
            MessageBox.Show("You already have " + MaxActiveLoans + " active loans. You can't apply for another until at least one is completed.", "Loan Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }

        decimal balance = TotalRepayable(amount, rate);
        decimal monthly = MonthlyPayment(balance, term);
        DateTime startDate = dtStart.Value.Date;
        string status = startDate <= DateTime.Today ? "active" : "pending";

        string summary = "Save this loan?\r\n\r\n"
            + "Amount: " + Peso + amount.ToString("N2") + "\r\n"
            + "Interest: " + rate.ToString("0.##") + "%\r\n"
            + "Total repayable: " + Peso + balance.ToString("N2") + "\r\n"
            + "Term: " + term + " month(s)\r\n"
            + "Monthly payment: " + Peso + monthly.ToString("N2") + "\r\n"
            + "Start date: " + startDate.ToString("yyyy-MM-dd") + " (" + status + ")";

        if (MessageBox.Show(summary, "Confirm Loan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            return;

        try
        {
            using var conn = new MySqlConnection(ConnectionString);
            conn.Open();
            const string sql = "INSERT INTO loans (client_id, user_id, amount, interest_rate, term_months, monthly_payment, start_date, status, balance) VALUES (@clientid, @uid, @amt, @rate, @term, @mpay, @date, @status, @balance)";
            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@clientid", selectedClientId);
            cmd.Parameters.AddWithValue("@uid", selectedUserId);
            cmd.Parameters.AddWithValue("@amt", amount);
            cmd.Parameters.AddWithValue("@rate", rate);
            cmd.Parameters.AddWithValue("@term", term);
            cmd.Parameters.AddWithValue("@mpay", monthly);
            cmd.Parameters.AddWithValue("@date", startDate);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@balance", balance);
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error saving loan: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        MessageBox.Show("Loan saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        LoadLoans();
        ClearInputs();
    }

    private bool TryReadInputs(out decimal amount, out decimal rate, out int term)
    {
        rate = 0m;
        term = 0;

        if (!decimal.TryParse(txtamount.Text, out amount) || amount <= 0)
            return Fail("Please enter a loan amount greater than zero.", txtamount);
        if (!decimal.TryParse(txtinterest.Text, out rate) || rate < 0 || rate > 100)
            return Fail("Please enter an interest rate between 0 and 100.", txtinterest);
        if (!int.TryParse(txtterm.Text, out term) || term < 1 || term > 120)
            return Fail("Please enter a term between 1 and 120 months.", txtterm);

        return true;
    }

    private static bool Fail(string message, Control focus)
    {
        MessageBox.Show(message, "Missing or Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        focus.Focus();
        return false;
    }

    private void ClearInputs()
    {
        txtamount.Clear();
        txtinterest.Clear();
        txtterm.Clear();
        txtmonthly.Clear();
        dtStart.Value = DateTime.Today;
    }
}