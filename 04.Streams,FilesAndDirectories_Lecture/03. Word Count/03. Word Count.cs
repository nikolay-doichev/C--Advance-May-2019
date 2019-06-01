namespace _03.Word_Count
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string inputWords = File.ReadAllText("files\\words.txt");
            string[] words = inputWords.Split(new string[ ] { Environment.NewLine, " " }, StringSplitOptions.None);
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            string patern = @"\b(\w+)\b";
            Regex regex = new Regex(patern);

            using (var reader = new StreamReader("files\\text.txt"))
            {
                string currentLine = reader.ReadLine();

                while (currentLine != null)
                {
                    foreach (Match match in regex.Matches(currentLine))
                    {
                        for(int i = 0; i < words.Length; i++)
                        {

                            if (match.Value.ToLower() == words[i] && !(wordCount.ContainsKey(words[i])))
                            {
                                wordCount.Add(words[i], 1);
                            }


                            else if (match.Value.ToLower() == words[i])
                            {
                                wordCount[words[i]]++;
                            }

                        }
                    }
                    currentLine = reader.ReadLine();
                }
            }
           
            using (StreamWriter outputFile = new StreamWriter("files\\output.txt"))
            {
                foreach (var line in wordCount.OrderByDescending(x => x.Value))
                    outputFile.WriteLine($"{line.Key} - {line.Value}");
            }

        }
    }
}
