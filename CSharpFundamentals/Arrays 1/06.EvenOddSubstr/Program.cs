using System;
using System.Linq;

namespace _06.EvenOddSubstr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

            int sumOdd = 0;
            int sumEven = 0;

            foreach (var item in arr)
            {
                if (item % 2 == 0)
                {
                    sumEven += item;
                }
                else
                {
                    sumOdd += item;
                }
            }

            Console.WriteLine(sumEven - sumOdd);
        }
    }
}
