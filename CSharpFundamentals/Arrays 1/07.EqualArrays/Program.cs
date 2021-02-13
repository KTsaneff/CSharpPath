using System;
using System.Linq;

namespace _07.EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrOne = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] arrTwo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            bool identArr = true;
            int arrSum = 0;
            int index = 0;

            for (int i = 0; i < arrOne.Length; i++)
            {
                if (arrOne[i] == arrTwo[i])
                {
                    arrSum += arrOne[i];
                    continue;
                }
                else
                {
                    identArr = false;
                    index = i;
                    break;
                }
            }

            if (identArr)
            {
                Console.WriteLine($"Arrays are identical. Sum: {arrSum}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
            }
        }
    }
}
