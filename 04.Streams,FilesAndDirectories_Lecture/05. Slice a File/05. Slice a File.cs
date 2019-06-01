namespace _05._Slice_a_File
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    class SliceAFile
    {
        static void Main(string[] args)
        {
            using (var inputFile = new FileStream("files\\input.txt",FileMode.Open))
            {
                long size = inputFile.Length;
                int partSize = (int)Math.Ceiling((double)size / 4);
                byte[] buffer = new byte[partSize];

                for (int i = 1; i < 5; i++)
                {
                    using (var outputFile = new FileStream($"files\\Part-{i}.txt",FileMode.Create))
                    {
                        int readedBytes = inputFile.Read(buffer, 0, partSize);
                        outputFile.Write(buffer, 0, readedBytes);
                    }
                }
            }
        }
    }
}
