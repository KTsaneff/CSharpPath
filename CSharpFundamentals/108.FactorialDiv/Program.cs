using System;

namespace _108.FactorialDiv
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            double firstNumF = FactorialOfNumber(firstNum);
            double secondNumF = FactorialOfNumber(secondNum);

            double fDivision = firstNumF / secondNumF;
            Console.WriteLine($"{fDivision:f2}");
        }

        private static double FactorialOfNumber(int input)
        {
            double factorial = 1;

            for (int i = 1; i <= input; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
