using System;

namespace SpecialNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());
            int sumDigits = 0;

            for (int i = 1; i <= limit; i++)
            {
                int operand = i;
                for (int j = 0; j < i.ToString().Length; j++)
                {
                    int element = operand % 10;
                    sumDigits += element;
                    operand = operand / 10;
                }
                if (sumDigits == 5 || sumDigits == 7 || sumDigits == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
                sumDigits = 0;
            }
        }
    }
}
