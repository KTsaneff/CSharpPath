using System;
using System.IO;
using System.IO.Compression;

namespace _105.ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            using ZipArchive zipFile = ZipFile.Open("zipFile.zip", ZipArchiveMode.Create);
            ZipArchiveEntry zipAE = zipFile.CreateEntryFromFile("../../../output.txt", "outputEntry.txt");
        }
    }
}
