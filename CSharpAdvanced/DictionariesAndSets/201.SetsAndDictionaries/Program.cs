using System;
using System.Collections.Generic;

namespace _201.SetsAndDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < lines; i++)
            {
                names.Add(Console.ReadLine());
            }

            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}
