using System;
using System.Linq;

namespace _02.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] secArr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 0; i < secArr.Length; i++)
            {
                for (int j = 0; j < firstArr.Length; j++)
                {
                    if (secArr[i] == firstArr[j])
                    {
                        Console.Write($"{secArr[i]} ");
                    }
                }
            }
        }
    }
}
