using System;
using System.Collections.Generic;
using System.Text;

namespace ASCIICombinerLib.Services
{
    public class ASCIIArtCombiner : IASCIIArtCombiner
    {
        public string CombineFiles(IEnumerable<string> files)
        {
            string finalArtwork = "";
            var linesOfFiles = new List<string[]>();
            foreach(string file in files)
            {
                linesOfFiles.Add(file.Replace("\r",string.Empty).Split('\n'));
            }
            List<string> line = new List<string>();
            int currentLine = 0;
            for(int j = 0; j < linesOfFiles[0].Length; j++)
            {
                for (int i = 0; i < linesOfFiles.Count; i += 3)
                {

                    line = new List<string>();
                    line.Add(linesOfFiles[i][currentLine]);
                    line.Add(linesOfFiles[i + 1][currentLine]);
                    line.Add(linesOfFiles[i + 2][currentLine]);
                    finalArtwork += MergeLines(line);
                    currentLine++;
                }
            }
            
            
            return finalArtwork;

        }

        public string MergeLines(List<string> lines)
        {
            char[] line = new char[lines[0].Length];
            //Iterating through lines
            for (int i = 0; i < lines.Count; i++)
            {
                //Iterate through chars
                for(int j = 0; j < lines[i].Length; j++)
                {
                    char str = lines[i][j];
                    if (str != 32)
                    {
                        line[j] = lines[i][j];
                    }

                }
                char[] linystuffi = line;
            }
            string lineMerged = string.Concat(line) + "\n";
            line = new char[lines[0].Length];
            return lineMerged;
        }
    }
}
