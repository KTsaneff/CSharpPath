using System;
using System.Collections.Generic;
using System.Linq;

namespace _205.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                        .Split()
                                        .Select(int.Parse)
                                        .ToList();

            int[] bombProp = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToArray();

            int bomb = bombProp[0];
            int power = bombProp[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                int currNum = numbers[i];
                
                if (currNum == bomb)
                {
                    int startIndex = i - power;
                    int endIndex = i + power;

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex > numbers.Count - 1)
                    {
                        endIndex = numbers.Count - 1;
                    }

                    int endIndToRemove = endIndex - startIndex + 1;
                    numbers.RemoveRange(startIndex, endIndToRemove);

                    i = startIndex - 1;
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
