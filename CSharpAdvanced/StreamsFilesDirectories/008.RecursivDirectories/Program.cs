using System;
using System.IO;

namespace _008.RecursivDirectories
{
    class Program
    {
        static void Main(string[] args)
        {
            string folderPath = Console.ReadLine();
            Console.WriteLine(ScanFolderRecursively(folderPath, 0));
        }

        static double ScanFolderRecursively(string folderPath, int identation)
        {
            var files = Directory.GetFiles(folderPath);
            double totalSize = 0;

            foreach (var filePath in files)
            {
                FileInfo file = new FileInfo(filePath);
                Console.WriteLine($"{new string(' ', identation)}{file.FullName}");

                totalSize += file.Length;
            }

            var directories = Directory.GetDirectories(folderPath);

            foreach (var directory in directories)
            {
                totalSize += ScanFolderRecursively(directory, identation + 4);
            }
            return totalSize / 1024.0;
        }
    }

    
}
