namespace FileAnalyzerProject
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to File Analyzer!");
			Console.WriteLine("Please enter folder path to analyze");
			string inputFolder = Console.ReadLine();

			// helps processing folders like FileInfo
			DirectoryInfo directoryInfo = new DirectoryInfo(inputFolder);

			if (!directoryInfo.Exists)
			{
				Console.WriteLine("Folder does not Exists!!!");
				return;
			}

			IFileAnalysis fileAnalysis = null;

			// gets all files inside folder
			var filenames = directoryInfo.GetFiles();

			foreach ( var file in filenames )
			{
				if (file.IsTextFile())
				{
					fileAnalysis = new TextFileAnalyzer();
				}

				fileAnalysis.AnalyzeFile(file);
			}

		}
	}
}
