using ASCIICombinerLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace ASCIICombinerCommandLine
{
    class Program
    {
        static async Task Main(string[] args)
        {

            if(args.Length < 2)
            {
                Console.Error.WriteLine("Could not find sufficient files for merging...");
                throw new FileNotFoundException();
            }

            AsciiCombiner ac = new AsciiCombiner();

            List<string> files = new List<string>();
            List<string> filesContent = new List<string>();
            for(int i = 0; i < args.Length; i++)
            {
                filesContent.Add(await readFileAsync("Data/" + args[i]));
            }

            string art = ac.CombineFiles(filesContent);

            Console.WriteLine(art);
        }

        public static async Task<string> readFileAsync(string filepath) {
            string dictionaryContent = "";
            try
            {
                // Read dict from file
                dictionaryContent = await System.IO.File.ReadAllTextAsync(filepath);
            }
            catch (FileNotFoundException ex)
            {
                //logger.LogCritical("Anagram-File not found\n"+ex);
                Console.Error.WriteLine("File \""+filepath+"\" could not be processed. Cancelling...");
                throw;
            }

            return dictionaryContent;
        }
    }
}
