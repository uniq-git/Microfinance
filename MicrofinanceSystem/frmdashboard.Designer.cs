namespace MicrofinanceSystem;

partial class frmDashboard
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
        this.pnlMain = new System.Windows.Forms.Panel();
        this.tlpTiles = new System.Windows.Forms.TableLayoutPanel();
        this.btnClients = new System.Windows.Forms.Button();
        this.btnLoans = new System.Windows.Forms.Button();
        this.btnPayments = new System.Windows.Forms.Button();
        this.btnHistory = new System.Windows.Forms.Button();
        this.btnFeedback = new System.Windows.Forms.Button();
        this.btnCredits = new System.Windows.Forms.Button();
        this.lblSubtitle = new System.Windows.Forms.Label();
        this.lblTitle = new System.Windows.Forms.Label();
        this.pnlSidebar = new System.Windows.Forms.Panel();
        this.lblWelcome = new System.Windows.Forms.Label();
        this.txtLoggedInUser = new System.Windows.Forms.Label();
        this.pnlStatBalance = new System.Windows.Forms.Panel();
        this.lblBalanceCaption = new System.Windows.Forms.Label();
        this.lblTotalBalance = new System.Windows.Forms.Label();
        this.pnlStatLoans = new System.Windows.Forms.Panel();
        this.lblLoansCaption = new System.Windows.Forms.Label();
        this.lblActiveLoans = new System.Windows.Forms.Label();
        this.pnlStatClients = new System.Windows.Forms.Panel();
        this.lblClientsCaption = new System.Windows.Forms.Label();
        this.lblTotalClients = new System.Windows.Forms.Label();
        this.btnLogout = new System.Windows.Forms.Button();
        this.pnlMain.SuspendLayout();
        this.tlpTiles.SuspendLayout();
        this.pnlSidebar.SuspendLayout();
        this.pnlStatBalance.SuspendLayout();
        this.pnlStatLoans.SuspendLayout();
        this.pnlStatClients.SuspendLayout();
        this.SuspendLayout();
        //
        // pnlMain
        //
        this.pnlMain.BackColor = System.Drawing.Color.FromArgb(243, 246, 251);
        this.pnlMain.Controls.Add(this.tlpTiles);
        this.pnlMain.Controls.Add(this.lblSubtitle);
        this.pnlMain.Controls.Add(this.lblTitle);
        this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
        this.pnlMain.Location = new System.Drawing.Point(280, 0);
        this.pnlMain.Name = "pnlMain";
        this.pnlMain.Padding = new System.Windows.Forms.Padding(32, 24, 32, 28);
        this.pnlMain.Size = new System.Drawing.Size(920, 720);
        this.pnlMain.TabIndex = 0;
        //
        // tlpTiles
        //
        this.tlpTiles.ColumnCount = 3;
        this.tlpTiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
        this.tlpTiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
        this.tlpTiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
        this.tlpTiles.Controls.Add(this.btnClients, 0, 0);
        this.tlpTiles.Controls.Add(this.btnLoans, 1, 0);
        this.tlpTiles.Controls.Add(this.btnPayments, 2, 0);
        this.tlpTiles.Controls.Add(this.btnHistory, 0, 1);
        this.tlpTiles.Controls.Add(this.btnFeedback, 1, 1);
        this.tlpTiles.Controls.Add(this.btnCredits, 2, 1);
        this.tlpTiles.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tlpTiles.Location = new System.Drawing.Point(32, 142);
        this.tlpTiles.Name = "tlpTiles";
        this.tlpTiles.RowCount = 2;
        this.tlpTiles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        this.tlpTiles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        this.tlpTiles.Size = new System.Drawing.Size(856, 550);
        this.tlpTiles.TabIndex = 2;
        //
        // btnClients
        //
        this.btnClients.BackColor = System.Drawing.Color.White;
        this.btnClients.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnClients.Dock = System.Windows.Forms.DockStyle.Fill;
        this.btnClients.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(220, 227, 238);
        this.btnClients.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(214, 228, 252);
        this.btnClients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(232, 240, 254);
        this.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnClients.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        this.btnClients.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
        this.btnClients.Location = new System.Drawing.Point(8, 8);
        this.btnClients.Margin = new System.Windows.Forms.Padding(8);
        this.btnClients.Name = "btnClients";
        this.btnClients.Size = new System.Drawing.Size(269, 259);
        this.btnClients.TabIndex = 0;
        this.btnClients.Text = "Clients";
        this.btnClients.UseVisualStyleBackColor = false;
        this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
        //
        // btnLoans
        //
        this.btnLoans.BackColor = System.Drawing.Color.White;
        this.btnLoans.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnLoans.Dock = System.Windows.Forms.DockStyle.Fill;
        this.btnLoans.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(220, 227, 238);
        this.btnLoans.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(214, 228, 252);
        this.btnLoans.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(232, 240, 254);
        this.btnLoans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnLoans.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        this.btnLoans.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
        this.btnLoans.Location = new System.Drawing.Point(293, 8);
        this.btnLoans.Margin = new System.Windows.Forms.Padding(8);
        this.btnLoans.Name = "btnLoans";
        this.btnLoans.Size = new System.Drawing.Size(269, 259);
        this.btnLoans.TabIndex = 1;
        this.btnLoans.Text = "Loans";
        this.btnLoans.UseVisualStyleBackColor = false;
        this.btnLoans.Click += new System.EventHandler(this.btnLoans_Click);
        //
        // btnPayments
        //
        this.btnPayments.BackColor = System.Drawing.Color.White;
        this.btnPayments.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnPayments.Dock = System.Windows.Forms.DockStyle.Fill;
        this.btnPayments.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(220, 227, 238);
        this.btnPayments.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(214, 228, 252);
        this.btnPayments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(232, 240, 254);
        this.btnPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnPayments.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        this.btnPayments.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
        this.btnPayments.Location = new System.Drawing.Point(578, 8);
        this.btnPayments.Margin = new System.Windows.Forms.Padding(8);
        this.btnPayments.Name = "btnPayments";
        this.btnPayments.Size = new System.Drawing.Size(270, 259);
        this.btnPayments.TabIndex = 2;
        this.btnPayments.Text = "Payments";
        this.btnPayments.UseVisualStyleBackColor = false;
        this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
        //
        // btnHistory
        //
        this.btnHistory.BackColor = System.Drawing.Color.White;
        this.btnHistory.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnHistory.Dock = System.Windows.Forms.DockStyle.Fill;
        this.btnHistory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(220, 227, 238);
        this.btnHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(214, 228, 252);
        this.btnHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(232, 240, 254);
        this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnHistory.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        this.btnHistory.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
        this.btnHistory.Location = new System.Drawing.Point(8, 283);
        this.btnHistory.Margin = new System.Windows.Forms.Padding(8);
        this.btnHistory.Name = "btnHistory";
        this.btnHistory.Size = new System.Drawing.Size(269, 259);
        this.btnHistory.TabIndex = 3;
        this.btnHistory.Text = "Transaction History";
        this.btnHistory.UseVisualStyleBackColor = false;
        this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
        //
        // btnFeedback
        //
        this.btnFeedback.BackColor = System.Drawing.Color.White;
        this.btnFeedback.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnFeedback.Dock = System.Windows.Forms.DockStyle.Fill;
        this.btnFeedback.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(220, 227, 238);
        this.btnFeedback.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(214, 228, 252);
        this.btnFeedback.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(232, 240, 254);
        this.btnFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnFeedback.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        this.btnFeedback.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
        this.btnFeedback.Location = new System.Drawing.Point(293, 283);
        this.btnFeedback.Margin = new System.Windows.Forms.Padding(8);
        this.btnFeedback.Name = "btnFeedback";
        this.btnFeedback.Size = new System.Drawing.Size(269, 259);
        this.btnFeedback.TabIndex = 4;
        this.btnFeedback.Text = "Feedback";
        this.btnFeedback.UseVisualStyleBackColor = false;
        this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
        //
        // btnCredits
        //
        this.btnCredits.BackColor = System.Drawing.Color.White;
        this.btnCredits.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnCredits.Dock = System.Windows.Forms.DockStyle.Fill;
        this.btnCredits.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(220, 227, 238);
        this.btnCredits.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(214, 228, 252);
        this.btnCredits.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(232, 240, 254);
        this.btnCredits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnCredits.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        this.btnCredits.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
        this.btnCredits.Location = new System.Drawing.Point(578, 283);
        this.btnCredits.Margin = new System.Windows.Forms.Padding(8);
        this.btnCredits.Name = "btnCredits";
        this.btnCredits.Size = new System.Drawing.Size(270, 259);
        this.btnCredits.TabIndex = 5;
        this.btnCredits.Text = "Credits";
        this.btnCredits.UseVisualStyleBackColor = false;
        this.btnCredits.Click += new System.EventHandler(this.btnCredits_Click);
        //
        // lblSubtitle
        //
        this.lblSubtitle.Dock = System.Windows.Forms.DockStyle.Top;
        this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 11F);
        this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblSubtitle.Location = new System.Drawing.Point(32, 98);
        this.lblSubtitle.Name = "lblSubtitle";
        this.lblSubtitle.Size = new System.Drawing.Size(856, 44);
        this.lblSubtitle.TabIndex = 1;
        this.lblSubtitle.Text = "Choose a module to get started.";
        this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.TopLeft;
        //
        // lblTitle
        //
        this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
        this.lblTitle.Font = new System.Drawing.Font("Segoe UI Light", 32F);
        this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
        this.lblTitle.Location = new System.Drawing.Point(32, 24);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(856, 74);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "Dashboard";
        this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //
        // pnlSidebar
        //
        this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
        this.pnlSidebar.Controls.Add(this.lblWelcome);
        this.pnlSidebar.Controls.Add(this.txtLoggedInUser);
        this.pnlSidebar.Controls.Add(this.pnlStatBalance);
        this.pnlSidebar.Controls.Add(this.pnlStatLoans);
        this.pnlSidebar.Controls.Add(this.pnlStatClients);
        this.pnlSidebar.Controls.Add(this.btnLogout);
        this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
        this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
        this.pnlSidebar.Name = "pnlSidebar";
        this.pnlSidebar.Size = new System.Drawing.Size(280, 720);
        this.pnlSidebar.TabIndex = 1;
        //
        // lblWelcome
        //
        this.lblWelcome.Font = new System.Drawing.Font("Segoe UI Light", 26F);
        this.lblWelcome.ForeColor = System.Drawing.Color.White;
        this.lblWelcome.Location = new System.Drawing.Point(22, 28);
        this.lblWelcome.Name = "lblWelcome";
        this.lblWelcome.Size = new System.Drawing.Size(236, 52);
        this.lblWelcome.TabIndex = 0;
        this.lblWelcome.Text = "Welcome!";
        //
        // txtLoggedInUser
        //
        this.txtLoggedInUser.AutoEllipsis = true;
        this.txtLoggedInUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        this.txtLoggedInUser.ForeColor = System.Drawing.Color.FromArgb(190, 205, 225);
        this.txtLoggedInUser.Location = new System.Drawing.Point(26, 84);
        this.txtLoggedInUser.Name = "txtLoggedInUser";
        this.txtLoggedInUser.Size = new System.Drawing.Size(232, 28);
        this.txtLoggedInUser.TabIndex = 1;
        this.txtLoggedInUser.Text = "Hi, User!";
        //
        // pnlStatBalance
        //
        this.pnlStatBalance.BackColor = System.Drawing.Color.FromArgb(46, 79, 125);
        this.pnlStatBalance.Controls.Add(this.lblBalanceCaption);
        this.pnlStatBalance.Controls.Add(this.lblTotalBalance);
        this.pnlStatBalance.Location = new System.Drawing.Point(24, 148);
        this.pnlStatBalance.Name = "pnlStatBalance";
        this.pnlStatBalance.Size = new System.Drawing.Size(232, 76);
        this.pnlStatBalance.TabIndex = 2;
        //
        // lblBalanceCaption
        //
        this.lblBalanceCaption.AutoSize = true;
        this.lblBalanceCaption.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.lblBalanceCaption.ForeColor = System.Drawing.Color.FromArgb(190, 205, 225);
        this.lblBalanceCaption.Location = new System.Drawing.Point(14, 10);
        this.lblBalanceCaption.Name = "lblBalanceCaption";
        this.lblBalanceCaption.Size = new System.Drawing.Size(81, 17);
        this.lblBalanceCaption.TabIndex = 0;
        this.lblBalanceCaption.Text = "Loan Balance";
        //
        // lblTotalBalance
        //
        this.lblTotalBalance.AutoEllipsis = true;
        this.lblTotalBalance.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
        this.lblTotalBalance.ForeColor = System.Drawing.Color.White;
        this.lblTotalBalance.Location = new System.Drawing.Point(12, 30);
        this.lblTotalBalance.Name = "lblTotalBalance";
        this.lblTotalBalance.Size = new System.Drawing.Size(210, 36);
        this.lblTotalBalance.TabIndex = 1;
        this.lblTotalBalance.Text = "₱0.00";
        //
        // pnlStatLoans
        //
        this.pnlStatLoans.BackColor = System.Drawing.Color.FromArgb(46, 79, 125);
        this.pnlStatLoans.Controls.Add(this.lblLoansCaption);
        this.pnlStatLoans.Controls.Add(this.lblActiveLoans);
        this.pnlStatLoans.Location = new System.Drawing.Point(24, 236);
        this.pnlStatLoans.Name = "pnlStatLoans";
        this.pnlStatLoans.Size = new System.Drawing.Size(232, 76);
        this.pnlStatLoans.TabIndex = 3;
        //
        // lblLoansCaption
        //
        this.lblLoansCaption.AutoSize = true;
        this.lblLoansCaption.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.lblLoansCaption.ForeColor = System.Drawing.Color.FromArgb(190, 205, 225);
        this.lblLoansCaption.Location = new System.Drawing.Point(14, 10);
        this.lblLoansCaption.Name = "lblLoansCaption";
        this.lblLoansCaption.Size = new System.Drawing.Size(73, 17);
        this.lblLoansCaption.TabIndex = 0;
        this.lblLoansCaption.Text = "Active Loans";
        //
        // lblActiveLoans
        //
        this.lblActiveLoans.AutoEllipsis = true;
        this.lblActiveLoans.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
        this.lblActiveLoans.ForeColor = System.Drawing.Color.White;
        this.lblActiveLoans.Location = new System.Drawing.Point(12, 30);
        this.lblActiveLoans.Name = "lblActiveLoans";
        this.lblActiveLoans.Size = new System.Drawing.Size(210, 36);
        this.lblActiveLoans.TabIndex = 1;
        this.lblActiveLoans.Text = "0";
        //
        // pnlStatClients
        //
        this.pnlStatClients.BackColor = System.Drawing.Color.FromArgb(46, 79, 125);
        this.pnlStatClients.Controls.Add(this.lblClientsCaption);
        this.pnlStatClients.Controls.Add(this.lblTotalClients);
        this.pnlStatClients.Location = new System.Drawing.Point(24, 324);
        this.pnlStatClients.Name = "pnlStatClients";
        this.pnlStatClients.Size = new System.Drawing.Size(232, 76);
        this.pnlStatClients.TabIndex = 4;
        //
        // lblClientsCaption
        //
        this.lblClientsCaption.AutoSize = true;
        this.lblClientsCaption.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.lblClientsCaption.ForeColor = System.Drawing.Color.FromArgb(190, 205, 225);
        this.lblClientsCaption.Location = new System.Drawing.Point(14, 10);
        this.lblClientsCaption.Name = "lblClientsCaption";
        this.lblClientsCaption.Size = new System.Drawing.Size(77, 17);
        this.lblClientsCaption.TabIndex = 0;
        this.lblClientsCaption.Text = "Total Clients";
        //
        // lblTotalClients
        //
        this.lblTotalClients.AutoEllipsis = true;
        this.lblTotalClients.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
        this.lblTotalClients.ForeColor = System.Drawing.Color.White;
        this.lblTotalClients.Location = new System.Drawing.Point(12, 30);
        this.lblTotalClients.Name = "lblTotalClients";
        this.lblTotalClients.Size = new System.Drawing.Size(210, 36);
        this.lblTotalClients.TabIndex = 1;
        this.lblTotalClients.Text = "0";
        //
        // btnLogout
        //
        this.btnLogout.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        this.btnLogout.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
        this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(120, 150, 190);
        this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(46, 79, 125);
        this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        this.btnLogout.ForeColor = System.Drawing.Color.White;
        this.btnLogout.Location = new System.Drawing.Point(24, 654);
        this.btnLogout.Name = "btnLogout";
        this.btnLogout.Size = new System.Drawing.Size(232, 44);
        this.btnLogout.TabIndex = 5;
        this.btnLogout.Text = "Logout";
        this.btnLogout.UseVisualStyleBackColor = false;
        this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
        //
        // frmDashboard
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        this.BackColor = System.Drawing.Color.FromArgb(243, 246, 251);
        this.ClientSize = new System.Drawing.Size(1200, 720);
        this.Controls.Add(this.pnlMain);
        this.Controls.Add(this.pnlSidebar);
        this.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.MinimumSize = new System.Drawing.Size(1000, 640);
        this.Name = "frmDashboard";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Dashboard";
        this.Activated += new System.EventHandler(this.frmDashboard_Activated);
        this.pnlMain.ResumeLayout(false);
        this.tlpTiles.ResumeLayout(false);
        this.pnlSidebar.ResumeLayout(false);
        this.pnlStatBalance.ResumeLayout(false);
        this.pnlStatBalance.PerformLayout();
        this.pnlStatLoans.ResumeLayout(false);
        this.pnlStatLoans.PerformLayout();
        this.pnlStatClients.ResumeLayout(false);
        this.pnlStatClients.PerformLayout();
        this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlMain;
    private System.Windows.Forms.TableLayoutPanel tlpTiles;
    private System.Windows.Forms.Button btnClients;
    private System.Windows.Forms.Button btnLoans;
    private System.Windows.Forms.Button btnPayments;
    private System.Windows.Forms.Button btnHistory;
    private System.Windows.Forms.Button btnFeedback;
    private System.Windows.Forms.Button btnCredits;
    private System.Windows.Forms.Label lblSubtitle;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Panel pnlSidebar;
    private System.Windows.Forms.Label lblWelcome;
    private System.Windows.Forms.Label txtLoggedInUser;
    private System.Windows.Forms.Panel pnlStatBalance;
    private System.Windows.Forms.Label lblBalanceCaption;
    private System.Windows.Forms.Label lblTotalBalance;
    private System.Windows.Forms.Panel pnlStatLoans;
    private System.Windows.Forms.Label lblLoansCaption;
    private System.Windows.Forms.Label lblActiveLoans;
    private System.Windows.Forms.Panel pnlStatClients;
    private System.Windows.Forms.Label lblClientsCaption;
    private System.Windows.Forms.Label lblTotalClients;
    private System.Windows.Forms.Button btnLogout;
}