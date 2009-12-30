using System;
using System.IO;
using System.Windows.Forms;

	public class DxDrives
	{
		public static void add(TreeView tree)
		{
			String[] drvs = Directory.GetLogicalDrives();
			TreeNodeCollection ns = tree.TopNode.Nodes;
			foreach(string drive in drvs)
			{
				ns.Add(new TreeNode(drive,0,0));
			}
		}

		public static void add(ListView list)
		{
			list.Clear();
			String[] drvs = Directory.GetLogicalDrives();
			Array.Sort(drvs);
			foreach(string drive in drvs)
			{
				list.Items.Add(drive,0);
			}
		}

	}