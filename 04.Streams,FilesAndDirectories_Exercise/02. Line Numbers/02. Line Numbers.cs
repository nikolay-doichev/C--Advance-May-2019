namespace _02._Line_Numbers
{
    using System;
    using System.IO;
    using System.Linq;
    class LineNumbering
    {
        static void Main(string[] args)
        {
            string textPath = @"text.txt";
            string outputPath = @"output.txt";

            string[] textLines = File.ReadAllLines(textPath);

            int lineCounter = 1;

            foreach (var currentLine in textLines)
            {
                //Line 1: -I was quick to judge him, but it wasn't his fault. (37)(4)
                int lettersCount = currentLine.Count(char.IsLetter);
                int puncsCount = currentLine.Count(char.IsPunctuation);
                File.AppendAllText(outputPath, $"Line {lineCounter}:{currentLine} ({lettersCount})({puncsCount}){Environment.NewLine}");
                lineCounter++;
            }
        }
    }
}
