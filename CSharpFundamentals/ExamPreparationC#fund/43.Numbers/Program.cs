using System;
using System.Collections.Generic;
using System.Linq;

namespace _43.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> values = Console.ReadLine().Split()
                                      .Select(int.Parse).ToList();

            double average = values.Average();
            List<int> output = new List<int>();
            bool isFound = false;

            values.Sort();
            values.Reverse();

            for (int i = 0; i < 5 && i<values.Count; i++)
            {
                if (values[i] > average)
                {
                    isFound = true;
                    output.Add(values[i]);
                }
            }

            if (isFound)
            {
                Console.WriteLine(string.Join(" ", output));
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
