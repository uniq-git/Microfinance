using System;
using System.Diagnostics;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MicrofinanceSystem.My;
using MySql.Data.MySqlClient;

namespace MicrofinanceSystem;

public partial class frmClients : Form
{
    // TODO: move this to App.config / environment config and use a non-root DB user with a password.
    private const string ConnectionString = "server=localhost;user id=root;password=;database=microfinance_db";

    private static readonly Color MutedColor = Color.FromArgb(71, 85, 105);
    private static readonly Color SuccessColor = Color.FromArgb(22, 128, 61);

    private int selectedClientId = -1;

    public frmClients()
    {
        InitializeComponent();
    }

    // =====================================================================
    //  Form events
    // =====================================================================
    private void frmClients_Load(object sender, EventArgs e)
    {
        cmbStatus.Items.AddRange(new object[] { "Active", "Inactive" });
        cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
        cmbCivilStatus.Items.AddRange(new object[] { "Single", "Married", "Widowed", "Separated" });
        cmbIncome.Items.AddRange(new object[] { "Below ₱5000", "₱5000 - ₱10000", "₱10001 - ₱15000", "₱15001 - ₱20000", "₱20001 - ₱30000", "Above ₱30000" });

        dtpBirthdate.MaxDate = DateTime.Today;
        dtpBirthdate.Value = DateTime.Today.AddYears(-18);
        dtpRegistered.Value = DateTime.Now;
        cmbStatus.SelectedIndex = 0;

        txtFullName.Text = frmlogin.LoggedInUsername;

        ApplyRegisteredState(false);
        LoadCurrentUserRecord();
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
        MyProject.Forms.frmDashboard.Show();
        Hide();
    }

