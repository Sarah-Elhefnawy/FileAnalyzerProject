using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAnalyzerProject
{
	public class FileAnalyzer
	{
		//Base class


		private AnalysisResults _results;

		// Encapsulation
		public AnalysisResults GetResults() { return _results; }
		public void SetResults(AnalysisResults results) 
		{
			// Checking or validation
			_results = results; 
		}
	}
}
