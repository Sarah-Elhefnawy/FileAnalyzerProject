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

				// after i check the file extension i need to implement the methods of counting
				// due to encapsulations to hide these results i can't call directly to Base class "FileAnalyzer" 
				// it only return to interface which has only 2 implementations : csv, txt 
				// when you open any of these implementations it contain implementaions from Base file to set results
				// the interface doesn't have any access to the results
				fileAnalysis.AnalyzeFile(file);

				// conversion and casting to Base class FileAnalyzer to get the results
				var results = ((FileAnalyzer)fileAnalysis).GetResults();
			}

		}
	}
}
