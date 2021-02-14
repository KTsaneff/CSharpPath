using System;
using System.Linq;

namespace _03.ZigZagArr
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            int[] firstArr = new int[lines];
            int[] secArr = new int[lines];

            bool fillFirstArr = true;

            for (int i = 0; i < lines; i++)
            {
                int[] midArr = Console.ReadLine()
                                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                .Select(int.Parse)
                                                .ToArray();

                if (fillFirstArr)
                {
                    firstArr[i] = midArr[0];
                    secArr[i] = midArr[1];
                    fillFirstArr = false;
                }
                else
                {
                    secArr[i] = midArr[0];
                    firstArr[i] = midArr[1];
                    fillFirstArr = true;
                }

            }

            Console.WriteLine(string.Join(" ", firstArr));
            Console.WriteLine(string.Join(" ", secArr));

        }
    }
}
