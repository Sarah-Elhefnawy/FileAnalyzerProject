using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAnalyzerProject
{
	public class TextFileAnalyzer : FileAnalyzer, IFileAnalysis
	{
		// multible inheritance one class and more than one interface
		public void AnalyzeFile(FileInfo fileInfo)
		{
			// to get the file all path
			// read all text to count tham unlike csv files
			string filePath = File.ReadAllText(fileInfo.FullName);

			AnalysisResults results = new AnalysisResults();

			// Wrod Count
			var words = filePath.Split(new char[]
			{
				' ',
				'\r', // new line
				'\n', // new line
			});
			results.WordCount = words.Length;

			// Character Count
			results.CharacterCount = filePath.Length;

			// LineCount
			var lines = filePath.Split(new char[] {'\n'});
			results.LineCount = lines.Length;

			// FieldCount


			SetResults(results);
		}
	}
}
