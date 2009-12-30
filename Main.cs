using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

class DxMain : Form
{
	private ImageList imageList1;
	private ListView listView1;
	private TreeView treeView1;
	private Splitter splitter1;
	private MainMenu mainMenu1;
	private MenuItem menuItem1,menuItem3,menuItem4,menuItem8,menuItem9;
	private MenuItem menuItem10,menuItem11,menuItem13,menuItem12,menuItem5;
	private ImageList imageList2;
	private IContainer components;

	String selectedPath = "", selectedPathTree = "";
	public Details details = new Details();
	String title = "dX - Discover and Explore @ " ;
	ArrayList paths ;
	private StatusBar status;
	private System.Windows.Forms.Timer timer1;
	bool canDeleteFlag = false, flag = false;

	public DxMain()
	{
		InitializeComponent();
		Splash sp = new Splash();
		sp.Show();

		timer1.Interval = 2000;
		timer1.Start();
		while(flag == false)
		{
			Application.DoEvents();
		}
		sp.Close();
		details.Show();
	}

	protected override void Dispose( bool disposing )
	{
		if( disposing )
		{
			if (components != null) 
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
		this.components = new System.ComponentModel.Container();
		System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(DxMain));
		this.imageList1 = new System.Windows.Forms.ImageList(this.components);
		this.listView1 = new System.Windows.Forms.ListView();
		this.imageList2 = new System.Windows.Forms.ImageList(this.components);
		this.treeView1 = new System.Windows.Forms.TreeView();
		this.splitter1 = new System.Windows.Forms.Splitter();
		this.mainMenu1 = new System.Windows.Forms.MainMenu();
		this.menuItem1 = new System.Windows.Forms.MenuItem();
		this.menuItem3 = new System.Windows.Forms.MenuItem();
		this.menuItem9 = new System.Windows.Forms.MenuItem();
		this.menuItem10 = new System.Windows.Forms.MenuItem();
		this.menuItem11 = new System.Windows.Forms.MenuItem();
		this.menuItem13 = new System.Windows.Forms.MenuItem();
		this.menuItem5 = new System.Windows.Forms.MenuItem();
		this.menuItem12 = new System.Windows.Forms.MenuItem();
		this.menuItem4 = new System.Windows.Forms.MenuItem();
		this.menuItem8 = new System.Windows.Forms.MenuItem();
		this.status = new System.Windows.Forms.StatusBar();
		this.timer1 = new System.Windows.Forms.Timer(this.components);
		this.SuspendLayout();
		// 
		// imageList1
		// 
		this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
		this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
		this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
		this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
		// 
		// listView1
		// 
		this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.listView1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
		this.listView1.FullRowSelect = true;
		this.listView1.LabelEdit = true;
		this.listView1.LargeImageList = this.imageList2;
		this.listView1.Location = new System.Drawing.Point(216, 0);
		this.listView1.Name = "listView1";
		this.listView1.Size = new System.Drawing.Size(352, 324);
		this.listView1.TabIndex = 5;
		this.listView1.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listView1_AfterLabelEdit);
		this.listView1.BeforeLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listView1_BeforeLabelEdit);
		this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
		// 
		// imageList2
		// 
		this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
		this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
		this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
		this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
		// 
		// treeView1
		// 
		this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
		this.treeView1.FullRowSelect = true;
		this.treeView1.ImageList = this.imageList1;
		this.treeView1.Name = "treeView1";
		this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
																				new System.Windows.Forms.TreeNode("System")});
		this.treeView1.ShowPlusMinus = false;
		this.treeView1.ShowRootLines = false;
		this.treeView1.Size = new System.Drawing.Size(216, 324);
		this.treeView1.TabIndex = 4;
		this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
		// 
		// splitter1
		// 
		this.splitter1.Location = new System.Drawing.Point(216, 0);
		this.splitter1.Name = "splitter1";
		this.splitter1.Size = new System.Drawing.Size(3, 324);
		this.splitter1.TabIndex = 6;
		this.splitter1.TabStop = false;
		// 
		// mainMenu1
		// 
		this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					this.menuItem1,
																					this.menuItem9,
																					this.menuItem4});
		// 
		// menuItem1
		// 
		this.menuItem1.Index = 0;
		this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					this.menuItem3});
		this.menuItem1.Text = "Explorer";
		// 
		// menuItem3
		// 
		this.menuItem3.Index = 0;
		this.menuItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
		this.menuItem3.Text = "Close";
		this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
		// 
		// menuItem9
		// 
		this.menuItem9.Index = 1;
		this.menuItem9.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					this.menuItem10,
																					this.menuItem11,
																					this.menuItem13,
																					this.menuItem5,
																					this.menuItem12});
		this.menuItem9.Text = "Edit";
		// 
		// menuItem10
		// 
		this.menuItem10.Index = 0;
		this.menuItem10.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
		this.menuItem10.Text = "Copy";
		this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
		// 
		// menuItem11
		// 
		this.menuItem11.Index = 1;
		this.menuItem11.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
		this.menuItem11.Text = "Paste";
		this.menuItem11.Click += new System.EventHandler(this.menuItem11_Click);
		// 
		// menuItem13
		// 
		this.menuItem13.Index = 2;
		this.menuItem13.Shortcut = System.Windows.Forms.Shortcut.CtrlR;
		this.menuItem13.Text = "Rename";
		// 
		// menuItem5
		// 
		this.menuItem5.Index = 3;
		this.menuItem5.Shortcut = System.Windows.Forms.Shortcut.Del;
		this.menuItem5.Text = "Delete";
		this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
		// 
		// menuItem12
		// 
		this.menuItem12.Index = 4;
		this.menuItem12.Shortcut = System.Windows.Forms.Shortcut.CtrlD;
		this.menuItem12.Text = "Find";
		this.menuItem12.Click += new System.EventHandler(this.menuItem12_Click);
		// 
		// menuItem4
		// 
		this.menuItem4.Index = 2;
		this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					this.menuItem8});
		this.menuItem4.Text = "Help";
		// 
		// menuItem8
		// 
		this.menuItem8.Index = 0;
		this.menuItem8.Text = "About";
		this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
		// 
		// status
		// 
		this.status.Location = new System.Drawing.Point(219, 302);
		this.status.Name = "status";
		this.status.Size = new System.Drawing.Size(349, 22);
		this.status.TabIndex = 7;
		// 
		// timer1
		// 
		this.timer1.Tick += new System.EventHandler(TimerEventProcessor);
		// 
		// Form1
		// 
		this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
		this.ClientSize = new System.Drawing.Size(568, 324);
		this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		this.status,
																		this.splitter1,
																		this.listView1,
																		this.treeView1});
		this.Menu = this.mainMenu1;
		this.Name = "Form1";
		this.Text = "dX - Discover and Explore";
		this.Load += new System.EventHandler(this.Form1_Load);
		this.ResumeLayout(false);

	}
	#endregion

	static void Main()
	{
		DxMain f1 = new DxMain();
		Application.Run(f1);
	}

	private void Form1_Load(object sender, System.EventArgs e)
	{
		DxDrives.add(treeView1);
		DxDrives.add(listView1);
	}

	private void changeDir(String node)
	{
		canDeleteFlag = false;
		listView1.Clear();
		
		if(node == "System")
		{
			DxDrives.add(treeView1);
			DxDrives.add(listView1);
			return;
		}
		String path = node;
		String path1 = path;
		path = path.Replace("System\\","");
		
		DxDirectories d = new DxDirectories(path);
		d.add(treeView1);
		d.add(listView1);

		/* ADD files only in the list view */
		DxFiles f = new DxFiles(path);
		f.add(listView1);

		this.Text = title + path;
		this.selectedPath = path;
		this.selectedPathTree = path;
		canDeleteFlag = true;
	}

	private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
	{
		try
		{
				e.Node.Nodes.Clear();
				changeDir(e.Node.FullPath);
				e.Node.Expand();
				listView1.ArrangeIcons(ListViewAlignment.Default);

			if( selectedPath != "" )
			{
				details.update(selectedPath);
				
			}
		}
		catch(Exception ex)
		{
			MessageBox.Show(ex.Message,"dX - Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
		}
	}

	private void menuItem3_Click(object sender, System.EventArgs e)
	{
		this.Close();
	}

	private void listView1_SelectedIndexChanged(object sender, System.EventArgs e)
	{
		if(listView1.SelectedItems.Count > 0 )
		{
			ListViewItem item = listView1.SelectedItems[0];
			String path = treeView1.SelectedNode.FullPath + "\\" + item.Text;
			path = path.Replace("System\\","");
			this.selectedPath = path;
			details.update(path);
			details.View(path);
			this.Text = title + path;
		}
	}

	private void menuItem10_Click(object sender, System.EventArgs e)
	{
		if( new DxInfo(selectedPath).Type == DxInfo.DRIVE ) return;

		
		paths = new ArrayList();
		for(int i = 0; i < listView1.SelectedItems.Count; i++)
		{
			ListViewItem item = listView1.SelectedItems[i];
			paths.Add(selectedPathTree + "\\" + item.Text);
		}
		status.Text = "Selected Files Copied. Press Ctrl+V to Paste";
	}

	private void menuItem11_Click(object sender, System.EventArgs e)
	{
		foreach(string s in paths)
		{
			DxInfo info = new DxInfo(s);
			info.copy(selectedPath);
		}
		refresh();
	}

	private void refresh()
	{
		treeView1.SelectedNode.Nodes.Clear();
		changeDir(selectedPathTree);
		
	}

	private void menuItem5_Click(object sender, System.EventArgs e)
	{
		if( ! canDeleteFlag ) return;
		canDeleteFlag = false;
		paths = new ArrayList();
		for(int i = 0; i < listView1.SelectedItems.Count; i++)
		{
			ListViewItem item = listView1.SelectedItems[i];
			paths.Add(selectedPathTree + "\\" + item.Text);
		}

		DialogResult res = MessageBox.Show("Are you sure want to delete?","Confirm",MessageBoxButtons.YesNo);
		
		if( res == DialogResult.Yes)
		{
			foreach(string s in paths)
			{
				new DxInfo(s).delete();
			}
			refresh();
		}
	}

	private void listView1_AfterLabelEdit(object sender, LabelEditEventArgs e)
	{
		canDeleteFlag = false;
		new DxInfo(selectedPath).rename(e.Label);
		canDeleteFlag = true;
	}

	private void listView1_BeforeLabelEdit(object sender, LabelEditEventArgs e)
	{
		canDeleteFlag = false;
	}

	private void menuItem12_Click(object sender, System.EventArgs e)
	{
		MessageBox.Show("Still in implementation");
	}

	private void menuItem8_Click(object sender, System.EventArgs e)
	{
		MessageBox.Show("dX - discover and eXlpore \n By Maheshwaran.S");
	}

	private void TimerEventProcessor(Object myObject,EventArgs myEventArgs)
	{
		timer1.Stop();
		this.Close();
		flag = true;
	}
}
