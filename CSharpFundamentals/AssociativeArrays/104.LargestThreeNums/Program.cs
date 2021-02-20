using System;
using System.Linq;

namespace _104.LargestThreeNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .OrderByDescending(n => n)
                .ToArray();

            int count = input.Length >= 3 ? 3 : input.Length;

            for (int i = 0; i < count; i++)
            {
                Console.Write($"{input[i]} ");
            }
        }
    }
}
