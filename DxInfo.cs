using System;
using System.IO;

public class DxInfo
{
	public const int DRIVE = 1;
	public const int DIRECTORY = 2;
	public const int FILE = 3;
	public const int INVALID = -1;

	int type;
	String path;
	FileSystemInfo info;

	public DxInfo(String p)
	{
		path = Path.GetFullPath(p);

		if( File.Exists(path) )
		{
			type = FILE;
			info = new FileInfo(path);
		}
		else if( Directory.Exists(path) )
		{
			info = new DirectoryInfo(path);
			type = DIRECTORY;
			
			/* Check wheather it is a DRIVE */
			String[] drvs = Directory.GetLogicalDrives();
			int pos = Array.BinarySearch(drvs,path.ToUpper());
			if( pos >= 0  ) type = DRIVE;
		}
		else
			type = INVALID;
	}

	public int Type
	{
		get
		{
			return type;
		}
	}

	public String FullPath
	{
		get
		{
			return path;
		}
	}

	public FileSystemInfo FSInfo
	{
		get
		{
			return info;
		}
	}

	public String Parent
	{
		get
		{
			String p = Path.GetDirectoryName(path);
			return p == null ? "<Drive>" : p;
		}
	}

	public String Extension
	{
		get
		{
			String ext = info.Extension;
			ext = ext.Replace(".","");
			ext = ext.ToUpper();
			return ext=="" ? "<nothing>" : ext;
		}
	}

	public String Size
	{
		get
		{
			switch(type)
			{
				case FILE:
					return ((FileInfo)info).Length + " Bytes";
				case DIRECTORY:
					DirectoryInfo f = (DirectoryInfo)info;
					FileInfo[] files = f.GetFiles();
					String msg = f.GetDirectories().Length + " Folders ";
					msg += files.Length + " Files";
					return msg;
				default:
					return "<nothing>";
			}

		}
	}

	public override String ToString()
	{
		return info != null ? info.Name : null;
	}

	public void delete()
	{
		info.Delete();
	}

	public void rename(String newName)
	{
		try
		{
			switch(type)
			{
				case FILE:
					File.Move(path,Parent + "\\" + newName);
					break;
				case DIRECTORY:
					break;
			}
		}
		catch(Exception e)
		{
			System.Windows.Forms.MessageBox.Show(e.Message);
		}
		
	}

	public void copy(String dest)
	{
		try
		{
			switch(type)
			{
				case FILE:
					dest += ToString();
					File.Copy(path,dest);
					break;
				case DIRECTORY:
					if(! Directory.Exists(path) )
						Directory.CreateDirectory(dest);
					break;
			}
		}
		catch(Exception e)
		{
			System.Windows.Forms.MessageBox.Show(e.Message);
		}
	}
}
