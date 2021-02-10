using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int multiplier = 0;

            while (multiplier == 0)
            {
                if (input % 10 == 0)
                {
                    multiplier = 10;
                    break;
                }
                if (input % 7 == 0)
                {
                    multiplier = 7;
                    break;
                }
                if (input % 6 == 0)
                {
                    multiplier = 6;
                    break;
                }
                if (input % 3 == 0)
                {
                    multiplier = 3;
                    break;
                }
                if (input % 2 == 0)
                {
                    multiplier = 2;
                    break;
                }
                break;
            }

            if (multiplier != 0)
            {
                Console.WriteLine($"The number is divisible by {multiplier}");
            }
            else
            {
                Console.WriteLine($"Not divisible");
            }
        }
    }
}
