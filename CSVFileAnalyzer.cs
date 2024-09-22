using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAnalyzerProject
{
	public class CSVFileAnalyzer : FileAnalyzer, IFileAnalysis
	{
		// multible inheritance one class and more than one interface
		public void AnalyzeFile(FileInfo fileInfo)
		{
			// csv files consists of rows and columns
			// to get the file all path
			// read all lines(line by line) to get all rows in a shape of array of strings unlike text files
			string[] filePath = File.ReadAllLines(fileInfo.FullName);

			// trying to get to the first element then split by commas[comma delimited]
			var rowElements = filePath[0].Split(',');

			AnalysisResults results = new AnalysisResults();

			results.FieldCount = rowElements.Length;

			SetResults(results);

		}
	}
}
