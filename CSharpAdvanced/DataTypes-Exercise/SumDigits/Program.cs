using System;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int sum = 0;
            int limit = input.ToString().Length;

            for (int i = 0; i < limit; i++)
            {
                int operand = input % 10;
                sum += operand;
                input = input / 10;
            }

            Console.WriteLine(sum);
        }
    }
}
