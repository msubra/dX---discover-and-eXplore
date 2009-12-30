using System;
using System.IO;
using System.Windows.Forms;

	public class DxFiles
	{
		String path;
		public DxFiles(String path)
		{
			this.path = path;
		}

		public void add(TreeView tree)
		{
			String[] files = Directory.GetFiles(path);
			
			foreach(string file in files)
			{
				String name = new DxInfo(file).ToString();
				tree.SelectedNode.Nodes.Add(new TreeNode(name,2,2));
			}
		}

		public void add(ListView list)
		{
			String[] files = Directory.GetFiles(path);
			Array.Sort(files);
			foreach(string file in files)
			{
				String name = new DxInfo(file).ToString();
				list.Items.Add(name,2);
			}
		}

	}
