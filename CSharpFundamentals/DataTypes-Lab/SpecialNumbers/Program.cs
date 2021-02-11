using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int digitSum = 0;

            for (int i = 1; i <= count; i++)
            {
                int digit = i % 10;
                for (int j = 1; j <= i.ToString().Length; j++)
                {
                    digitSum += digit;
                    digit = i / 10;
                }

                if (digitSum == 5 || digitSum == 7 || digitSum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
                digitSum = 0;
            }
        }
    }
}
