namespace MicrofinanceSystem;

partial class frmForgotPassword
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
        this.pnlHeader = new System.Windows.Forms.Panel();
        this.lblTitle = new System.Windows.Forms.Label();
        this.lblSubtitle = new System.Windows.Forms.Label();
        this.lblStep1 = new System.Windows.Forms.Label();
        this.lblUsername = new System.Windows.Forms.Label();
        this.txtUsername = new System.Windows.Forms.TextBox();
        this.lblContact = new System.Windows.Forms.Label();
        this.txtContact = new System.Windows.Forms.TextBox();
        this.lblBirthdate = new System.Windows.Forms.Label();
        this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
        this.btnVerify = new System.Windows.Forms.Button();
        this.lblStatus = new System.Windows.Forms.Label();
        this.lblStep2 = new System.Windows.Forms.Label();
        this.lblNewPassword = new System.Windows.Forms.Label();
        this.txtNewPassword = new System.Windows.Forms.TextBox();
        this.lblConfirm = new System.Windows.Forms.Label();
        this.txtConfirm = new System.Windows.Forms.TextBox();
        this.chkShow = new System.Windows.Forms.CheckBox();
        this.btnReset = new System.Windows.Forms.Button();
        this.btnCancel = new System.Windows.Forms.Button();
        this.pnlHeader.SuspendLayout();
        this.SuspendLayout();
        //
        // pnlHeader
        //
        this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
        this.pnlHeader.Controls.Add(this.lblTitle);
        this.pnlHeader.Controls.Add(this.lblSubtitle);
        this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        this.pnlHeader.Location = new System.Drawing.Point(0, 0);
        this.pnlHeader.Name = "pnlHeader";
        this.pnlHeader.Size = new System.Drawing.Size(460, 76);
        this.pnlHeader.TabIndex = 0;
        //
        // lblTitle
        //
        this.lblTitle.AutoSize = true;
        this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        this.lblTitle.ForeColor = System.Drawing.Color.White;
        this.lblTitle.Location = new System.Drawing.Point(26, 8);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(186, 32);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "Reset Password";
        //
        // lblSubtitle
        //
        this.lblSubtitle.AutoSize = true;
        this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(190, 205, 225);
        this.lblSubtitle.Location = new System.Drawing.Point(28, 44);
        this.lblSubtitle.Name = "lblSubtitle";
        this.lblSubtitle.Size = new System.Drawing.Size(265, 17);
        this.lblSubtitle.TabIndex = 1;
        this.lblSubtitle.Text = "Verify your identity to set a new password.";
        //
        // lblStep1
        //
        this.lblStep1.AutoSize = true;
        this.lblStep1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        this.lblStep1.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
        this.lblStep1.Location = new System.Drawing.Point(28, 92);
        this.lblStep1.Name = "lblStep1";
        this.lblStep1.Size = new System.Drawing.Size(177, 20);
        this.lblStep1.TabIndex = 1;
        this.lblStep1.Text = "1. Verify your identity";
        //
        // lblUsername
        //
        this.lblUsername.AutoSize = true;
        this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblUsername.Location = new System.Drawing.Point(28, 124);
        this.lblUsername.Name = "lblUsername";
        this.lblUsername.Size = new System.Drawing.Size(70, 19);
        this.lblUsername.TabIndex = 2;
        this.lblUsername.Text = "Username";
        //
        // txtUsername
        //
        this.txtUsername.Location = new System.Drawing.Point(28, 144);
        this.txtUsername.MaxLength = 50;
        this.txtUsername.Name = "txtUsername";
        this.txtUsername.Size = new System.Drawing.Size(404, 25);
        this.txtUsername.TabIndex = 3;
        //
        // lblContact
        //
        this.lblContact.AutoSize = true;
        this.lblContact.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblContact.Location = new System.Drawing.Point(28, 182);
        this.lblContact.Name = "lblContact";
        this.lblContact.Size = new System.Drawing.Size(230, 19);
        this.lblContact.TabIndex = 4;
        this.lblContact.Text = "Contact number (as in your Clients profile)";
        //
        // txtContact
        //
        this.txtContact.Location = new System.Drawing.Point(28, 202);
        this.txtContact.MaxLength = 13;
        this.txtContact.Name = "txtContact";
        this.txtContact.Size = new System.Drawing.Size(404, 25);
        this.txtContact.TabIndex = 5;
        this.txtContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContact_KeyPress);
        //
        // lblBirthdate
        //
        this.lblBirthdate.AutoSize = true;
        this.lblBirthdate.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblBirthdate.Location = new System.Drawing.Point(28, 240);
        this.lblBirthdate.Name = "lblBirthdate";
        this.lblBirthdate.Size = new System.Drawing.Size(65, 19);
        this.lblBirthdate.TabIndex = 6;
        this.lblBirthdate.Text = "Birthdate";
        //
        // dtpBirthdate
        //
        this.dtpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dtpBirthdate.Location = new System.Drawing.Point(28, 260);
        this.dtpBirthdate.Name = "dtpBirthdate";
        this.dtpBirthdate.Size = new System.Drawing.Size(404, 25);
        this.dtpBirthdate.TabIndex = 7;
        //
        // btnVerify
        //
        this.btnVerify.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
        this.btnVerify.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnVerify.FlatAppearance.BorderSize = 0;
        this.btnVerify.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(29, 78, 216);
        this.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnVerify.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.btnVerify.ForeColor = System.Drawing.Color.White;
        this.btnVerify.Location = new System.Drawing.Point(28, 304);
        this.btnVerify.Name = "btnVerify";
        this.btnVerify.Size = new System.Drawing.Size(404, 40);
        this.btnVerify.TabIndex = 8;
        this.btnVerify.Text = "Verify";
        this.btnVerify.UseVisualStyleBackColor = false;
        this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
        //
        // lblStatus
        //
        this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblStatus.Location = new System.Drawing.Point(28, 350);
        this.lblStatus.Name = "lblStatus";
        this.lblStatus.Size = new System.Drawing.Size(404, 36);
        this.lblStatus.TabIndex = 9;
        this.lblStatus.Text = "Enter the details saved in your Clients profile.";
        //
        // lblStep2
        //
        this.lblStep2.AutoSize = true;
        this.lblStep2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        this.lblStep2.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
        this.lblStep2.Location = new System.Drawing.Point(28, 394);
        this.lblStep2.Name = "lblStep2";
        this.lblStep2.Size = new System.Drawing.Size(210, 20);
        this.lblStep2.TabIndex = 10;
        this.lblStep2.Text = "2. Choose a new password";
        //
        // lblNewPassword
        //
        this.lblNewPassword.AutoSize = true;
        this.lblNewPassword.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblNewPassword.Location = new System.Drawing.Point(28, 428);
        this.lblNewPassword.Name = "lblNewPassword";
        this.lblNewPassword.Size = new System.Drawing.Size(102, 19);
        this.lblNewPassword.TabIndex = 11;
        this.lblNewPassword.Text = "New password";
        //
        // txtNewPassword
        //
        this.txtNewPassword.Location = new System.Drawing.Point(28, 448);
        this.txtNewPassword.Name = "txtNewPassword";
        this.txtNewPassword.Size = new System.Drawing.Size(404, 25);
        this.txtNewPassword.TabIndex = 12;
        this.txtNewPassword.UseSystemPasswordChar = true;
        //
        // lblConfirm
        //
        this.lblConfirm.AutoSize = true;
        this.lblConfirm.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.lblConfirm.Location = new System.Drawing.Point(28, 486);
        this.lblConfirm.Name = "lblConfirm";
        this.lblConfirm.Size = new System.Drawing.Size(130, 19);
        this.lblConfirm.TabIndex = 13;
        this.lblConfirm.Text = "Confirm new password";
        //
        // txtConfirm
        //
        this.txtConfirm.Location = new System.Drawing.Point(28, 506);
        this.txtConfirm.Name = "txtConfirm";
        this.txtConfirm.Size = new System.Drawing.Size(404, 25);
        this.txtConfirm.TabIndex = 14;
        this.txtConfirm.UseSystemPasswordChar = true;
        //
        // chkShow
        //
        this.chkShow.AutoSize = true;
        this.chkShow.Cursor = System.Windows.Forms.Cursors.Hand;
        this.chkShow.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        this.chkShow.Location = new System.Drawing.Point(28, 544);
        this.chkShow.Name = "chkShow";
        this.chkShow.Size = new System.Drawing.Size(124, 23);
        this.chkShow.TabIndex = 15;
        this.chkShow.Text = "Show passwords";
        this.chkShow.UseVisualStyleBackColor = true;
        this.chkShow.CheckedChanged += new System.EventHandler(this.chkShow_CheckedChanged);
        //
        // btnReset
        //
        this.btnReset.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
        this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnReset.FlatAppearance.BorderSize = 0;
        this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(29, 78, 216);
        this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnReset.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.btnReset.ForeColor = System.Drawing.Color.White;
        this.btnReset.Location = new System.Drawing.Point(28, 580);
        this.btnReset.Name = "btnReset";
        this.btnReset.Size = new System.Drawing.Size(198, 42);
        this.btnReset.TabIndex = 16;
        this.btnReset.Text = "Reset Password";
        this.btnReset.UseVisualStyleBackColor = false;
        this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
        //
        // btnCancel
        //
        this.btnCancel.BackColor = System.Drawing.Color.White;
        this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(180, 192, 210);
        this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(238, 242, 247);
        this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
        this.btnCancel.Location = new System.Drawing.Point(234, 580);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new System.Drawing.Size(198, 42);
        this.btnCancel.TabIndex = 17;
        this.btnCancel.Text = "Cancel";
        this.btnCancel.UseVisualStyleBackColor = false;
        //
        // frmForgotPassword
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        this.BackColor = System.Drawing.Color.White;
        this.CancelButton = this.btnCancel;
        this.ClientSize = new System.Drawing.Size(460, 646);
        this.Controls.Add(this.btnCancel);
        this.Controls.Add(this.btnReset);
        this.Controls.Add(this.chkShow);
        this.Controls.Add(this.txtConfirm);
        this.Controls.Add(this.lblConfirm);
        this.Controls.Add(this.txtNewPassword);
        this.Controls.Add(this.lblNewPassword);
        this.Controls.Add(this.lblStep2);
        this.Controls.Add(this.lblStatus);
        this.Controls.Add(this.btnVerify);
        this.Controls.Add(this.dtpBirthdate);
        this.Controls.Add(this.lblBirthdate);
        this.Controls.Add(this.txtContact);
        this.Controls.Add(this.lblContact);
        this.Controls.Add(this.txtUsername);
        this.Controls.Add(this.lblUsername);
        this.Controls.Add(this.lblStep1);
        this.Controls.Add(this.pnlHeader);
        this.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "frmForgotPassword";
        this.ShowInTaskbar = false;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Forgot Password";
        this.Load += new System.EventHandler(this.frmForgotPassword_Load);
        this.pnlHeader.ResumeLayout(false);
        this.pnlHeader.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblSubtitle;
    private System.Windows.Forms.Label lblStep1;
    private System.Windows.Forms.Label lblUsername;
    private System.Windows.Forms.TextBox txtUsername;
    private System.Windows.Forms.Label lblContact;
    private System.Windows.Forms.TextBox txtContact;
    private System.Windows.Forms.Label lblBirthdate;
    private System.Windows.Forms.DateTimePicker dtpBirthdate;
    private System.Windows.Forms.Button btnVerify;
    private System.Windows.Forms.Label lblStatus;
    private System.Windows.Forms.Label lblStep2;
    private System.Windows.Forms.Label lblNewPassword;
    private System.Windows.Forms.TextBox txtNewPassword;
    private System.Windows.Forms.Label lblConfirm;
    private System.Windows.Forms.TextBox txtConfirm;
    private System.Windows.Forms.CheckBox chkShow;
    private System.Windows.Forms.Button btnReset;
    private System.Windows.Forms.Button btnCancel;
}