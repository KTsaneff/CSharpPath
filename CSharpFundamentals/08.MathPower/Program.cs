using System;

namespace _08.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            double result = (double)0;
            result = MathPowMeth(number, power);
            Console.WriteLine($"{result}");
        }

        private static double MathPowMeth(double number, double power)
        {
            double calculation = number;
            for (double i = 1; i < power; i++)
            {
                calculation *= number;
            }

            return calculation;
        }
    }
}
