using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAnalyzerProject
{
	public interface IFileAnalysis
	{
		// FileInfo is a class in DotNet that carries all info about the sent file
		// file info has many properties that makes processing files easier
		void AnalyzeFile(FileInfo fileInfo);
	}
}