    private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
    {
        // allow digits, +, -, space and control keys (backspace etc.)
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '+' && e.KeyChar != '-' && e.KeyChar != ' ')
        {
            e.Handled = true;
        }
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        ClearFields();
    }

    // =====================================================================
    //  Data access
    // =====================================================================
    private void LoadCurrentUserRecord()
    {
        try
        {
            using var conn = new MySqlConnection(ConnectionString);
            conn.Open();
            const string sql = "SELECT client_id, address, contact_no, valid_id, account_status, gender, birthdate, civil_status, occupation, income, notes, created_at FROM clients WHERE full_name = @name LIMIT 1";
            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", frmlogin.LoggedInUsername);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                selectedClientId = Convert.ToInt32(reader["client_id"]);
                txtAddress.Text = Convert.ToString(reader["address"]);
                txtContactNo.Text = Convert.ToString(reader["contact_no"]);
                txtValidID.Text = Convert.ToString(reader["valid_id"]);
                SetCombo(cmbStatus, Convert.ToString(reader["account_status"]));
                SetCombo(cmbGender, Convert.ToString(reader["gender"]));
                if (reader["birthdate"] is DateTime bd)
                {
                    bd = bd.Date;
                    if (bd >= dtpBirthdate.MinDate && bd <= dtpBirthdate.MaxDate)
                        dtpBirthdate.Value = bd;
                }
                SetCombo(cmbCivilStatus, Convert.ToString(reader["civil_status"]));
                txtOccupation.Text = Convert.ToString(reader["occupation"]);
                SetCombo(cmbIncome, Convert.ToString(reader["income"]));
                txtNotes.Text = Convert.ToString(reader["notes"]);
                if (reader["created_at"] is DateTime ca && ca >= dtpRegistered.MinDate && ca <= dtpRegistered.MaxDate)
                    dtpRegistered.Value = ca;
                ApplyRegisteredState(true);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error loading your record: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnAddClient_Click(object sender, EventArgs e)
    {
        if (!ValidateInputs()) return;

        try
        {
            using var conn = new MySqlConnection(ConnectionString);
            conn.Open();

            using (var check = new MySqlCommand("SELECT client_id FROM clients WHERE full_name = @name LIMIT 1", conn))
            {
                check.Parameters.AddWithValue("@name", txtFullName.Text.Trim());
                if (check.ExecuteScalar() != null)
                {
                    MessageBox.Show("You're already registered.", "Already Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ApplyRegisteredState(true);
                    return;
                }
            }

            const string sql = "INSERT INTO clients (full_name, address, contact_no, valid_id, account_status, gender, birthdate, civil_status, occupation, income, notes, created_at) VALUES (@name, @address, @contact, @valid_id, @status, @gender, @birthdate, @civil_status, @occupation, @income, @notes, @created_at)";
            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", txtFullName.Text.Trim());
            AddSharedParameters(cmd);
            cmd.Parameters.AddWithValue("@created_at", DateTime.Now);
            cmd.ExecuteNonQuery();

            selectedClientId = (int)cmd.LastInsertedId;
            ApplyRegisteredState(true);
            MessageBox.Show("Client added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error adding client: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnUpdateClient_Click(object sender, EventArgs e)
    {
        if (selectedClientId == -1)
        {
            MessageBox.Show("No saved record found to update. Please add your client record first.", "Nothing to Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        if (!string.Equals(txtFullName.Text, frmlogin.LoggedInUsername, StringComparison.Ordinal))
        {
            MessageBox.Show("You can only update your own client record.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }
        if (!ValidateInputs()) return;

        try
        {
            using var conn = new MySqlConnection(ConnectionString);
            conn.Open();
            const string sql = "UPDATE clients SET address=@address, contact_no=@contact, valid_id=@valid_id, account_status=@status, gender=@gender, birthdate=@birthdate, civil_status=@civil_status, occupation=@occupation, income=@income, notes=@notes WHERE client_id=@id AND full_name=@name";
            using var cmd = new MySqlCommand(sql, conn);
            AddSharedParameters(cmd);
            cmd.Parameters.AddWithValue("@id", selectedClientId);
            cmd.Parameters.AddWithValue("@name", txtFullName.Text.Trim());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error updating client: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void AddSharedParameters(MySqlCommand cmd)
    {
        cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
        cmd.Parameters.AddWithValue("@contact", NormalizePhone(txtContactNo.Text));
        cmd.Parameters.AddWithValue("@valid_id", txtValidID.Text.Trim());
        cmd.Parameters.AddWithValue("@status", cmbStatus.Text);
        cmd.Parameters.AddWithValue("@gender", cmbGender.Text);
        cmd.Parameters.AddWithValue("@birthdate", dtpBirthdate.Value.Date);
        cmd.Parameters.AddWithValue("@civil_status", cmbCivilStatus.Text);
        cmd.Parameters.AddWithValue("@occupation", txtOccupation.Text.Trim());
        cmd.Parameters.AddWithValue("@income", cmbIncome.Text);
        cmd.Parameters.AddWithValue("@notes", txtNotes.Text.Trim());
    }

    // =====================================================================
    //  Validation / helpers
    // =====================================================================
    private bool ValidateInputs()
    {
        if (string.IsNullOrWhiteSpace(txtFullName.Text))
            return Fail("Your account name is missing. Please log in again.", txtFullName);
        if (cmbGender.SelectedIndex < 0)
            return Fail("Please select your gender.", cmbGender);

        if (CalculateAge(dtpBirthdate.Value.Date) < 18)
            return Fail("Clients must be at least 18 years old.", dtpBirthdate);

        if (cmbCivilStatus.SelectedIndex < 0)
            return Fail("Please select your civil status.", cmbCivilStatus);

        if (!Regex.IsMatch(NormalizePhone(txtContactNo.Text), @"^(09\d{9}|\+639\d{9})$"))
            return Fail("Please enter a valid Philippine mobile number (e.g. 09171234567 or +639171234567).", txtContactNo);

        if (string.IsNullOrWhiteSpace(txtAddress.Text))
            return Fail("Please enter your address.", txtAddress);
        if (string.IsNullOrWhiteSpace(txtValidID.Text))
            return Fail("Please enter your valid ID number.", txtValidID);
        if (cmbIncome.SelectedIndex < 0)
            return Fail("Please select your monthly income range.", cmbIncome);
        if (cmbStatus.SelectedIndex < 0)
            return Fail("Please select the account status.", cmbStatus);

        return true;
    }

    private static bool Fail(string message, Control focus)
    {
        MessageBox.Show(message, "Missing or Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        focus.Focus();
        return false;
    }

    private static string NormalizePhone(string raw)
    {
        return Regex.Replace(raw ?? string.Empty, @"[\s\-]", "");
    }

    private static int CalculateAge(DateTime birthdate)
    {
        DateTime today = DateTime.Today;
        int age = today.Year - birthdate.Year;
        if (birthdate > today.AddYears(-age)) age--;
        return age;
    }

    private static void SetCombo(ComboBox combo, string value)
    {
        combo.SelectedIndex = combo.FindStringExact(value ?? string.Empty);
    }

    private void ApplyRegisteredState(bool registered)
    {
        btnAddClient.Enabled = !registered;
        btnUpdateClient.Enabled = registered;

        if (registered)
        {
            lblStatus.Text = "✓  You're already registered.\r\nYou can update your details.";
            lblStatus.ForeColor = SuccessColor;
        }
        else
        {
            lblStatus.Text = "Not registered yet.\r\nFill in the form, then click Add Client.";
            lblStatus.ForeColor = MutedColor;
        }
    }

    private void ClearFields()
    {
        txtAddress.Clear();
        txtContactNo.Clear();
        txtValidID.Clear();
        cmbStatus.SelectedIndex = 0;
        cmbGender.SelectedIndex = -1;
        dtpBirthdate.Value = DateTime.Today.AddYears(-18);
        cmbCivilStatus.SelectedIndex = -1;
        txtOccupation.Clear();
        cmbIncome.SelectedIndex = -1;
        txtNotes.Clear();
    }

    // =====================================================================
    //  Map
    // =====================================================================
    private void btnViewMap_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtAddress.Text))
        {
            MessageBox.Show("Please enter an address first.", "Missing Address", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            txtAddress.Focus();
            return;
        }

        string mapUrl = "https://www.google.com/maps/search/?api=1&query=" + Uri.EscapeDataString(txtAddress.Text.Trim());
        try
        {
            Process.Start(new ProcessStartInfo { FileName = mapUrl, UseShellExecute = true });
        }
        catch (Exception ex)
        {
            MessageBox.Show("Failed to open map: " + ex.Message);
        }
    }
}