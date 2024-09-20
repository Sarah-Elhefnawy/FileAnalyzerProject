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
		void AnalyzeFile(FileInfo fileInfo);
	}
}
