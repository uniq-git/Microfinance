namespace MicrofinanceSystem
{
    partial class frmPayments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayments));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.picBack = new System.Windows.Forms.PictureBox();
            this.tlpBody = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.tlpForm = new System.Windows.Forms.TableLayoutPanel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblLoanID = new System.Windows.Forms.Label();
            this.cmbLoanIDs = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.dtpPaymentDate = new System.Windows.Forms.Label();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblpaymethod = new System.Windows.Forms.Label();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.btnPay = new System.Windows.Forms.Button();
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
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.picBack);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(900, 100);
            this.Panel1.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label1.Font = new System.Drawing.Font("Segoe UI Light", 36F);
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(32, 32, 32);
            this.Label1.Location = new System.Drawing.Point(100, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(800, 100);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Payment";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.tlpBody.Size = new System.Drawing.Size(900, 600);
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
            this.pnlCard.Size = new System.Drawing.Size(640, 450);
            this.pnlCard.TabIndex = 0;
            // 
            // tlpForm
            // 
            this.tlpForm.BackColor = System.Drawing.Color.Transparent;
            this.tlpForm.ColumnCount = 2;
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpForm.Controls.Add(this.lblStatus, 0, 0);
            this.tlpForm.Controls.Add(this.lblLoanID, 0, 1);
            this.tlpForm.Controls.Add(this.cmbLoanIDs, 1, 1);
            this.tlpForm.Controls.Add(this.Label2, 0, 2);
            this.tlpForm.Controls.Add(this.txtAmount, 1, 2);
            this.tlpForm.Controls.Add(this.dtpPaymentDate, 0, 3);
            this.tlpForm.Controls.Add(this.DateTimePicker1, 1, 3);
            this.tlpForm.Controls.Add(this.lblpaymethod, 0, 4);
            this.tlpForm.Controls.Add(this.cmbPaymentMethod, 1, 4);
            this.tlpForm.Controls.Add(this.btnPay, 1, 5);
            this.tlpForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpForm.Location = new System.Drawing.Point(0, 0);
            this.tlpForm.Name = "tlpForm";
            this.tlpForm.Padding = new System.Windows.Forms.Padding(28, 12, 28, 12);
            this.tlpForm.RowCount = 6;
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tlpForm.Size = new System.Drawing.Size(640, 450);
            this.tlpForm.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoEllipsis = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(0, 90, 158);
            this.lblStatus.Location = new System.Drawing.Point(31, 12);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(578, 72);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Remaining Balance: ₱0.00";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tlpForm.SetColumnSpan(this.lblStatus, 2);
            // 
            // lblLoanID
            // 
            this.lblLoanID.BackColor = System.Drawing.Color.Transparent;
            this.lblLoanID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLoanID.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblLoanID.ForeColor = System.Drawing.Color.FromArgb(32, 32, 32);
            this.lblLoanID.Location = new System.Drawing.Point(31, 84);
            this.lblLoanID.Name = "lblLoanID";
            this.lblLoanID.Size = new System.Drawing.Size(204, 64);
            this.lblLoanID.TabIndex = 1;
            this.lblLoanID.Text = "Loan ID:";
            this.lblLoanID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbLoanIDs
            // 
            this.cmbLoanIDs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLoanIDs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoanIDs.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cmbLoanIDs.FormattingEnabled = true;
            this.cmbLoanIDs.Location = new System.Drawing.Point(241, 98);
            this.cmbLoanIDs.Name = "cmbLoanIDs";
            this.cmbLoanIDs.Size = new System.Drawing.Size(368, 36);
            this.cmbLoanIDs.TabIndex = 2;
            this.cmbLoanIDs.SelectedIndexChanged += new System.EventHandler(this.cmbLoanIDs_SelectedIndexChanged);
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(32, 32, 32);
            this.Label2.Location = new System.Drawing.Point(31, 148);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(204, 64);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Enter Amount:";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtAmount.Location = new System.Drawing.Point(241, 162);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(368, 32);
            this.txtAmount.TabIndex = 4;
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpPaymentDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpPaymentDate.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.dtpPaymentDate.ForeColor = System.Drawing.Color.FromArgb(32, 32, 32);
            this.dtpPaymentDate.Location = new System.Drawing.Point(31, 212);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(204, 64);
            this.dtpPaymentDate.TabIndex = 5;
            this.dtpPaymentDate.Text = "Payment Date:";
            this.dtpPaymentDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker1.Location = new System.Drawing.Point(241, 226);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(368, 32);
            this.DateTimePicker1.TabIndex = 6;
            // 
            // lblpaymethod
            // 
            this.lblpaymethod.BackColor = System.Drawing.Color.Transparent;
            this.lblpaymethod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblpaymethod.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblpaymethod.ForeColor = System.Drawing.Color.FromArgb(32, 32, 32);
            this.lblpaymethod.Location = new System.Drawing.Point(31, 276);
            this.lblpaymethod.Name = "lblpaymethod";
            this.lblpaymethod.Size = new System.Drawing.Size(204, 64);
            this.lblpaymethod.TabIndex = 7;
            this.lblpaymethod.Text = "Payment Method:";
            this.lblpaymethod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "GCash",
            "Bank Transfer",
            "PayMaya",
            "Other"});
            this.cmbPaymentMethod.Location = new System.Drawing.Point(241, 290);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(368, 36);
            this.cmbPaymentMethod.TabIndex = 8;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(0, 80, 145);
            this.btnPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(0, 99, 177);
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(241, 352);
            this.btnPay.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(368, 60);
            this.btnPay.TabIndex = 9;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // frmPayments
            // 
            this.AcceptButton = this.btnPay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(243, 246, 250);
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.tlpBody);
            this.Controls.Add(this.Panel1);
            this.MinimumSize = new System.Drawing.Size(780, 640);
            this.Name = "frmPayments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            this.tlpBody.ResumeLayout(false);
            this.pnlCard.ResumeLayout(false);
            this.tlpForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.PictureBox picBack;
        private System.Windows.Forms.TableLayoutPanel tlpBody;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.TableLayoutPanel tlpForm;
        internal System.Windows.Forms.Label lblStatus;
        internal System.Windows.Forms.Label lblLoanID;
        internal System.Windows.Forms.ComboBox cmbLoanIDs;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtAmount;
        internal System.Windows.Forms.Label dtpPaymentDate;
        internal System.Windows.Forms.DateTimePicker DateTimePicker1;
        internal System.Windows.Forms.Label lblpaymethod;
        internal System.Windows.Forms.ComboBox cmbPaymentMethod;
        internal System.Windows.Forms.Button btnPay;
    }
}