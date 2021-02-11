using System;

namespace ExactSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int i = 1; i <= inputCount; i++)
            {
                decimal input = decimal.Parse(Console.ReadLine());
                sum += input;
            }

            Console.WriteLine(sum);
        }
    }
}
