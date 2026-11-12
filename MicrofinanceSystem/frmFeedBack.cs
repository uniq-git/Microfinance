using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using MicrofinanceSystem.My;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace MicrofinanceSystem;

[DesignerGenerated]
public class frmFeedBack : Form
{
	private IContainer components;

	[CompilerGenerated]
	[AccessedThroughProperty("txtFeedback")]
	private TextBox _txtFeedback;

	[CompilerGenerated]
	[AccessedThroughProperty("btnSubmit")]
	private Button _btnSubmit;

	[CompilerGenerated]
	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[CompilerGenerated]
	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[CompilerGenerated]
	[AccessedThroughProperty("lblStatus")]
	private Label _lblStatus;

	[CompilerGenerated]
	[AccessedThroughProperty("picBack")]
	private PictureBox _picBack;

	private MySqlConnection conn;

	internal virtual TextBox txtFeedback
	{
		[CompilerGenerated]
		get
		{
			return _txtFeedback;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = txtFeedback_TextChanged;
			TextBox textBox = _txtFeedback;
			if (textBox != null)
			{
				textBox.TextChanged -= value2;
			}
			_txtFeedback = value;
			textBox = _txtFeedback;
			if (textBox != null)
			{
				textBox.TextChanged += value2;
			}
		}
	}

	internal virtual Button btnSubmit
	{
		[CompilerGenerated]
		get
		{
			return _btnSubmit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnSubmit_Click;
			Button button = _btnSubmit;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnSubmit = value;
			button = _btnSubmit;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Label Label1
	{
		[CompilerGenerated]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual Panel Panel1
	{
		[CompilerGenerated]
		get
		{
			return _Panel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_Panel1 = value;
		}
	}

	internal virtual Label lblStatus
	{
		[CompilerGenerated]
		get
		{
			return _lblStatus;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_lblStatus = value;
		}
	}

	internal virtual PictureBox picBack
	{
		[CompilerGenerated]
		get
		{
			return _picBack;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = picBack_Click;
			PictureBox pictureBox = _picBack;
			if (pictureBox != null)
			{
				pictureBox.Click -= value2;
			}
			_picBack = value;
			pictureBox = _picBack;
			if (pictureBox != null)
			{
				pictureBox.Click += value2;
			}
		}
	}

	public frmFeedBack()
	{
		conn = new MySqlConnection("server=localhost;user id=root;password=;database=microfinance_db");
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MicrofinanceSystem.frmFeedBack));
		this._txtFeedback = new System.Windows.Forms.TextBox();
		this._btnSubmit = new System.Windows.Forms.Button();
		this._Label1 = new System.Windows.Forms.Label();
		this._Panel1 = new System.Windows.Forms.Panel();
		this._picBack = new System.Windows.Forms.PictureBox();
		this._lblStatus = new System.Windows.Forms.Label();
		this._Panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this._picBack).BeginInit();
		base.SuspendLayout();
		this._txtFeedback.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
		this._txtFeedback.Location = new System.Drawing.Point(60, 114);
		this._txtFeedback.Multiline = true;
		this._txtFeedback.Name = "txtFeedback";
		this._txtFeedback.Size = new System.Drawing.Size(517, 208);
		this._txtFeedback.TabIndex = 4;
		this._btnSubmit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
		this._btnSubmit.Location = new System.Drawing.Point(363, 331);
		this._btnSubmit.Name = "btnSubmit";
		this._btnSubmit.Size = new System.Drawing.Size(214, 42);
		this._btnSubmit.TabIndex = 2;
		this._btnSubmit.Text = "Submit";
		this._btnSubmit.UseVisualStyleBackColor = false;
		this._Label1.AutoSize = true;
		this._Label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
		this._Label1.Font = new System.Drawing.Font("Segoe UI", 25f);
		this._Label1.Location = new System.Drawing.Point(237, 24);
		this._Label1.Name = "Label1";
		this._Label1.Size = new System.Drawing.Size(162, 46);
		this._Label1.TabIndex = 1;
		this._Label1.Text = "FeedBack";
		this._Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
		this._Panel1.Controls.Add(this._picBack);
		this._Panel1.Controls.Add(this._lblStatus);
		this._Panel1.Controls.Add(this._btnSubmit);
		this._Panel1.Controls.Add(this._Label1);
		this._Panel1.Location = new System.Drawing.Point(0, -3);
		this._Panel1.Name = "Panel1";
		this._Panel1.Size = new System.Drawing.Size(627, 460);
		this._Panel1.TabIndex = 5;
		this._picBack.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
		this._picBack.Anchor = System.Windows.Forms.AnchorStyles.None;
		this._picBack.BackColor = System.Drawing.Color.Transparent;
		this._picBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this._picBack.Cursor = System.Windows.Forms.Cursors.Hand;
		this._picBack.Image = (System.Drawing.Image)resources.GetObject("picBack.Image");
		this._picBack.Location = new System.Drawing.Point(0, 3);
		this._picBack.Name = "picBack";
		this._picBack.Size = new System.Drawing.Size(72, 56);
		this._picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this._picBack.TabIndex = 20;
		this._picBack.TabStop = false;
		this._lblStatus.AutoSize = true;
		this._lblStatus.Font = new System.Drawing.Font("Segoe UI", 12f);
		this._lblStatus.Location = new System.Drawing.Point(60, 331);
		this._lblStatus.Name = "lblStatus";
		this._lblStatus.Size = new System.Drawing.Size(233, 21);
		this._lblStatus.TabIndex = 3;
		this._lblStatus.Text = "Feedback submitted. Thank you!";
		this._lblStatus.Visible = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 15f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(622, 450);
		base.Controls.Add(this._txtFeedback);
		base.Controls.Add(this._Panel1);
		base.Name = "frmFeedback";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Feedback";
		this._Panel1.ResumeLayout(false);
		this._Panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this._picBack).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void btnSubmit_Click(object sender, EventArgs e)
	{
		MinimizeBox = false;
		MaximizeBox = false;
		FormBorderStyle = FormBorderStyle.FixedDialog;
		if (string.IsNullOrWhiteSpace(txtFeedback.Text))
		{
			lblStatus.Text = "⚠ Please enter your feedback.";
			lblStatus.ForeColor = Color.Red;
			return;
		}
		try
		{
			conn.Open();
			MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO feedback (user_id, message) VALUES (@uid, @msg)", conn);
			mySqlCommand.Parameters.AddWithValue("@uid", frmLoans.selectedUserId);
			mySqlCommand.Parameters.AddWithValue("@msg", txtFeedback.Text);
			mySqlCommand.ExecuteNonQuery();
			lblStatus.Visible = true;
			lblStatus.Text = "Feedback submitted. Thank you!";
			lblStatus.ForeColor = Color.Green;
			txtFeedback.Clear();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show("❌ Error submitting feedback: " + ex2.Message);
			ProjectData.ClearProjectError();
		}
		finally
		{
			conn.Close();
		}
	}

	private void picBack_Click(object sender, EventArgs e)
	{
		MyProject.Forms.frmDashboard.Show();
		Hide();
	}

	private void txtFeedback_TextChanged(object sender, EventArgs e)
	{
	}
}
