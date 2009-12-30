using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

class Details : System.Windows.Forms.Form
{
	private System.Windows.Forms.TabControl tabControl1;
	private System.Windows.Forms.TabPage tabPage1;
	private System.Windows.Forms.TabPage tabPage2;
	private System.Windows.Forms.GroupBox groupBox1;
	private System.Windows.Forms.TextBox info8;
	private System.Windows.Forms.Label label5;
	private System.Windows.Forms.TextBox info7;
	private System.Windows.Forms.Label label3;
	private System.Windows.Forms.TextBox info6;
	private System.Windows.Forms.TextBox info5;
	private System.Windows.Forms.TextBox info4;
	private System.Windows.Forms.TextBox info3;
	private System.Windows.Forms.TextBox info2;
	private System.Windows.Forms.TextBox info1;
	private System.Windows.Forms.Label label8;
	private System.Windows.Forms.Label label7;
	private System.Windows.Forms.Label label6;
	private System.Windows.Forms.Label label4;
	private System.Windows.Forms.Label label2;
	private System.Windows.Forms.Label label1;
	private System.Windows.Forms.PictureBox picviewer;
	private System.Windows.Forms.RichTextBox txtviewer;
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.Container components = null;

	public Details()
	{
		InitializeComponent();
	}

	protected override void Dispose( bool disposing )
	{
		if( disposing )
		{
			if(components != null)
			{
				components.Dispose();
			}
		}
		base.Dispose( disposing );
	}

