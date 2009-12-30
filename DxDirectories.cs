using System;
using System.IO;
using System.Windows.Forms;

	public class DxDirectories
	{
		String path;
		public DxDirectories(String path)
		{
			this.path = path;
		}
		public void add(TreeView tree)
		{
			String[] dirs = Directory.GetDirectories(path);
			foreach(string dir in dirs)
			{
				String name = new DxInfo(dir).ToString();
				tree.SelectedNode.Nodes.Add(new TreeNode(name,1,1));
			}
		}

		public void add(ListView list)
		{
			String[] dirs = Directory.GetDirectories(path);
			Array.Sort(dirs);
			foreach(string dir in dirs)
			{
				String name = new DxInfo(dir).ToString();
				list.Items.Add(name,1);
			}
		}
	}