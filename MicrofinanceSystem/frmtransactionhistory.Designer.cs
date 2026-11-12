namespace MicrofinanceSystem
{
    partial class frmTransactionHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransactionHistory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.picBack = new System.Windows.Forms.PictureBox();
            this.lblSummary = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.colPaymentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoanId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
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
            this.Panel1.TabIndex = 2;
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
            this.Label1.Text = "Transaction History";
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
            // lblSummary
            // 
            this.lblSummary.BackColor = System.Drawing.Color.Transparent;
            this.lblSummary.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSummary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSummary.ForeColor = System.Drawing.Color.FromArgb(0, 90, 158);
            this.lblSummary.Location = new System.Drawing.Point(0, 592);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Padding = new System.Windows.Forms.Padding(36, 0, 0, 0);
            this.lblSummary.Size = new System.Drawing.Size(900, 48);
            this.lblSummary.TabIndex = 1;
            this.lblSummary.Text = "No transactions yet.";
            this.lblSummary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(243, 246, 250);
            this.pnlBody.Controls.Add(this.dgvHistory);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 100);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(24, 24, 24, 0);
            this.pnlBody.Size = new System.Drawing.Size(900, 492);
            this.pnlBody.TabIndex = 0;
            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
            this.dgvHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(232, 241, 252);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(32, 32, 32);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(232, 241, 252);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(32, 32, 32);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHistory.ColumnHeadersHeight = 40;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPaymentId,
            this.colLoanId,
            this.colAmount,
            this.colMethod,
            this.colDate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(32, 32, 32);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(210, 228, 248);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(32, 32, 32);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHistory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistory.EnableHeadersVisualStyles = false;
            this.dgvHistory.GridColor = System.Drawing.Color.FromArgb(225, 232, 240);
            this.dgvHistory.Location = new System.Drawing.Point(24, 24);
            this.dgvHistory.MultiSelect = false;
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.RowHeadersVisible = false;
            this.dgvHistory.RowTemplate.Height = 32;
            this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistory.Size = new System.Drawing.Size(852, 468);
            this.dgvHistory.TabIndex = 0;
            // 
            // colPaymentId
            // 
            this.colPaymentId.FillWeight = 20F;
            this.colPaymentId.HeaderText = "Transaction #";
            this.colPaymentId.Name = "colPaymentId";
            this.colPaymentId.ReadOnly = true;
            // 
            // colLoanId
            // 
            this.colLoanId.FillWeight = 15F;
            this.colLoanId.HeaderText = "Loan ID";
            this.colLoanId.Name = "colLoanId";
            this.colLoanId.ReadOnly = true;
            // 
            // colAmount
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            this.colAmount.DefaultCellStyle = dataGridViewCellStyle4;
            this.colAmount.FillWeight = 22F;
            this.colAmount.HeaderText = "Amount (₱)";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // colMethod
            // 
            this.colMethod.FillWeight = 23F;
            this.colMethod.HeaderText = "Method";
            this.colMethod.Name = "colMethod";
            this.colMethod.ReadOnly = true;
            // 
            // colDate
            // 
            this.colDate.FillWeight = 20F;
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // frmTransactionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(243, 246, 250);
            this.ClientSize = new System.Drawing.Size(900, 640);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.Panel1);
            this.MinimumSize = new System.Drawing.Size(720, 520);
            this.Name = "frmTransactionHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction History";
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            this.pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.PictureBox picBack;
        internal System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Panel pnlBody;
        internal System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoanId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
    }
}