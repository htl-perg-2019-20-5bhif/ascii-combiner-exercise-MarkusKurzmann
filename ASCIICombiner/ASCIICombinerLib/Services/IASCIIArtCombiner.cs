using System;
using System.Collections.Generic;
using System.Text;

namespace ASCIICombinerLib.Services
{
    public interface IASCIIArtCombiner
    {
        string CombineFiles(IEnumerable<string> files);
        string MergeLines(List<string> lines);
    }
}
