<Query Kind="Program" />

void Main()
{
	string filePath = @"E:\Pixel\Pictures\Raw";
	string filePathDestination = @"E:\__BACKUP__\Photos";

	String[] files = System.IO.Directory.GetFiles(filePath, "*", SearchOption.AllDirectories);
	
	foreach (String file in files)
	{
		FileInfo fileInfo = new FileInfo(file);

		DateTime createdDate = fileInfo.LastWriteTime;

		DirectoryInfo di = Directory.CreateDirectory(filePathDestination + "\\" + createdDate.Year + "\\" + createdDate.Month.ToString("0#") + "\\" + createdDate.Day.ToString("0#"));
		
		Console.Out.WriteLine(createdDate);

		String destination = di.FullName + "\\" + fileInfo.Name;
		
		try
		{
			File.Copy(file, destination, true);	
		}
		catch (Exception ex)
		{
			Console.Out.Write(ex);
		}	
	}
}