using System;
using System.IO;

namespace _001.OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader(@"..\..\..\input.txt"))
            {
                string currRow = reader.ReadLine();
                while (currRow != null)
                {

                    Console.WriteLine(currRow);
                    currRow = reader.ReadLine();
                }
            }
        }
    }
}
