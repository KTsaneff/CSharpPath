using System;
using System.Linq;

namespace _05.SumEvenNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sumEven = 0;

            foreach (var item in arr)
            {
                if (item % 2 == 0)
                {
                    sumEven += item;
                }
            }

            Console.WriteLine(sumEven);
        }
    }
}
