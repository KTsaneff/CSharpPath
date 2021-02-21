using System;

namespace _103.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] path  = Console.ReadLine().Split(@"\");

            string[] lastFile = path[path.Length - 1].Split(".");

            Console.WriteLine($"File name: {lastFile[0]}");
            Console.WriteLine($"File extension: {lastFile[1]}");
        }
    }
}
