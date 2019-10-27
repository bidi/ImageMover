<Query Kind="Program" />

void Main()
{
	string filePath = @"e:\source";
	string filePathDestination = @"E:\destination";

	String[] files = System.IO.Directory.GetFiles(filePath, "*", SearchOption.AllDirectories);
	
	foreach (String file in files)
	{
		FileInfo fileInfo = new FileInfo(file);

		DateTime createdDate = fileInfo.LastWriteTime;

		DirectoryInfo di = Directory.CreateDirectory(filePathDestination + "\\" + createdDate.Year + "\\" + createdDate.Month.ToString("0#") + "\\" + createdDate.Day.ToString("0#"));
		
		Console.Out.WriteLine(createdDate);

		String destination = di.FullName + "\\" + fileInfo.Name;
		
		File.Copy(file, destination);
		
	}
}