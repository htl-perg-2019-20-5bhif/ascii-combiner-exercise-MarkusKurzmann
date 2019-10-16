using ASCIICombinerLib.Services;
using System;
using System.Collections.Generic;

namespace ASCIICombinerLib
{
    public class AsciiCombiner
    {

        public string CombineFiles(IEnumerable<string> files)
        {
            ASCIIArtCombiner aac = new ASCIIArtCombiner();
            string art = aac.CombineFiles(files);
            return art;
        }

    }
}
