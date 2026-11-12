using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using MicrofinanceSystem.My;
using Microsoft.VisualBasic.CompilerServices;

namespace MicrofinanceSystem;

[DesignerGenerated]
public class frmCredits : Form
{
	private IContainer components;

	[CompilerGenerated]
	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[CompilerGenerated]
	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[CompilerGenerated]
	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[CompilerGenerated]
	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[CompilerGenerated]
	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[CompilerGenerated]
	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[CompilerGenerated]
	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[CompilerGenerated]
	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[CompilerGenerated]
	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[CompilerGenerated]
	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[CompilerGenerated]
	[AccessedThroughProperty("picBack")]
	private PictureBox _picBack;

	[CompilerGenerated]
	[AccessedThroughProperty("Label11")]
	private Label _Label11;

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

	internal virtual Label Label2
	{
		[CompilerGenerated]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual Label Label3
	{
		[CompilerGenerated]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_Label3 = value;
		}
	}

	internal virtual Label Label4
	{
		[CompilerGenerated]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_Label4 = value;
		}
	}

	internal virtual Label Label5
	{
		[CompilerGenerated]
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_Label5 = value;
		}
	}

	internal virtual Label Label6
	{
		[CompilerGenerated]
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_Label6 = value;
		}
	}

	internal virtual Label Label7
	{
		[CompilerGenerated]
		get
		{
			return _Label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_Label7 = value;
		}
	}

	internal virtual Label Label8
	{
		[CompilerGenerated]
		get
		{
			return _Label8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_Label8 = value;
		}
	}

	internal virtual Label Label9
	{
		[CompilerGenerated]
		get
		{
			return _Label9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_Label9 = value;
		}
	}

	internal virtual Label Label10
	{
		[CompilerGenerated]
		get
		{
			return _Label10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_Label10 = value;
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

	internal virtual Label Label11
	{
		[CompilerGenerated]
		get
		{
			return _Label11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_Label11 = value;
		}
	}

	public frmCredits()
	{
		Load += Credits_Load;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MicrofinanceSystem.frmCredits));
		this._Label1 = new System.Windows.Forms.Label();
		this._Label2 = new System.Windows.Forms.Label();
		this._Label3 = new System.Windows.Forms.Label();
		this._Label4 = new System.Windows.Forms.Label();
		this._Label5 = new System.Windows.Forms.Label();
		this._Label6 = new System.Windows.Forms.Label();
		this._Label7 = new System.Windows.Forms.Label();
		this._Label8 = new System.Windows.Forms.Label();
		this._Label9 = new System.Windows.Forms.Label();
		this._Label10 = new System.Windows.Forms.Label();
		this._picBack = new System.Windows.Forms.PictureBox();
		this._Label11 = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)this._picBack).BeginInit();
		base.SuspendLayout();
		this._Label1.AutoSize = true;
		this._Label1.Font = new System.Drawing.Font("Segoe UI", 39.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this._Label1.Location = new System.Drawing.Point(291, 42);
		this._Label1.Name = "Label1";
		this._Label1.Size = new System.Drawing.Size(205, 71);
		this._Label1.TabIndex = 0;
		this._Label1.Text = "Credits";
		this._Label2.AutoSize = true;
		this._Label2.Font = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
		this._Label2.Location = new System.Drawing.Point(347, 131);
		this._Label2.Name = "Label2";
		this._Label2.Size = new System.Drawing.Size(89, 21);
		this._Label2.TabIndex = 1;
		this._Label2.Text = "Developer";
		this._Label3.AutoSize = true;
		this._Label3.Font = new System.Drawing.Font("Segoe UI", 13f, System.Drawing.FontStyle.Bold);
		this._Label3.Location = new System.Drawing.Point(313, 163);
		this._Label3.Name = "Label3";
		this._Label3.Size = new System.Drawing.Size(162, 25);
		this._Label3.TabIndex = 2;
		this._Label3.Text = "Suaiso, Johnric G.";
		this._Label4.AutoSize = true;
		this._Label4.Font = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
		this._Label4.Location = new System.Drawing.Point(341, 220);
		this._Label4.Name = "Label4";
		this._Label4.Size = new System.Drawing.Size(106, 21);
		this._Label4.TabIndex = 3;
		this._Label4.Text = "Contributors";
		this._Label5.AutoSize = true;
		this._Label5.Font = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Bold);
		this._Label5.Location = new System.Drawing.Point(325, 258);
		this._Label5.Name = "Label5";
		this._Label5.Size = new System.Drawing.Size(139, 21);
		this._Label5.TabIndex = 4;
		this._Label5.Text = "Abdul Kaharudin";
		this._Label6.AutoSize = true;
		this._Label6.Font = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Bold);
		this._Label6.Location = new System.Drawing.Point(291, 279);
		this._Label6.Name = "Label6";
		this._Label6.Size = new System.Drawing.Size(220, 21);
		this._Label6.TabIndex = 5;
		this._Label6.Text = "Angelica Salvador Maranan";
		this._Label7.AutoSize = true;
		this._Label7.Font = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Bold);
		this._Label7.Location = new System.Drawing.Point(325, 300);
		this._Label7.Name = "Label7";
		this._Label7.Size = new System.Drawing.Size(132, 21);
		this._Label7.TabIndex = 6;
		this._Label7.Text = "Dicson Delantar";
		this._Label8.AutoSize = true;
		this._Label8.Font = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Bold);
		this._Label8.Location = new System.Drawing.Point(341, 321);
		this._Label8.Name = "Label8";
		this._Label8.Size = new System.Drawing.Size(111, 21);
		this._Label8.TabIndex = 7;
		this._Label8.Text = "Hanah Alcala";
		this._Label9.AutoSize = true;
		this._Label9.Font = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Bold);
		this._Label9.Location = new System.Drawing.Point(291, 342);
		this._Label9.Name = "Label9";
		this._Label9.Size = new System.Drawing.Size(207, 21);
		this._Label9.TabIndex = 8;
		this._Label9.Text = "Jerson Ian Delarosa Flores";
		this._Label10.AutoSize = true;
		this._Label10.Font = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Bold);
		this._Label10.Location = new System.Drawing.Point(341, 363);
		this._Label10.Name = "Label10";
		this._Label10.Size = new System.Drawing.Size(101, 21);
		this._Label10.TabIndex = 9;
		this._Label10.Text = "Jervy Oldan";
		this._picBack.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
		this._picBack.Anchor = System.Windows.Forms.AnchorStyles.None;
		this._picBack.BackColor = System.Drawing.Color.Transparent;
		this._picBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this._picBack.Cursor = System.Windows.Forms.Cursors.Hand;
		this._picBack.Image = (System.Drawing.Image)resources.GetObject("picBack.Image");
		this._picBack.Location = new System.Drawing.Point(0, 0);
		this._picBack.Name = "picBack";
		this._picBack.Size = new System.Drawing.Size(107, 76);
		this._picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this._picBack.TabIndex = 17;
		this._picBack.TabStop = false;
		this._Label11.AutoSize = true;
		this._Label11.Font = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Bold);
		this._Label11.Location = new System.Drawing.Point(341, 384);
		this._Label11.Name = "Label11";
		this._Label11.Size = new System.Drawing.Size(85, 21);
		this._Label11.TabIndex = 18;
		this._Label11.Text = "Chris Tine";
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 15f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(800, 450);
		base.Controls.Add(this._Label11);
		base.Controls.Add(this._picBack);
		base.Controls.Add(this._Label10);
		base.Controls.Add(this._Label9);
		base.Controls.Add(this._Label8);
		base.Controls.Add(this._Label7);
		base.Controls.Add(this._Label6);
		base.Controls.Add(this._Label5);
		base.Controls.Add(this._Label4);
		base.Controls.Add(this._Label3);
		base.Controls.Add(this._Label2);
		base.Controls.Add(this._Label1);
		base.Name = "frmCredits";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Form1";
		((System.ComponentModel.ISupportInitialize)this._picBack).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void Credits_Load(object sender, EventArgs e)
	{
	}

	private void picBack_Click(object sender, EventArgs e)
	{
		MyProject.Forms.frmDashboard.Show();
		Hide();
	}
}
