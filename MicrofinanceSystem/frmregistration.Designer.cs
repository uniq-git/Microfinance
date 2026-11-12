namespace MicrofinanceSystem
{
    partial class frmRegistration
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistration));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.registrationlbl = new System.Windows.Forms.Label();
            this.picBack = new System.Windows.Forms.PictureBox();
            this.tlpBody = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.tlpForm = new System.Windows.Forms.TableLayoutPanel();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.txtRusername = new System.Windows.Forms.TextBox();
            this.emaillabel = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.txtRpassword = new System.Windows.Forms.TextBox();
            this.confirmpasslabel = new System.Windows.Forms.Label();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            this.tlpBody.SuspendLayout();
            this.pnlCard.SuspendLayout();
            this.tlpForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Panel1.Controls.Add(this.registrationlbl);
            this.Panel1.Controls.Add(this.picBack);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(900, 100);
            this.Panel1.TabIndex = 1;
            // 
            // registrationlbl
            // 
            this.registrationlbl.BackColor = System.Drawing.Color.Transparent;
            this.registrationlbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registrationlbl.Font = new System.Drawing.Font("Segoe UI Light", 36F);
            this.registrationlbl.ForeColor = System.Drawing.Color.FromArgb(32, 32, 32);
            this.registrationlbl.Location = new System.Drawing.Point(100, 0);
            this.registrationlbl.Name = "registrationlbl";
            this.registrationlbl.Size = new System.Drawing.Size(800, 100);
            this.registrationlbl.TabIndex = 1;
            this.registrationlbl.Text = "Registration";
            this.registrationlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picBack
            // 
            this.picBack.BackColor = System.Drawing.Color.Transparent;
            this.picBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.picBack.Image = ((System.Drawing.Image)(resources.GetObject("picBack.Image")));
            this.picBack.Location = new System.Drawing.Point(0, 0);
            this.picBack.Name = "picBack";
            this.picBack.Padding = new System.Windows.Forms.Padding(16);
            this.picBack.Size = new System.Drawing.Size(100, 100);
            this.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBack.TabIndex = 0;
            this.picBack.TabStop = false;
            this.picBack.Click += new System.EventHandler(this.picBack_Click);
            // 
            // tlpBody
            // 
            this.tlpBody.AutoScroll = true;
            this.tlpBody.BackColor = System.Drawing.Color.FromArgb(243, 246, 250);
            this.tlpBody.ColumnCount = 3;
            this.tlpBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 640F));
            this.tlpBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBody.Controls.Add(this.pnlCard, 1, 0);
            this.tlpBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBody.Location = new System.Drawing.Point(0, 100);
            this.tlpBody.Name = "tlpBody";
            this.tlpBody.RowCount = 1;
            this.tlpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBody.Size = new System.Drawing.Size(900, 540);
            this.tlpBody.TabIndex = 0;
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.Controls.Add(this.tlpForm);
            this.pnlCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCard.Location = new System.Drawing.Point(130, 24);
            this.pnlCard.Margin = new System.Windows.Forms.Padding(0, 24, 0, 24);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(640, 380);
            this.pnlCard.TabIndex = 0;
            // 
            // tlpForm
            // 
            this.tlpForm.BackColor = System.Drawing.Color.Transparent;
            this.tlpForm.ColumnCount = 2;
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpForm.Controls.Add(this.usernamelabel, 0, 0);
            this.tlpForm.Controls.Add(this.txtRusername, 1, 0);
            this.tlpForm.Controls.Add(this.emaillabel, 0, 1);
            this.tlpForm.Controls.Add(this.txtEmail, 1, 1);
            this.tlpForm.Controls.Add(this.passwordlabel, 0, 2);
            this.tlpForm.Controls.Add(this.txtRpassword, 1, 2);
            this.tlpForm.Controls.Add(this.confirmpasslabel, 0, 3);
            this.tlpForm.Controls.Add(this.txtConfirmPass, 1, 3);
            this.tlpForm.Controls.Add(this.btnRegister, 1, 4);
            this.tlpForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpForm.Location = new System.Drawing.Point(0, 0);
            this.tlpForm.Name = "tlpForm";
            this.tlpForm.Padding = new System.Windows.Forms.Padding(28, 12, 28, 12);
            this.tlpForm.RowCount = 5;
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tlpForm.Size = new System.Drawing.Size(640, 380);
            this.tlpForm.TabIndex = 0;
            // 
            // usernamelabel
            // 
            this.usernamelabel.BackColor = System.Drawing.Color.Transparent;
            this.usernamelabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernamelabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.usernamelabel.ForeColor = System.Drawing.Color.FromArgb(32, 32, 32);
            this.usernamelabel.Location = new System.Drawing.Point(31, 12);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(204, 64);
            this.usernamelabel.TabIndex = 0;
            this.usernamelabel.Text = "Username:";
            this.usernamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRusername
            // 
            this.txtRusername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRusername.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtRusername.Location = new System.Drawing.Point(241, 26);
            this.txtRusername.Name = "txtRusername";
            this.txtRusername.Size = new System.Drawing.Size(368, 32);
            this.txtRusername.TabIndex = 1;
            // 
            // emaillabel
            // 
            this.emaillabel.BackColor = System.Drawing.Color.Transparent;
            this.emaillabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emaillabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.emaillabel.ForeColor = System.Drawing.Color.FromArgb(32, 32, 32);
            this.emaillabel.Location = new System.Drawing.Point(31, 76);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(204, 64);
            this.emaillabel.TabIndex = 2;
            this.emaillabel.Text = "Email:";
            this.emaillabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtEmail.Location = new System.Drawing.Point(241, 90);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(368, 32);
            this.txtEmail.TabIndex = 3;
            // 
            // passwordlabel
            // 
            this.passwordlabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordlabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordlabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.passwordlabel.ForeColor = System.Drawing.Color.FromArgb(32, 32, 32);
            this.passwordlabel.Location = new System.Drawing.Point(31, 140);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(204, 64);
            this.passwordlabel.TabIndex = 4;
            this.passwordlabel.Text = "Password:";
            this.passwordlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRpassword
            // 
            this.txtRpassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRpassword.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtRpassword.Location = new System.Drawing.Point(241, 154);
            this.txtRpassword.Name = "txtRpassword";
            this.txtRpassword.Size = new System.Drawing.Size(368, 32);
            this.txtRpassword.TabIndex = 5;
            this.txtRpassword.UseSystemPasswordChar = true;
            // 
            // confirmpasslabel
            // 
            this.confirmpasslabel.BackColor = System.Drawing.Color.Transparent;
            this.confirmpasslabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confirmpasslabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.confirmpasslabel.ForeColor = System.Drawing.Color.FromArgb(32, 32, 32);
            this.confirmpasslabel.Location = new System.Drawing.Point(31, 204);
            this.confirmpasslabel.Name = "confirmpasslabel";
            this.confirmpasslabel.Size = new System.Drawing.Size(204, 64);
            this.confirmpasslabel.TabIndex = 6;
            this.confirmpasslabel.Text = "Confirm Password:";
            this.confirmpasslabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirmPass.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtConfirmPass.Location = new System.Drawing.Point(241, 218);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(368, 32);
            this.txtConfirmPass.TabIndex = 7;
            this.txtConfirmPass.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(0, 80, 145);
            this.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(0, 99, 177);
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(241, 280);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(368, 60);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Sign up";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // frmRegistration
            // 
            this.AcceptButton = this.btnRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(243, 246, 250);
            this.ClientSize = new System.Drawing.Size(900, 640);
            this.Controls.Add(this.tlpBody);
            this.Controls.Add(this.Panel1);
            this.MinimumSize = new System.Drawing.Size(780, 600);
            this.Name = "frmRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            this.tlpBody.ResumeLayout(false);
            this.pnlCard.ResumeLayout(false);
            this.tlpForm.ResumeLayout(false);
            this.tlpForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label registrationlbl;
        internal System.Windows.Forms.PictureBox picBack;
        private System.Windows.Forms.TableLayoutPanel tlpBody;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.TableLayoutPanel tlpForm;
        internal System.Windows.Forms.Label usernamelabel;
        internal System.Windows.Forms.TextBox txtRusername;
        internal System.Windows.Forms.Label emaillabel;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.Label passwordlabel;
        internal System.Windows.Forms.TextBox txtRpassword;
        internal System.Windows.Forms.Label confirmpasslabel;
        internal System.Windows.Forms.TextBox txtConfirmPass;
        internal System.Windows.Forms.Button btnRegister;
    }
}