	#region Windows Form Designer generated code
	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		this.tabControl1 = new System.Windows.Forms.TabControl();
		this.tabPage1 = new System.Windows.Forms.TabPage();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.info8 = new System.Windows.Forms.TextBox();
		this.label5 = new System.Windows.Forms.Label();
		this.info7 = new System.Windows.Forms.TextBox();
		this.label3 = new System.Windows.Forms.Label();
		this.info6 = new System.Windows.Forms.TextBox();
		this.info5 = new System.Windows.Forms.TextBox();
		this.info4 = new System.Windows.Forms.TextBox();
		this.info3 = new System.Windows.Forms.TextBox();
		this.info2 = new System.Windows.Forms.TextBox();
		this.info1 = new System.Windows.Forms.TextBox();
		this.label8 = new System.Windows.Forms.Label();
		this.label7 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.tabPage2 = new System.Windows.Forms.TabPage();
		this.picviewer = new System.Windows.Forms.PictureBox();
		this.txtviewer = new System.Windows.Forms.RichTextBox();
		this.tabControl1.SuspendLayout();
		this.tabPage1.SuspendLayout();
		this.groupBox1.SuspendLayout();
		this.tabPage2.SuspendLayout();
		this.SuspendLayout();
		// 
		// tabControl1
		// 
		this.tabControl1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.tabPage1,
																					this.tabPage2});
		this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.tabControl1.Name = "tabControl1";
		this.tabControl1.SelectedIndex = 0;
		this.tabControl1.Size = new System.Drawing.Size(362, 320);
		this.tabControl1.TabIndex = 1;
		// 
		// tabPage1
		// 
		this.tabPage1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				this.groupBox1});
		this.tabPage1.Location = new System.Drawing.Point(4, 22);
		this.tabPage1.Name = "tabPage1";
		this.tabPage1.Size = new System.Drawing.Size(354, 294);
		this.tabPage1.TabIndex = 0;
		this.tabPage1.Text = "Details";
		// 
		// groupBox1
		// 
		this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				this.info8,
																				this.label5,
																				this.info7,
																				this.label3,
																				this.info6,
																				this.info5,
																				this.info4,
																				this.info3,
																				this.info2,
																				this.info1,
																				this.label8,
																				this.label7,
																				this.label6,
																				this.label4,
																				this.label2,
																				this.label1});
		this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(354, 294);
		this.groupBox1.TabIndex = 1;
		this.groupBox1.TabStop = false;
		// 
		// info8
		// 
		this.info8.BackColor = System.Drawing.SystemColors.Control;
		this.info8.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.info8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.info8.Location = new System.Drawing.Point(120, 56);
		this.info8.Multiline = true;
		this.info8.Name = "info8";
		this.info8.ReadOnly = true;
		this.info8.Size = new System.Drawing.Size(224, 20);
		this.info8.TabIndex = 35;
		this.info8.Text = "<nothing>";
		// 
		// label5
		// 
		this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.label5.Location = new System.Drawing.Point(16, 56);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(80, 14);
		this.label5.TabIndex = 34;
		this.label5.Text = "File Type :";
		this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		// 
		// info7
		// 
		this.info7.BackColor = System.Drawing.SystemColors.Control;
		this.info7.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.info7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.info7.Location = new System.Drawing.Point(120, 152);
		this.info7.Multiline = true;
		this.info7.Name = "info7";
		this.info7.ReadOnly = true;
		this.info7.Size = new System.Drawing.Size(224, 20);
		this.info7.TabIndex = 33;
		this.info7.Text = "<nothing>";
		// 
		// label3
		// 
		this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.label3.Location = new System.Drawing.Point(16, 152);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(80, 13);
		this.label3.TabIndex = 32;
		this.label3.Text = "Attributes:";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		// 
		// info6
		// 
		this.info6.BackColor = System.Drawing.SystemColors.Control;
		this.info6.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.info6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.info6.Location = new System.Drawing.Point(120, 264);
		this.info6.Multiline = true;
		this.info6.Name = "info6";
		this.info6.ReadOnly = true;
		this.info6.Size = new System.Drawing.Size(224, 20);
		this.info6.TabIndex = 31;
		this.info6.Text = "<nothing>";
		// 
		// info5
		// 
		this.info5.BackColor = System.Drawing.SystemColors.Control;
		this.info5.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.info5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.info5.Location = new System.Drawing.Point(120, 232);
		this.info5.Multiline = true;
		this.info5.Name = "info5";
		this.info5.ReadOnly = true;
		this.info5.Size = new System.Drawing.Size(224, 20);
		this.info5.TabIndex = 30;
		this.info5.Text = "<nothing>";
		// 
		// info4
		// 
		this.info4.BackColor = System.Drawing.SystemColors.Control;
		this.info4.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.info4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.info4.Location = new System.Drawing.Point(120, 192);
		this.info4.Multiline = true;
		this.info4.Name = "info4";
		this.info4.ReadOnly = true;
		this.info4.Size = new System.Drawing.Size(224, 20);
		this.info4.TabIndex = 29;
		this.info4.Text = "<nothing>";
		// 
		// info3
		// 
		this.info3.BackColor = System.Drawing.SystemColors.Control;
		this.info3.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.info3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.info3.Location = new System.Drawing.Point(120, 120);
		this.info3.Multiline = true;
		this.info3.Name = "info3";
		this.info3.ReadOnly = true;
		this.info3.Size = new System.Drawing.Size(224, 20);
		this.info3.TabIndex = 28;
		this.info3.Text = "<nothing>";
		// 
		// info2
		// 
		this.info2.BackColor = System.Drawing.SystemColors.Control;
		this.info2.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.info2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.info2.Location = new System.Drawing.Point(120, 88);
		this.info2.Multiline = true;
		this.info2.Name = "info2";
		this.info2.ReadOnly = true;
		this.info2.Size = new System.Drawing.Size(224, 20);
		this.info2.TabIndex = 27;
		this.info2.Text = "<nothing>";
		// 
		// info1
		// 
		this.info1.BackColor = System.Drawing.SystemColors.Control;
		this.info1.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.info1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.info1.Location = new System.Drawing.Point(120, 24);
		this.info1.Multiline = true;
		this.info1.Name = "info1";
		this.info1.ReadOnly = true;
		this.info1.Size = new System.Drawing.Size(224, 20);
		this.info1.TabIndex = 26;
		this.info1.Text = "<nothing>";
		// 
		// label8
		// 
		this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.label8.Location = new System.Drawing.Point(16, 88);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(80, 10);
		this.label8.TabIndex = 25;
		this.label8.Text = "Size : ";
		this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		// 
		// label7
		// 
		this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.label7.Location = new System.Drawing.Point(16, 120);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(80, 14);
		this.label7.TabIndex = 24;
		this.label7.Text = "Folder :";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		// 
		// label6
		// 
		this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.label6.Location = new System.Drawing.Point(16, 256);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(80, 24);
		this.label6.TabIndex = 23;
		this.label6.Text = "Last Write Time:";
		this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		// 
		// label4
		// 
		this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.label4.Location = new System.Drawing.Point(16, 24);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(80, 14);
		this.label4.TabIndex = 22;
		this.label4.Text = "Full Name:";
		this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		// 
		// label2
		// 
		this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.label2.Location = new System.Drawing.Point(16, 224);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(88, 24);
		this.label2.TabIndex = 21;
		this.label2.Text = "Date /Time of Modification:";
		this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		// 
		// label1
		// 
		this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.label1.Location = new System.Drawing.Point(16, 184);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(80, 24);
		this.label1.TabIndex = 20;
		this.label1.Text = "Date / Time of Creation:";
		// 
		// tabPage2
		// 
		this.tabPage2.Controls.AddRange(new System.Windows.Forms.Control[] {
																				this.picviewer,
																				this.txtviewer});
		this.tabPage2.Location = new System.Drawing.Point(4, 22);
		this.tabPage2.Name = "tabPage2";
		this.tabPage2.Size = new System.Drawing.Size(354, 294);
		this.tabPage2.TabIndex = 1;
		this.tabPage2.Text = "View";
		// 
		// picviewer
		// 
		this.picviewer.Dock = System.Windows.Forms.DockStyle.Fill;
		this.picviewer.Name = "picviewer";
		this.picviewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.picviewer.TabIndex = 1;
		this.picviewer.TabStop = false;
		this.picviewer.Visible = false;
		// 
		// txtviewer
		// 
		this.txtviewer.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.txtviewer.Dock = System.Windows.Forms.DockStyle.Fill;
		this.txtviewer.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.txtviewer.Name = "txtviewer";
		this.txtviewer.ReadOnly = true;
		this.txtviewer.Size = new System.Drawing.Size(354, 294);
		this.txtviewer.TabIndex = 0;
		this.txtviewer.Text = "";
		this.txtviewer.Visible = false;
		// 
		// Details
		// 
		this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
		this.ClientSize = new System.Drawing.Size(362, 320);
		this.ControlBox = false;
		this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		this.tabControl1});
		this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		this.Name = "Details";
		this.Text = "dX - File System Details";
		this.Load += new System.EventHandler(this.Details_Load);
		this.tabControl1.ResumeLayout(false);
		this.tabPage1.ResumeLayout(false);
		this.groupBox1.ResumeLayout(false);
		this.tabPage2.ResumeLayout(false);
		this.ResumeLayout(false);

	}
	#endregion

	public void update(String path)
	{
		DxInfo info = new DxInfo(path);
		FileSystemInfo fs = info.FSInfo;

		info1.Text = fs.FullName;
		info2.Text = info.Size ;
		info3.Text = info.Parent;
		info4.Text = fs.CreationTime.ToString();
		info5.Text = fs.LastAccessTime.ToString();
		info6.Text = fs.LastWriteTime.ToString();
		info7.Text = fs.Attributes.ToString();
		info8.Text = info.Extension;
	}

	public void View(String path)
	{
		DxInfo info = new DxInfo(path);
		
		switch(info.Extension)
		{
			case "JPG":
			case "JPEG":
			case "GIF":
			case "BMP":
				picviewer.Visible=true;
				txtviewer.Visible=false;
				picviewer.Image = Image.FromFile(info.FullPath);
				break;
			case "EXE":
			case "DLL":
			case "SYS":
			case "JAR":
			case "TAR":
			case "ZIP":
			case "<nothing>":
				break;
			default:
				picviewer.Visible=false;
				txtviewer.Visible=true;
				txtviewer.Text = File.OpenText(info.FullPath).ReadToEnd();
				break;
		}
	}

	private void Details_Load(object sender, System.EventArgs e)
	{
	
	}
}