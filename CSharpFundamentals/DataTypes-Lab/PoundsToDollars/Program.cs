using System;

namespace PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal gbp = decimal.Parse(Console.ReadLine());

            double exchangeRate = 1.31;
            Console.WriteLine($"{gbp*(decimal)exchangeRate:f3}");
        }
    }
}
