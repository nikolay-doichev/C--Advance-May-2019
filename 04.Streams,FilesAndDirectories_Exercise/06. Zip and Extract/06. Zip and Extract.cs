namespace _06._Zip_and_Extract
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.IO.Compression;
    using System.Linq;
    class ZipAndExtract
    {
        static void Main(string[] args)
        {
            var zipFile = @"..\..\..\myNewzip.zip";
            var file = "copyMe.png";

            using (var archive = ZipFile.Open(zipFile, ZipArchiveMode.Create))
            {
                archive.CreateEntryFromFile(file, Path.GetFileName(file));
                
            }
        }
    }
}
