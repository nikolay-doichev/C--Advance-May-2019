namespace _04._Copy_Binary_File
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    class CopyBinaryFile
    {
        static void Main(string[] args)
        {
            string picPath = "copyMe.png";
            string picCopyPath = "copyMe-copy.png";

            using (FileStream stremReader = new FileStream(picPath, FileMode.Open))
            {    
                using (FileStream streamWriter = new FileStream(picCopyPath,FileMode.Create ))
                {
                    while (true)
                    {
                        byte[] byteArray = new byte[4096];
                        int size = stremReader.Read(byteArray, 0, byteArray.Length);
                        if (size == 0)
                        {
                            break;
                        }
                        streamWriter.Write(byteArray, 0, size);
                    }
                }
            }
        }
    }
}
