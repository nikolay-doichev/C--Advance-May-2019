using System;
using System.IO;
using System.Linq;

namespace _04.Streams_FilesAndDirectories_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string textFilePath = @"../../../text.txt";
            string outputFilePath = "result.txt";
            int counter = 0;

            using (StreamWriter writer = new StreamWriter(outputFilePath) )
            {
                using (StreamReader streamReader = new StreamReader(textFilePath))
                {
                    string currentLine = streamReader.ReadLine();
                    while (currentLine != null)
                    {

                        if (counter % 2 == 0)
                        {
                            string replaceSymbols = ReplaceSpecialCharacters(currentLine);
                            string reversedWords = ReplaceWords(replaceSymbols);

                            writer.WriteLine(reversedWords);
                        }
                        currentLine = streamReader.ReadLine();

                        counter++;
                    }

                }
            }

        }


        private static string ReplaceWords(string replaceSymbols)
        {
            //-I was quick to judge him, but it wasn't his fault.
            return string.Join(" ", replaceSymbols.Split().Reverse());
        }

        private static string ReplaceSpecialCharacters(string currentLine)
        {           
            return currentLine.Replace("-", "@")
                .Replace(",", "@")
                .Replace(".", "@")
                .Replace("!", "@")
                .Replace("?", "@");
        }
    }
}
