using System;
using System.Collections.Generic;
using System.Linq;

namespace _202.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lengths = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < lengths[0]; i++)
            {
                firstSet.Add(int.Parse(Console.ReadLine()));
            }

            for (int j = 0; j < lengths[1]; j++)
            {
                secondSet.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine(string.Join(" ", firstSet.Intersect(secondSet)));
        }
    }
}
