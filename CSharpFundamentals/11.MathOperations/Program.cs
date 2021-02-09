using System;

namespace _11.MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double secNum = double.Parse(Console.ReadLine());

            double result = Calculation(firstNum, operation, secNum);
            Console.WriteLine($"{result}");
        }

        private static double Calculation(double firstNum, string operation, double secNum)
        {
            double calculationResult = 0;

            if (operation == "/")
            {
                calculationResult += firstNum / secNum;
            }
            if (operation == "*")
            {
                calculationResult += firstNum * secNum;

            }
            if (operation == "+")
            {
                calculationResult += firstNum + secNum;

            }
            if (operation == "-")
            {
                calculationResult += firstNum - secNum;

            }

            return calculationResult;
        }
    }
}
