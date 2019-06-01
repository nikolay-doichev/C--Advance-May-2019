namespace _06._Folder_Size
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    class FolderSize
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles("C:\\Users\\nikol\\source\\repos\\04.Streams,FilesAndDirectories_Lecture\\06. Folder Size\\TestFolder\\");

            double sum = 0;

            foreach (var file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                sum += fileInfo.Length;
            }
            sum = sum / 1024 / 1024;
            Console.WriteLine(sum);
            //File.WriteAllText("Output.txt", sum.ToString());
        }
    }
}
