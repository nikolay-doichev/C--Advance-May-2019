namespace _04._Merge_Files
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    class MergeFiles
    {
        static void Main(string[] args)
        {
            string[] fileOne = File.ReadAllLines("files\\FileOne.txt");
            string[] fileTwo = File.ReadAllLines("files\\FileTwo.txt");
            
            List<string> result = new List<string>();
            for (int i = 0; i < fileOne.Length; i++)
            {
                result.Add(fileOne[i]);
            }

            for (int j = 0; j < fileTwo.Length; j++)
            {
                result.Add(fileTwo[j]);
            }
            using (StreamWriter outputFile = new StreamWriter("files\\Output.txt"))
            {
                foreach (var line in result.OrderBy(x => x))
                    outputFile.WriteLine(line);
            }
        }
    }
}
