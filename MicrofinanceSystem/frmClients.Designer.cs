namespace MicrofinanceSystem;

partial class frmClients
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
        pnlBody = new System.Windows.Forms.Panel();
        tlpCards = new System.Windows.Forms.TableLayoutPanel();
        pnlPersonal = new System.Windows.Forms.Panel();
        lblPersonalTitle = new System.Windows.Forms.Label();
        lblFullName = new System.Windows.Forms.Label();
        txtFullName = new System.Windows.Forms.TextBox();
        lblGender = new System.Windows.Forms.Label();
        cmbGender = new System.Windows.Forms.ComboBox();
        lblBirthdate = new System.Windows.Forms.Label();
        dtpBirthdate = new System.Windows.Forms.DateTimePicker();
        lblCivilStatus = new System.Windows.Forms.Label();
        cmbCivilStatus = new System.Windows.Forms.ComboBox();
        lblContactNo = new System.Windows.Forms.Label();
        txtContactNo = new System.Windows.Forms.TextBox();
        lblAddress = new System.Windows.Forms.Label();
        txtAddress = new System.Windows.Forms.TextBox();
        pnlAccount = new System.Windows.Forms.Panel();
        lblAccountTitle = new System.Windows.Forms.Label();
        lblAccountStatus = new System.Windows.Forms.Label();
        cmbStatus = new System.Windows.Forms.ComboBox();
        lblRegistered = new System.Windows.Forms.Label();
        dtpRegistered = new System.Windows.Forms.DateTimePicker();
        lblValidID = new System.Windows.Forms.Label();
        txtValidID = new System.Windows.Forms.TextBox();
        lblOccupation = new System.Windows.Forms.Label();
        txtOccupation = new System.Windows.Forms.TextBox();
        lblIncome = new System.Windows.Forms.Label();
        cmbIncome = new System.Windows.Forms.ComboBox();
        lblNotes = new System.Windows.Forms.Label();
        txtNotes = new System.Windows.Forms.TextBox();
        pnlHeader = new System.Windows.Forms.Panel();
        btnBack = new System.Windows.Forms.Button();
        lblTitle = new System.Windows.Forms.Label();
        lblSubtitle = new System.Windows.Forms.Label();
        pnlFooter = new System.Windows.Forms.Panel();
        pnlFooterLine = new System.Windows.Forms.Panel();
        lblStatus = new System.Windows.Forms.Label();
        btnAddClient = new System.Windows.Forms.Button();
        btnUpdateClient = new System.Windows.Forms.Button();
        btnClear = new System.Windows.Forms.Button();
        btnViewMap = new System.Windows.Forms.Button();
        pnlBody.SuspendLayout();
        tlpCards.SuspendLayout();
        pnlPersonal.SuspendLayout();
        pnlAccount.SuspendLayout();
        pnlHeader.SuspendLayout();
        pnlFooter.SuspendLayout();
        SuspendLayout();
        // 
        // pnlBody
        // 
        pnlBody.AutoScroll = true;
        pnlBody.Controls.Add(tlpCards);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 84);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(20, 20, 20, 10);
        pnlBody.Size = new System.Drawing.Size(1100, 584);
        pnlBody.TabIndex = 0;
        // 
        // tlpCards
        // 
        tlpCards.ColumnCount = 2;
        tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tlpCards.Controls.Add(pnlPersonal, 0, 0);
        tlpCards.Controls.Add(pnlAccount, 1, 0);
        tlpCards.Dock = System.Windows.Forms.DockStyle.Top;
        tlpCards.Location = new System.Drawing.Point(20, 20);
        tlpCards.Name = "tlpCards";
        tlpCards.RowCount = 1;
        tlpCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tlpCards.Size = new System.Drawing.Size(1060, 480);
        tlpCards.TabIndex = 0;
        // 
        // pnlPersonal
        // 
        pnlPersonal.BackColor = System.Drawing.Color.White;
        pnlPersonal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        pnlPersonal.Controls.Add(lblPersonalTitle);
        pnlPersonal.Controls.Add(lblFullName);
        pnlPersonal.Controls.Add(txtFullName);
        pnlPersonal.Controls.Add(lblGender);
        pnlPersonal.Controls.Add(cmbGender);
        pnlPersonal.Controls.Add(lblBirthdate);
        pnlPersonal.Controls.Add(dtpBirthdate);
        pnlPersonal.Controls.Add(lblCivilStatus);
        pnlPersonal.Controls.Add(cmbCivilStatus);
        pnlPersonal.Controls.Add(lblContactNo);
        pnlPersonal.Controls.Add(txtContactNo);
        pnlPersonal.Controls.Add(lblAddress);
        pnlPersonal.Controls.Add(txtAddress);
        pnlPersonal.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlPersonal.Location = new System.Drawing.Point(8, 8);
        pnlPersonal.Margin = new System.Windows.Forms.Padding(8);
        pnlPersonal.Name = "pnlPersonal";
        pnlPersonal.Size = new System.Drawing.Size(514, 464);
        pnlPersonal.TabIndex = 0;
        // 
        // lblPersonalTitle
        // 
        lblPersonalTitle.AutoSize = true;
        lblPersonalTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
        lblPersonalTitle.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
        lblPersonalTitle.Location = new System.Drawing.Point(22, 16);
        lblPersonalTitle.Name = "lblPersonalTitle";
        lblPersonalTitle.Size = new System.Drawing.Size(191, 25);
        lblPersonalTitle.TabIndex = 0;
        lblPersonalTitle.Text = "Personal Information";
        // 
        // lblFullName
        // 
        lblFullName.AutoSize = true;
        lblFullName.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        lblFullName.Location = new System.Drawing.Point(22, 66);
        lblFullName.Name = "lblFullName";
        lblFullName.Size = new System.Drawing.Size(70, 19);
        lblFullName.TabIndex = 1;
        lblFullName.Text = "Full Name";
        // 
        // txtFullName
        // 
        txtFullName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        txtFullName.BackColor = System.Drawing.Color.FromArgb(238, 242, 247);
        txtFullName.Location = new System.Drawing.Point(150, 62);
        txtFullName.Name = "txtFullName";
        txtFullName.ReadOnly = true;
        txtFullName.Size = new System.Drawing.Size(340, 26);
        txtFullName.TabIndex = 2;
        txtFullName.TabStop = false;
        // 
        // lblGender
        // 
        lblGender.AutoSize = true;
        lblGender.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        lblGender.Location = new System.Drawing.Point(22, 122);
        lblGender.Name = "lblGender";
        lblGender.Size = new System.Drawing.Size(54, 19);
        lblGender.TabIndex = 3;
        lblGender.Text = "Gender";
        // 
        // cmbGender
        // 
        cmbGender.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cmbGender.FormattingEnabled = true;
        cmbGender.Location = new System.Drawing.Point(150, 118);
        cmbGender.Name = "cmbGender";
        cmbGender.Size = new System.Drawing.Size(340, 27);
        cmbGender.TabIndex = 4;
        // 
        // lblBirthdate
        // 
        lblBirthdate.AutoSize = true;
        lblBirthdate.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        lblBirthdate.Location = new System.Drawing.Point(22, 178);
        lblBirthdate.Name = "lblBirthdate";
        lblBirthdate.Size = new System.Drawing.Size(65, 19);
        lblBirthdate.TabIndex = 5;
        lblBirthdate.Text = "Birthdate";
        // 
        // dtpBirthdate
        // 
        dtpBirthdate.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        dtpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        dtpBirthdate.Location = new System.Drawing.Point(150, 174);
        dtpBirthdate.Name = "dtpBirthdate";
        dtpBirthdate.Size = new System.Drawing.Size(340, 26);
        dtpBirthdate.TabIndex = 6;
        // 
        // lblCivilStatus
        // 
        lblCivilStatus.AutoSize = true;
        lblCivilStatus.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        lblCivilStatus.Location = new System.Drawing.Point(22, 234);
        lblCivilStatus.Name = "lblCivilStatus";
        lblCivilStatus.Size = new System.Drawing.Size(76, 19);
        lblCivilStatus.TabIndex = 7;
        lblCivilStatus.Text = "Civil Status";
        // 
        // cmbCivilStatus
        // 
        cmbCivilStatus.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        cmbCivilStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cmbCivilStatus.FormattingEnabled = true;
        cmbCivilStatus.Location = new System.Drawing.Point(150, 230);
        cmbCivilStatus.Name = "cmbCivilStatus";
        cmbCivilStatus.Size = new System.Drawing.Size(340, 27);
        cmbCivilStatus.TabIndex = 8;
        // 
        // lblContactNo
        // 
        lblContactNo.AutoSize = true;
        lblContactNo.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        lblContactNo.Location = new System.Drawing.Point(22, 290);
        lblContactNo.Name = "lblContactNo";
        lblContactNo.Size = new System.Drawing.Size(82, 19);
        lblContactNo.TabIndex = 9;
        lblContactNo.Text = "Contact No.";
        // 
        // txtContactNo
        // 
        txtContactNo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        txtContactNo.Location = new System.Drawing.Point(150, 286);
        txtContactNo.MaxLength = 13;
        txtContactNo.Name = "txtContactNo";
        txtContactNo.Size = new System.Drawing.Size(340, 26);
        txtContactNo.TabIndex = 10;
        txtContactNo.KeyPress += txtContactNo_KeyPress;
        // 
        // lblAddress
        // 
        lblAddress.AutoSize = true;
        lblAddress.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        lblAddress.Location = new System.Drawing.Point(22, 346);
        lblAddress.Name = "lblAddress";
        lblAddress.Size = new System.Drawing.Size(58, 19);
        lblAddress.TabIndex = 11;
        lblAddress.Text = "Address";
        // 
        // txtAddress
        // 
        txtAddress.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        txtAddress.Location = new System.Drawing.Point(150, 342);
        txtAddress.Multiline = true;
        txtAddress.Name = "txtAddress";
        txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        txtAddress.Size = new System.Drawing.Size(340, 80);
        txtAddress.TabIndex = 12;
        // 
        // pnlAccount
        // 
        pnlAccount.BackColor = System.Drawing.Color.White;
        pnlAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        pnlAccount.Controls.Add(lblAccountTitle);
        pnlAccount.Controls.Add(lblAccountStatus);
        pnlAccount.Controls.Add(cmbStatus);
        pnlAccount.Controls.Add(lblRegistered);
        pnlAccount.Controls.Add(dtpRegistered);
        pnlAccount.Controls.Add(lblValidID);
        pnlAccount.Controls.Add(txtValidID);
        pnlAccount.Controls.Add(lblOccupation);
        pnlAccount.Controls.Add(txtOccupation);
        pnlAccount.Controls.Add(lblIncome);
        pnlAccount.Controls.Add(cmbIncome);
        pnlAccount.Controls.Add(lblNotes);
        pnlAccount.Controls.Add(txtNotes);
        pnlAccount.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlAccount.Location = new System.Drawing.Point(538, 8);
        pnlAccount.Margin = new System.Windows.Forms.Padding(8);
        pnlAccount.Name = "pnlAccount";
        pnlAccount.Size = new System.Drawing.Size(514, 464);
        pnlAccount.TabIndex = 1;
        // 
        // lblAccountTitle
        // 
        lblAccountTitle.AutoSize = true;
        lblAccountTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
        lblAccountTitle.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
        lblAccountTitle.Location = new System.Drawing.Point(22, 16);
        lblAccountTitle.Name = "lblAccountTitle";
        lblAccountTitle.Size = new System.Drawing.Size(215, 25);
        lblAccountTitle.TabIndex = 0;
        lblAccountTitle.Text = "Account && Employment";
        // 
        // lblAccountStatus
        // 
        lblAccountStatus.AutoSize = true;
        lblAccountStatus.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        lblAccountStatus.Location = new System.Drawing.Point(22, 66);
        lblAccountStatus.Name = "lblAccountStatus";
        lblAccountStatus.Size = new System.Drawing.Size(101, 19);
        lblAccountStatus.TabIndex = 1;
        lblAccountStatus.Text = "Account Status";
        // 
        // cmbStatus
        // 
        cmbStatus.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cmbStatus.FormattingEnabled = true;
        cmbStatus.Location = new System.Drawing.Point(150, 62);
        cmbStatus.Name = "cmbStatus";
        cmbStatus.Size = new System.Drawing.Size(340, 27);
        cmbStatus.TabIndex = 2;
        // 
        // lblRegistered
        // 
        lblRegistered.AutoSize = true;
        lblRegistered.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        lblRegistered.Location = new System.Drawing.Point(22, 122);
        lblRegistered.Name = "lblRegistered";
        lblRegistered.Size = new System.Drawing.Size(106, 19);
        lblRegistered.TabIndex = 3;
        lblRegistered.Text = "Date Registered";
        // 
        // dtpRegistered
        // 
        dtpRegistered.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        dtpRegistered.Enabled = false;
        dtpRegistered.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        dtpRegistered.Location = new System.Drawing.Point(150, 118);
        dtpRegistered.Name = "dtpRegistered";
        dtpRegistered.Size = new System.Drawing.Size(340, 26);
        dtpRegistered.TabIndex = 4;
        dtpRegistered.TabStop = false;
        // 
        // lblValidID
        // 
        lblValidID.AutoSize = true;
        lblValidID.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        lblValidID.Location = new System.Drawing.Point(22, 178);
        lblValidID.Name = "lblValidID";
        lblValidID.Size = new System.Drawing.Size(56, 19);
        lblValidID.TabIndex = 5;
        lblValidID.Text = "Valid ID";
        // 
        // txtValidID
        // 
        txtValidID.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        txtValidID.Location = new System.Drawing.Point(150, 174);
        txtValidID.Name = "txtValidID";
        txtValidID.Size = new System.Drawing.Size(340, 26);
        txtValidID.TabIndex = 6;
        // 
        // lblOccupation
        // 
        lblOccupation.AutoSize = true;
        lblOccupation.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        lblOccupation.Location = new System.Drawing.Point(22, 234);
        lblOccupation.Name = "lblOccupation";
        lblOccupation.Size = new System.Drawing.Size(79, 19);
        lblOccupation.TabIndex = 7;
        lblOccupation.Text = "Occupation";
        // 
        // txtOccupation
        // 
        txtOccupation.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        txtOccupation.Location = new System.Drawing.Point(150, 230);
        txtOccupation.Name = "txtOccupation";
        txtOccupation.Size = new System.Drawing.Size(340, 26);
        txtOccupation.TabIndex = 8;
        // 
        // lblIncome
        // 
        lblIncome.AutoSize = true;
        lblIncome.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        lblIncome.Location = new System.Drawing.Point(22, 290);
        lblIncome.Name = "lblIncome";
        lblIncome.Size = new System.Drawing.Size(110, 19);
        lblIncome.TabIndex = 9;
        lblIncome.Text = "Monthly Income";
        // 
        // cmbIncome
        // 
        cmbIncome.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        cmbIncome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cmbIncome.FormattingEnabled = true;
        cmbIncome.Location = new System.Drawing.Point(150, 286);
        cmbIncome.Name = "cmbIncome";
        cmbIncome.Size = new System.Drawing.Size(340, 27);
        cmbIncome.TabIndex = 10;
        // 
        // lblNotes
        // 
        lblNotes.AutoSize = true;
        lblNotes.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        lblNotes.Location = new System.Drawing.Point(22, 346);
        lblNotes.Name = "lblNotes";
        lblNotes.Size = new System.Drawing.Size(45, 19);
        lblNotes.TabIndex = 11;
        lblNotes.Text = "Notes";
        // 
        // txtNotes
        // 
        txtNotes.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        txtNotes.Location = new System.Drawing.Point(150, 342);
        txtNotes.Multiline = true;
        txtNotes.Name = "txtNotes";
        txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        txtNotes.Size = new System.Drawing.Size(340, 80);
        txtNotes.TabIndex = 12;
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
        pnlHeader.Controls.Add(btnBack);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Controls.Add(lblSubtitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Size = new System.Drawing.Size(1100, 84);
        pnlHeader.TabIndex = 1;
        // 
        // btnBack
        // 
        btnBack.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
        btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
        btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(120, 150, 190);
        btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(46, 79, 125);
        btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        btnBack.ForeColor = System.Drawing.Color.White;
        btnBack.Location = new System.Drawing.Point(24, 23);
        btnBack.Name = "btnBack";
        btnBack.Size = new System.Drawing.Size(100, 38);
        btnBack.TabIndex = 0;
        btnBack.Text = "< Back";
        btnBack.UseVisualStyleBackColor = false;
        btnBack.Click += btnBack_Click;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.White;
        lblTitle.Location = new System.Drawing.Point(144, 10);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(254, 37);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Client Information";
        // 
        // lblSubtitle
        // 
        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
        lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(190, 205, 225);
        lblSubtitle.Location = new System.Drawing.Point(147, 50);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new System.Drawing.Size(232, 19);
        lblSubtitle.TabIndex = 2;
        lblSubtitle.Text = "Register or update your client profile";
        // 
        // pnlFooter
        // 
        pnlFooter.BackColor = System.Drawing.Color.White;
        pnlFooter.Controls.Add(pnlFooterLine);
        pnlFooter.Controls.Add(lblStatus);
        pnlFooter.Controls.Add(btnAddClient);
        pnlFooter.Controls.Add(btnUpdateClient);
        pnlFooter.Controls.Add(btnClear);
        pnlFooter.Controls.Add(btnViewMap);
        pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
        pnlFooter.Location = new System.Drawing.Point(0, 668);
        pnlFooter.Name = "pnlFooter";
        pnlFooter.Size = new System.Drawing.Size(1100, 72);
        pnlFooter.TabIndex = 2;
        // 
        // pnlFooterLine
        // 
        pnlFooterLine.BackColor = System.Drawing.Color.FromArgb(220, 227, 238);
        pnlFooterLine.Dock = System.Windows.Forms.DockStyle.Top;
        pnlFooterLine.Location = new System.Drawing.Point(0, 0);
        pnlFooterLine.Name = "pnlFooterLine";
        pnlFooterLine.Size = new System.Drawing.Size(1100, 1);
        pnlFooterLine.TabIndex = 4;
        // 
        // lblStatus
        // 
        lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        lblStatus.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        lblStatus.Location = new System.Drawing.Point(24, 1);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new System.Drawing.Size(340, 71);
        lblStatus.TabIndex = 5;
        lblStatus.Text = "Status";
        lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // btnAddClient
        // 
        btnAddClient.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        btnAddClient.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
        btnAddClient.Cursor = System.Windows.Forms.Cursors.Hand;
        btnAddClient.FlatAppearance.BorderSize = 0;
        btnAddClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(29, 78, 216);
        btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnAddClient.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        btnAddClient.ForeColor = System.Drawing.Color.White;
        btnAddClient.Location = new System.Drawing.Point(936, 15);
        btnAddClient.Name = "btnAddClient";
        btnAddClient.Size = new System.Drawing.Size(140, 42);
        btnAddClient.TabIndex = 0;
        btnAddClient.Text = "Add Client";
        btnAddClient.UseVisualStyleBackColor = false;
        btnAddClient.Click += btnAddClient_Click;
        // 
        // btnUpdateClient
        // 
        btnUpdateClient.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        btnUpdateClient.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
        btnUpdateClient.Cursor = System.Windows.Forms.Cursors.Hand;
        btnUpdateClient.FlatAppearance.BorderSize = 0;
        btnUpdateClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(29, 78, 216);
        btnUpdateClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnUpdateClient.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        btnUpdateClient.ForeColor = System.Drawing.Color.White;
        btnUpdateClient.Location = new System.Drawing.Point(786, 15);
        btnUpdateClient.Name = "btnUpdateClient";
        btnUpdateClient.Size = new System.Drawing.Size(140, 42);
        btnUpdateClient.TabIndex = 1;
        btnUpdateClient.Text = "Update";
        btnUpdateClient.UseVisualStyleBackColor = false;
        btnUpdateClient.Click += btnUpdateClient_Click;
        // 
        // btnClear
        // 
        btnClear.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        btnClear.BackColor = System.Drawing.Color.White;
        btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
        btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(180, 192, 210);
        btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(238, 242, 247);
        btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        btnClear.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
        btnClear.Location = new System.Drawing.Point(636, 15);
        btnClear.Name = "btnClear";
        btnClear.Size = new System.Drawing.Size(140, 42);
        btnClear.TabIndex = 2;
        btnClear.Text = "Clear";
        btnClear.UseVisualStyleBackColor = false;
        btnClear.Click += btnClear_Click;
        // 
        // btnViewMap
        // 
        btnViewMap.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        btnViewMap.BackColor = System.Drawing.Color.White;
        btnViewMap.Cursor = System.Windows.Forms.Cursors.Hand;
        btnViewMap.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(180, 192, 210);
        btnViewMap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(238, 242, 247);
        btnViewMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnViewMap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        btnViewMap.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
        btnViewMap.Location = new System.Drawing.Point(486, 15);
        btnViewMap.Name = "btnViewMap";
        btnViewMap.Size = new System.Drawing.Size(140, 42);
        btnViewMap.TabIndex = 3;
        btnViewMap.Text = "View on Map";
        btnViewMap.UseVisualStyleBackColor = false;
        btnViewMap.Click += btnViewMap_Click;
        // 
        // frmClients
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        BackColor = System.Drawing.Color.FromArgb(243, 246, 251);
        ClientSize = new System.Drawing.Size(1100, 740);
        Controls.Add(pnlBody);
        Controls.Add(pnlHeader);
        Controls.Add(pnlFooter);
        Font = new System.Drawing.Font("Segoe UI", 10.5F);
        MinimumSize = new System.Drawing.Size(1000, 700);
        Name = "frmClients";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Clients";
        Load += frmClients_Load;
        pnlBody.ResumeLayout(false);
        tlpCards.ResumeLayout(false);
        pnlPersonal.ResumeLayout(false);
        pnlPersonal.PerformLayout();
        pnlAccount.ResumeLayout(false);
        pnlAccount.PerformLayout();
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlFooter.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlBody;
    private System.Windows.Forms.TableLayoutPanel tlpCards;
    private System.Windows.Forms.Panel pnlPersonal;
    private System.Windows.Forms.Label lblPersonalTitle;
    private System.Windows.Forms.Label lblFullName;
    private System.Windows.Forms.TextBox txtFullName;
    private System.Windows.Forms.Label lblGender;
    private System.Windows.Forms.ComboBox cmbGender;
    private System.Windows.Forms.Label lblBirthdate;
    private System.Windows.Forms.DateTimePicker dtpBirthdate;
    private System.Windows.Forms.Label lblCivilStatus;
    private System.Windows.Forms.ComboBox cmbCivilStatus;
    private System.Windows.Forms.Label lblContactNo;
    private System.Windows.Forms.TextBox txtContactNo;
    private System.Windows.Forms.Label lblAddress;
    private System.Windows.Forms.TextBox txtAddress;
    private System.Windows.Forms.Panel pnlAccount;
    private System.Windows.Forms.Label lblAccountTitle;
    private System.Windows.Forms.Label lblAccountStatus;
    private System.Windows.Forms.ComboBox cmbStatus;
    private System.Windows.Forms.Label lblRegistered;
    private System.Windows.Forms.DateTimePicker dtpRegistered;
    private System.Windows.Forms.Label lblValidID;
    private System.Windows.Forms.TextBox txtValidID;
    private System.Windows.Forms.Label lblOccupation;
    private System.Windows.Forms.TextBox txtOccupation;
    private System.Windows.Forms.Label lblIncome;
    private System.Windows.Forms.ComboBox cmbIncome;
    private System.Windows.Forms.Label lblNotes;
    private System.Windows.Forms.TextBox txtNotes;
    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Button btnBack;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblSubtitle;
    private System.Windows.Forms.Panel pnlFooter;
    private System.Windows.Forms.Panel pnlFooterLine;
    private System.Windows.Forms.Label lblStatus;
    private System.Windows.Forms.Button btnAddClient;
    private System.Windows.Forms.Button btnUpdateClient;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.Button btnViewMap;
}