using System;
using System.Collections.Generic;

namespace _203.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            SortedSet<string> elements = new SortedSet<string>();

            for (int i = 0; i < lines; i++)
            {
                var newElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < newElements.Length; j++)
                {
                    if (!elements.Contains(newElements[j]))
                    {
                        elements.Add(newElements[j]);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
