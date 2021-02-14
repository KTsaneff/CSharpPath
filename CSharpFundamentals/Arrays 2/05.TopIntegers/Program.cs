using System;
using System.Linq;

namespace _05.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();

            int topInt;
            bool isTop = true;
            string[] topArr = new string[0];

            for (int i = 0; i < arr.Length; i++)
            {
                topInt = arr[i];

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (topInt > arr[j])
                    {
                        continue;
                    }
                    else
                    {
                        isTop = false;
                        break;
                    }
                }

                if (isTop)
                {
                    Console.Write($"{topInt} ");
                }

                isTop = true;
            }
        }
    }
}
