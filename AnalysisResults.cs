using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAnalyzerProject
{
	public struct AnalysisResults
	{
		// a struct not class cuz it has no logic just carry numbers
		// as struct is a value type like air unlike classes that carries methods

		public int WordCount;
		public int CharacterCount;
		public int LineCount;
		public int FieldCount;
	}
}
