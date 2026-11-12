namespace MicrofinanceSystem;

partial class frmLoans
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        this.tlpBody = new System.Windows.Forms.TableLayoutPanel();
        this.pnlFormCard = new System.Windows.Forms.Panel();
        this.lblFormTitle = new System.Windows.Forms.Label();
        this.lblAmount = new System.Windows.Forms.Label();
        this.txtamount = new System.Windows.Forms.TextBox();
        this.lblInterest = new System.Windows.Forms.Label();
        this.txtinterest = new System.Windows.Forms.TextBox();
        this.lblTerm = new System.Windows.Forms.Label();
        this.txtterm = new System.Windows.Forms.TextBox();
        this.lblStart = new System.Windows.Forms.Label();
        this.dtStart = new System.Windows.Forms.DateTimePicker();
        this.lblMonthly = new System.Windows.Forms.Label();
        this.txtmonthly = new System.Windows.Forms.TextBox();
        this.lblSummary = new System.Windows.Forms.Label();
        this.btnsave = new System.Windows.Forms.Button();
        this.btnPay = new System.Windows.Forms.Button();
        this.pnlLoansCard = new System.Windows.Forms.Panel();
        this.dgvloans = new System.Windows.Forms.DataGridView();
        this.lblLoansTitle = new System.Windows.Forms.Label();
        this.pnlHeader = new System.Windows.Forms.Panel();
        this.btnBack = new System.Windows.Forms.Button();
        this.lblTitle = new System.Windows.Forms.Label();
        this.txtLoggedInUser = new System.Windows.Forms.Label();
        this.tlpBody.SuspendLayout();
        this.pnlFormCard.SuspendLayout();
        this.pnlLoansCard.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvloans)).BeginInit();
        this.pnlHeader.SuspendLayout();
        this.SuspendLayout();
        //
        // tlpBody
        //
        this.tlpBody.ColumnCount = 2;
        this.tlpBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 410F));
        this.tlpBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this.tlpBody.Controls.Add(this.pnlFormCard, 0, 0);
        this.tlpBody.Controls.Add(this.pnlLoansCard, 1, 0);
        this.tlpBody.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tlpBody.Location = new System.Drawing.Point(0, 84);
        this.tlpBody.Name = "tlpBody";
        this.tlpBody.Padding = new System.Windows.Forms.Padding(12);
        this.tlpBody.RowCount = 1;
        this.tlpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this.tlpBody.Size = new System.Drawing.Size(1180, 656);
        this.tlpBody.TabIndex = 0;
        //
        // pnlFormCard
        //
        this.pnlFormCard.AutoScroll = true;
        this.pnlFormCard.BackColor = System.Drawing.Color.White;
        this.pnlFormCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlFormCard.Controls.Add(this.lblFormTitle);
        this.pnlFormCard.Controls.Add(this.lblAmount);
        this.pnlFormCard.Controls.Add(this.txtamount);
        this.pnlFormCard.Controls.Add(this.lblInterest);
        this.pnlFormCard.Controls.Add(this.txtinterest);
        this.pnlFormCard.Controls.Add(this.lblTerm);
        this.pnlFormCard.Controls.Add(this.txtterm);
        this.pnlFormCard.Controls.Add(this.lblStart);
        this.pnlFormCard.Controls.Add(this.dtStart);
        this.pnlFormCard.Controls.Add(this.lblMonthly);
        this.pnlFormCard.Controls.Add(this.txtmonthly);
        this.pnlFormCard.Controls.Add(this.lblSummary);
        this.pnlFormCard.Controls.Add(this.btnsave);
        this.pnlFormCard.Controls.Add(this.btnPay);
        this.pnlFormCard.Dock = System.Windows.Forms.DockStyle.Fill;
        this.pnlFormCard.Location = new System.Drawing.Point(20, 20);
        this.pnlFormCard.Margin = new System.Windows.Forms.Padding(8);
        this.pnlFormCard.Name = "pnlFormCard";
        this.pnlFormCard.Size = new System.Drawing.Size(394, 616);
        this.pnlFormCard.TabIndex = 0;
        //
        // lblFormTitle
        //
        this.lblFormTitle.AutoSize = true;
        this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
        this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
        this.lblFormTitle.Location = new System.Drawing.Point(22, 18);
        this.lblFormTitle.Name = "lblFormTitle";
        this.lblFormTitle.Size = new System.Drawing.Size(185, 25);
        this.lblFormTitle.TabIndex = 0;
        this.lblFormTitle.Text = "New Loan Application";
        //
        // lblAmount
        //
        this.lblAmount.AutoSize = true;
        this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblAmount.Location = new System.Drawing.Point(22, 62);
        this.lblAmount.Name = "lblAmount";
        this.lblAmount.Size = new System.Drawing.Size(90, 19);
        this.lblAmount.TabIndex = 1;
        this.lblAmount.Text = "Amount (₱)";
        //
        // txtamount
        //
        this.txtamount.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        this.txtamount.Location = new System.Drawing.Point(22, 86);
        this.txtamount.MaxLength = 12;
        this.txtamount.Name = "txtamount";
        this.txtamount.Size = new System.Drawing.Size(346, 27);
        this.txtamount.TabIndex = 2;
        this.txtamount.TextChanged += new System.EventHandler(this.LoanInput_TextChanged);
        this.txtamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecimalInput_KeyPress);
        //
        // lblInterest
        //
        this.lblInterest.AutoSize = true;
        this.lblInterest.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblInterest.Location = new System.Drawing.Point(22, 128);
        this.lblInterest.Name = "lblInterest";
        this.lblInterest.Size = new System.Drawing.Size(115, 19);
        this.lblInterest.TabIndex = 3;
        this.lblInterest.Text = "Interest Rate (%)";
        //
        // txtinterest
        //
        this.txtinterest.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        this.txtinterest.Location = new System.Drawing.Point(22, 152);
        this.txtinterest.MaxLength = 6;
        this.txtinterest.Name = "txtinterest";
        this.txtinterest.Size = new System.Drawing.Size(346, 27);
        this.txtinterest.TabIndex = 4;
        this.txtinterest.TextChanged += new System.EventHandler(this.LoanInput_TextChanged);
        this.txtinterest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecimalInput_KeyPress);
        //
        // lblTerm
        //
        this.lblTerm.AutoSize = true;
        this.lblTerm.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblTerm.Location = new System.Drawing.Point(22, 194);
        this.lblTerm.Name = "lblTerm";
        this.lblTerm.Size = new System.Drawing.Size(101, 19);
        this.lblTerm.TabIndex = 5;
        this.lblTerm.Text = "Term (Months)";
        //
        // txtterm
        //
        this.txtterm.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        this.txtterm.Location = new System.Drawing.Point(22, 218);
        this.txtterm.MaxLength = 3;
        this.txtterm.Name = "txtterm";
        this.txtterm.Size = new System.Drawing.Size(346, 27);
        this.txtterm.TabIndex = 6;
        this.txtterm.TextChanged += new System.EventHandler(this.LoanInput_TextChanged);
        this.txtterm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntegerInput_KeyPress);
        //
        // lblStart
        //
        this.lblStart.AutoSize = true;
        this.lblStart.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblStart.Location = new System.Drawing.Point(22, 260);
        this.lblStart.Name = "lblStart";
        this.lblStart.Size = new System.Drawing.Size(66, 19);
        this.lblStart.TabIndex = 7;
        this.lblStart.Text = "Start Date";
        //
        // dtStart
        //
        this.dtStart.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dtStart.Location = new System.Drawing.Point(22, 284);
        this.dtStart.Name = "dtStart";
        this.dtStart.Size = new System.Drawing.Size(346, 27);
        this.dtStart.TabIndex = 8;
        //
        // lblMonthly
        //
        this.lblMonthly.AutoSize = true;
        this.lblMonthly.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblMonthly.Location = new System.Drawing.Point(22, 326);
        this.lblMonthly.Name = "lblMonthly";
        this.lblMonthly.Size = new System.Drawing.Size(118, 19);
        this.lblMonthly.TabIndex = 9;
        this.lblMonthly.Text = "Monthly Payment";
        //
        // txtmonthly
        //
        this.txtmonthly.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        this.txtmonthly.BackColor = System.Drawing.Color.FromArgb(238, 242, 247);
        this.txtmonthly.Location = new System.Drawing.Point(22, 350);
        this.txtmonthly.Name = "txtmonthly";
        this.txtmonthly.ReadOnly = true;
        this.txtmonthly.Size = new System.Drawing.Size(346, 27);
        this.txtmonthly.TabIndex = 10;
        this.txtmonthly.TabStop = false;
        //
        // lblSummary
        //
        this.lblSummary.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        this.lblSummary.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.lblSummary.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblSummary.Location = new System.Drawing.Point(22, 388);
        this.lblSummary.Name = "lblSummary";
        this.lblSummary.Size = new System.Drawing.Size(346, 40);
        this.lblSummary.TabIndex = 11;
        this.lblSummary.Text = "Enter the loan details to see the total repayable amount.";
        //
        // btnsave
        //
        this.btnsave.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        this.btnsave.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
        this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnsave.FlatAppearance.BorderSize = 0;
        this.btnsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(29, 78, 216);
        this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnsave.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
        this.btnsave.ForeColor = System.Drawing.Color.White;
        this.btnsave.Location = new System.Drawing.Point(22, 440);
        this.btnsave.Name = "btnsave";
        this.btnsave.Size = new System.Drawing.Size(346, 46);
        this.btnsave.TabIndex = 12;
        this.btnsave.Text = "Save Loan";
        this.btnsave.UseVisualStyleBackColor = false;
        this.btnsave.Click += new System.EventHandler(this.btnSave_Click);
        //
        // btnPay
        //
        this.btnPay.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        this.btnPay.BackColor = System.Drawing.Color.White;
        this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnPay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(180, 192, 210);
        this.btnPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(238, 242, 247);
        this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnPay.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
        this.btnPay.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
        this.btnPay.Location = new System.Drawing.Point(22, 496);
        this.btnPay.Name = "btnPay";
        this.btnPay.Size = new System.Drawing.Size(346, 46);
        this.btnPay.TabIndex = 13;
        this.btnPay.Text = "Make a Payment";
        this.btnPay.UseVisualStyleBackColor = false;
        this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
        //
        // pnlLoansCard
        //
        this.pnlLoansCard.BackColor = System.Drawing.Color.White;
        this.pnlLoansCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlLoansCard.Controls.Add(this.dgvloans);
        this.pnlLoansCard.Controls.Add(this.lblLoansTitle);
        this.pnlLoansCard.Dock = System.Windows.Forms.DockStyle.Fill;
        this.pnlLoansCard.Location = new System.Drawing.Point(430, 20);
        this.pnlLoansCard.Margin = new System.Windows.Forms.Padding(8);
        this.pnlLoansCard.Name = "pnlLoansCard";
        this.pnlLoansCard.Size = new System.Drawing.Size(730, 616);
        this.pnlLoansCard.TabIndex = 1;
        //
        // dgvloans
        //
        this.dgvloans.AllowUserToAddRows = false;
        this.dgvloans.AllowUserToDeleteRows = false;
        this.dgvloans.AllowUserToResizeRows = false;
        this.dgvloans.BackgroundColor = System.Drawing.Color.White;
        this.dgvloans.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.dgvloans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        this.dgvloans.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dgvloans.EnableHeadersVisualStyles = false;
        this.dgvloans.GridColor = System.Drawing.Color.FromArgb(233, 238, 246);
        this.dgvloans.Location = new System.Drawing.Point(0, 52);
        this.dgvloans.MultiSelect = false;
        this.dgvloans.Name = "dgvloans";
        this.dgvloans.ReadOnly = true;
        this.dgvloans.RowHeadersVisible = false;
        this.dgvloans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvloans.Size = new System.Drawing.Size(728, 562);
        this.dgvloans.TabIndex = 1;
        //
        // lblLoansTitle
        //
        this.lblLoansTitle.Dock = System.Windows.Forms.DockStyle.Top;
        this.lblLoansTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
        this.lblLoansTitle.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
        this.lblLoansTitle.Location = new System.Drawing.Point(0, 0);
        this.lblLoansTitle.Name = "lblLoansTitle";
        this.lblLoansTitle.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
        this.lblLoansTitle.Size = new System.Drawing.Size(728, 52);
        this.lblLoansTitle.TabIndex = 0;
        this.lblLoansTitle.Text = "My Loans";
        this.lblLoansTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //
        // pnlHeader
        //
        this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
        this.pnlHeader.Controls.Add(this.btnBack);
        this.pnlHeader.Controls.Add(this.lblTitle);
        this.pnlHeader.Controls.Add(this.txtLoggedInUser);
        this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        this.pnlHeader.Location = new System.Drawing.Point(0, 0);
        this.pnlHeader.Name = "pnlHeader";
        this.pnlHeader.Size = new System.Drawing.Size(1180, 84);
        this.pnlHeader.TabIndex = 1;
        //
        // btnBack
        //
        this.btnBack.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
        this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(120, 150, 190);
        this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(46, 79, 125);
        this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.btnBack.ForeColor = System.Drawing.Color.White;
        this.btnBack.Location = new System.Drawing.Point(24, 23);
        this.btnBack.Name = "btnBack";
        this.btnBack.Size = new System.Drawing.Size(100, 38);
        this.btnBack.TabIndex = 0;
        this.btnBack.Text = "←  Back";
        this.btnBack.UseVisualStyleBackColor = false;
        this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
        //
        // lblTitle
        //
        this.lblTitle.AutoSize = true;
        this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        this.lblTitle.ForeColor = System.Drawing.Color.White;
        this.lblTitle.Location = new System.Drawing.Point(144, 10);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(77, 37);
        this.lblTitle.TabIndex = 1;
        this.lblTitle.Text = "Loans";
        //
        // txtLoggedInUser
        //
        this.txtLoggedInUser.AutoSize = true;
        this.txtLoggedInUser.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.txtLoggedInUser.ForeColor = System.Drawing.Color.FromArgb(190, 205, 225);
        this.txtLoggedInUser.Location = new System.Drawing.Point(147, 50);
        this.txtLoggedInUser.Name = "txtLoggedInUser";
        this.txtLoggedInUser.Size = new System.Drawing.Size(85, 19);
        this.txtLoggedInUser.TabIndex = 2;
        this.txtLoggedInUser.Text = "Signed in as";
        //
        // frmLoans
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        this.BackColor = System.Drawing.Color.FromArgb(243, 246, 251);
        this.ClientSize = new System.Drawing.Size(1180, 740);
        this.Controls.Add(this.tlpBody);
        this.Controls.Add(this.pnlHeader);
        this.Font = new System.Drawing.Font("Segoe UI", 10.5F);
        this.MinimumSize = new System.Drawing.Size(1000, 700);
        this.Name = "frmLoans";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Loans";
        this.Load += new System.EventHandler(this.frmLoans_Load);
        this.tlpBody.ResumeLayout(false);
        this.pnlFormCard.ResumeLayout(false);
        this.pnlFormCard.PerformLayout();
        this.pnlLoansCard.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dgvloans)).EndInit();
        this.pnlHeader.ResumeLayout(false);
        this.pnlHeader.PerformLayout();
        this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tlpBody;
    private System.Windows.Forms.Panel pnlFormCard;
    private System.Windows.Forms.Label lblFormTitle;
    private System.Windows.Forms.Label lblAmount;
    private System.Windows.Forms.TextBox txtamount;
    private System.Windows.Forms.Label lblInterest;
    private System.Windows.Forms.TextBox txtinterest;
    private System.Windows.Forms.Label lblTerm;
    private System.Windows.Forms.TextBox txtterm;
    private System.Windows.Forms.Label lblStart;
    private System.Windows.Forms.DateTimePicker dtStart;
    private System.Windows.Forms.Label lblMonthly;
    private System.Windows.Forms.TextBox txtmonthly;
    private System.Windows.Forms.Label lblSummary;
    private System.Windows.Forms.Button btnsave;
    private System.Windows.Forms.Button btnPay;
    private System.Windows.Forms.Panel pnlLoansCard;
    private System.Windows.Forms.DataGridView dgvloans;
    private System.Windows.Forms.Label lblLoansTitle;
    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Button btnBack;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label txtLoggedInUser;
}