namespace MicrofinanceSystem;

partial class frmlogin
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
        components = new System.ComponentModel.Container();
        tlpRoot = new System.Windows.Forms.TableLayoutPanel();
        pnlBrand = new System.Windows.Forms.Panel();
        pnlBrandInner = new System.Windows.Forms.Panel();
        lblBrandTitle = new System.Windows.Forms.Label();
        pnlBrandBar = new System.Windows.Forms.Panel();
        lblBrandTag = new System.Windows.Forms.Label();
        pnlRight = new System.Windows.Forms.Panel();
        pnlLoginBox = new System.Windows.Forms.Panel();
        lblSignIn = new System.Windows.Forms.Label();
        lblSignInSub = new System.Windows.Forms.Label();
        lblUser = new System.Windows.Forms.Label();
        txtUsername = new System.Windows.Forms.TextBox();
        lblPass = new System.Windows.Forms.Label();
        txtPassword = new System.Windows.Forms.TextBox();
        chkShowPassword = new System.Windows.Forms.CheckBox();
        lnkForgot = new System.Windows.Forms.LinkLabel();
        lblError = new System.Windows.Forms.Label();
        btnLogin = new System.Windows.Forms.Button();
        lnkRegister = new System.Windows.Forms.LinkLabel();
        errorTimer = new System.Windows.Forms.Timer(components);
        tlpRoot.SuspendLayout();
        pnlBrand.SuspendLayout();
        pnlBrandInner.SuspendLayout();
        pnlRight.SuspendLayout();
        pnlLoginBox.SuspendLayout();
        SuspendLayout();
        // 
        // tlpRoot
        // 
        tlpRoot.ColumnCount = 2;
        tlpRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
        tlpRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
        tlpRoot.Controls.Add(pnlBrand, 0, 0);
        tlpRoot.Controls.Add(pnlRight, 1, 0);
        tlpRoot.Dock = System.Windows.Forms.DockStyle.Fill;
        tlpRoot.Location = new System.Drawing.Point(0, 0);
        tlpRoot.Name = "tlpRoot";
        tlpRoot.RowCount = 1;
        tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tlpRoot.Size = new System.Drawing.Size(1000, 640);
        tlpRoot.TabIndex = 0;
        // 
        // pnlBrand
        // 
        pnlBrand.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
        pnlBrand.Controls.Add(pnlBrandInner);
        pnlBrand.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBrand.Location = new System.Drawing.Point(0, 0);
        pnlBrand.Margin = new System.Windows.Forms.Padding(0);
        pnlBrand.Name = "pnlBrand";
        pnlBrand.Size = new System.Drawing.Size(450, 640);
        pnlBrand.TabIndex = 0;
        // 
        // pnlBrandInner
        // 
        pnlBrandInner.Anchor = System.Windows.Forms.AnchorStyles.None;
        pnlBrandInner.Controls.Add(lblBrandTitle);
        pnlBrandInner.Controls.Add(pnlBrandBar);
        pnlBrandInner.Controls.Add(lblBrandTag);
        pnlBrandInner.Location = new System.Drawing.Point(45, 210);
        pnlBrandInner.Name = "pnlBrandInner";
        pnlBrandInner.Size = new System.Drawing.Size(360, 220);
        pnlBrandInner.TabIndex = 0;
        // 
        // lblBrandTitle
        // 
        lblBrandTitle.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
        lblBrandTitle.ForeColor = System.Drawing.Color.White;
        lblBrandTitle.Location = new System.Drawing.Point(0, 0);
        lblBrandTitle.Name = "lblBrandTitle";
        lblBrandTitle.Size = new System.Drawing.Size(360, 104);
        lblBrandTitle.TabIndex = 0;
        lblBrandTitle.Text = "Microfinance System";
        // 
        // pnlBrandBar
        // 
        pnlBrandBar.BackColor = System.Drawing.Color.FromArgb(96, 165, 250);
        pnlBrandBar.Location = new System.Drawing.Point(4, 116);
        pnlBrandBar.Name = "pnlBrandBar";
        pnlBrandBar.Size = new System.Drawing.Size(56, 4);
        pnlBrandBar.TabIndex = 1;
        // 
        // lblBrandTag
        // 
        lblBrandTag.Font = new System.Drawing.Font("Segoe UI", 12F);
        lblBrandTag.ForeColor = System.Drawing.Color.FromArgb(190, 205, 225);
        lblBrandTag.Location = new System.Drawing.Point(4, 136);
        lblBrandTag.Name = "lblBrandTag";
        lblBrandTag.Size = new System.Drawing.Size(340, 60);
        lblBrandTag.TabIndex = 2;
        lblBrandTag.Text = "Manage clients, loans and payments in one place.";
        // 
        // pnlRight
        // 
        pnlRight.BackColor = System.Drawing.Color.White;
        pnlRight.Controls.Add(pnlLoginBox);
        pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlRight.Location = new System.Drawing.Point(450, 0);
        pnlRight.Margin = new System.Windows.Forms.Padding(0);
        pnlRight.Name = "pnlRight";
        pnlRight.Size = new System.Drawing.Size(550, 640);
        pnlRight.TabIndex = 1;
        // 
        // pnlLoginBox
        // 
        pnlLoginBox.Anchor = System.Windows.Forms.AnchorStyles.None;
        pnlLoginBox.Controls.Add(lblSignIn);
        pnlLoginBox.Controls.Add(lblSignInSub);
        pnlLoginBox.Controls.Add(lblUser);
        pnlLoginBox.Controls.Add(txtUsername);
        pnlLoginBox.Controls.Add(lblPass);
        pnlLoginBox.Controls.Add(txtPassword);
        pnlLoginBox.Controls.Add(chkShowPassword);
        pnlLoginBox.Controls.Add(lnkForgot);
        pnlLoginBox.Controls.Add(lblError);
        pnlLoginBox.Controls.Add(btnLogin);
        pnlLoginBox.Controls.Add(lnkRegister);
        pnlLoginBox.Location = new System.Drawing.Point(85, 120);
        pnlLoginBox.Name = "pnlLoginBox";
        pnlLoginBox.Size = new System.Drawing.Size(380, 400);
        pnlLoginBox.TabIndex = 0;
        // 
        // lblSignIn
        // 
        lblSignIn.AutoSize = true;
        lblSignIn.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
        lblSignIn.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
        lblSignIn.Location = new System.Drawing.Point(-2, 0);
        lblSignIn.Name = "lblSignIn";
        lblSignIn.Size = new System.Drawing.Size(116, 41);
        lblSignIn.TabIndex = 0;
        lblSignIn.Text = "Sign in";
        // 
        // lblSignInSub
        // 
        lblSignInSub.AutoSize = true;
        lblSignInSub.Font = new System.Drawing.Font("Segoe UI", 10F);
        lblSignInSub.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        lblSignInSub.Location = new System.Drawing.Point(0, 46);
        lblSignInSub.Name = "lblSignInSub";
        lblSignInSub.Size = new System.Drawing.Size(245, 19);
        lblSignInSub.TabIndex = 1;
        lblSignInSub.Text = "Enter your account details to continue.";
        // 
        // lblUser
        // 
        lblUser.AutoSize = true;
        lblUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        lblUser.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
        lblUser.Location = new System.Drawing.Point(0, 96);
        lblUser.Name = "lblUser";
        lblUser.Size = new System.Drawing.Size(76, 19);
        lblUser.TabIndex = 2;
        lblUser.Text = "Username";
        // 
        // txtUsername
        // 
        txtUsername.Font = new System.Drawing.Font("Segoe UI", 11.5F);
        txtUsername.Location = new System.Drawing.Point(0, 118);
        txtUsername.MaxLength = 50;
        txtUsername.Name = "txtUsername";
        txtUsername.Size = new System.Drawing.Size(380, 28);
        txtUsername.TabIndex = 3;
        // 
        // lblPass
        // 
        lblPass.AutoSize = true;
        lblPass.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        lblPass.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
        lblPass.Location = new System.Drawing.Point(0, 168);
        lblPass.Name = "lblPass";
        lblPass.Size = new System.Drawing.Size(73, 19);
        lblPass.TabIndex = 4;
        lblPass.Text = "Password";
        // 
        // txtPassword
        // 
        txtPassword.Font = new System.Drawing.Font("Segoe UI", 11.5F);
        txtPassword.Location = new System.Drawing.Point(0, 190);
        txtPassword.Name = "txtPassword";
        txtPassword.Size = new System.Drawing.Size(380, 28);
        txtPassword.TabIndex = 5;
        txtPassword.UseSystemPasswordChar = true;
        // 
        // chkShowPassword
        // 
        chkShowPassword.AutoSize = true;
        chkShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
        chkShowPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        chkShowPassword.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        chkShowPassword.Location = new System.Drawing.Point(0, 230);
        chkShowPassword.Name = "chkShowPassword";
        chkShowPassword.Size = new System.Drawing.Size(119, 21);
        chkShowPassword.TabIndex = 6;
        chkShowPassword.Text = "Show password";
        chkShowPassword.UseVisualStyleBackColor = true;
        chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
        // 
        // lnkForgot
        // 
        lnkForgot.ActiveLinkColor = System.Drawing.Color.FromArgb(29, 78, 216);
        lnkForgot.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        lnkForgot.AutoSize = true;
        lnkForgot.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        lnkForgot.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
        lnkForgot.LinkColor = System.Drawing.Color.FromArgb(37, 99, 235);
        lnkForgot.Location = new System.Drawing.Point(263, 264);
        lnkForgot.Name = "lnkForgot";
        lnkForgot.Size = new System.Drawing.Size(114, 17);
        lnkForgot.TabIndex = 7;
        lnkForgot.TabStop = true;
        lnkForgot.Text = "Forgot password?";
        lnkForgot.LinkClicked += lnkForgot_LinkClicked;
        // 
        // lblError
        // 
        lblError.AutoEllipsis = true;
        lblError.Font = new System.Drawing.Font("Segoe UI", 10F);
        lblError.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
        lblError.Location = new System.Drawing.Point(0, 264);
        lblError.Name = "lblError";
        lblError.Size = new System.Drawing.Size(380, 24);
        lblError.TabIndex = 8;
        lblError.Text = "Message";
        lblError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        lblError.Visible = false;
        // 
        // btnLogin
        // 
        btnLogin.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
        btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
        btnLogin.FlatAppearance.BorderSize = 0;
        btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(29, 78, 216);
        btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        btnLogin.ForeColor = System.Drawing.Color.White;
        btnLogin.Location = new System.Drawing.Point(0, 296);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new System.Drawing.Size(380, 46);
        btnLogin.TabIndex = 9;
        btnLogin.Text = "Login";
        btnLogin.UseVisualStyleBackColor = false;
        btnLogin.Click += btnLogin_Click;
        // 
        // lnkRegister
        // 
        lnkRegister.ActiveLinkColor = System.Drawing.Color.FromArgb(29, 78, 216);
        lnkRegister.Font = new System.Drawing.Font("Segoe UI", 10F);
        lnkRegister.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
        lnkRegister.LinkArea = new System.Windows.Forms.LinkArea(23, 7);
        lnkRegister.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
        lnkRegister.LinkColor = System.Drawing.Color.FromArgb(37, 99, 235);
        lnkRegister.Location = new System.Drawing.Point(0, 360);
        lnkRegister.Name = "lnkRegister";
        lnkRegister.Size = new System.Drawing.Size(380, 26);
        lnkRegister.TabIndex = 10;
        lnkRegister.TabStop = true;
        lnkRegister.Text = "Don't have an account? Sign up";
        lnkRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        lnkRegister.UseCompatibleTextRendering = true;
        lnkRegister.LinkClicked += lnkRegister_LinkClicked;
        // 
        // errorTimer
        // 
        errorTimer.Interval = 4000;
        errorTimer.Tick += errorTimer_Tick;
        // 
        // frmlogin
        // 
        AcceptButton = btnLogin;
        AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        BackColor = System.Drawing.Color.White;
        ClientSize = new System.Drawing.Size(1000, 640);
        Controls.Add(tlpRoot);
        Font = new System.Drawing.Font("Segoe UI", 10F);
        MinimumSize = new System.Drawing.Size(900, 600);
        Name = "frmlogin";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Login";
        VisibleChanged += frmlogin_VisibleChanged;
        tlpRoot.ResumeLayout(false);
        pnlBrand.ResumeLayout(false);
        pnlBrandInner.ResumeLayout(false);
        pnlRight.ResumeLayout(false);
        pnlLoginBox.ResumeLayout(false);
        pnlLoginBox.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tlpRoot;
    private System.Windows.Forms.Panel pnlBrand;
    private System.Windows.Forms.Panel pnlBrandInner;
    private System.Windows.Forms.Label lblBrandTitle;
    private System.Windows.Forms.Panel pnlBrandBar;
    private System.Windows.Forms.Label lblBrandTag;
    private System.Windows.Forms.Panel pnlRight;
    private System.Windows.Forms.Panel pnlLoginBox;
    private System.Windows.Forms.Label lblSignIn;
    private System.Windows.Forms.Label lblSignInSub;
    private System.Windows.Forms.Label lblUser;
    internal System.Windows.Forms.TextBox txtUsername;
    private System.Windows.Forms.Label lblPass;
    internal System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.CheckBox chkShowPassword;
    private System.Windows.Forms.LinkLabel lnkForgot;
    private System.Windows.Forms.Label lblError;
    private System.Windows.Forms.Button btnLogin;
    private System.Windows.Forms.LinkLabel lnkRegister;
    private System.Windows.Forms.Timer errorTimer;
}