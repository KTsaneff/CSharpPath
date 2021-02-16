using System;
using System.Linq;

namespace _302.CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] timeTable = Console.ReadLine().Split()
                                     .Select(int.Parse).ToArray();

            double timeCarLeft = 0;
            double timeCarRight = 0;

            for (int i = 0; i < timeTable.Length/2; i++)
            {
                if (timeTable[i] != 0)
                {
                    timeCarLeft += timeTable[i];
                }
                else
                {
                    timeCarLeft *= 0.8;
                }
            }
            for (int i = timeTable.Length-1; i > timeTable.Length/2; i--)
            {
                if (timeTable[i] != 0)
                {
                    timeCarRight += timeTable[i];
                }
                else
                {
                    timeCarRight *= 0.8;
                }
            }

            
            if (timeCarLeft > timeCarRight)
            {
                Console.WriteLine($"The winner is right with total time: {timeCarRight}");
            }
            else
            {
                Console.WriteLine($"The winner is left with total time: {timeCarLeft}");

            }

        }
    }
}
