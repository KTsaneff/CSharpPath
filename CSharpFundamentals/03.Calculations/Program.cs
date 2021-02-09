using System;

namespace _03.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            double firstNum = double.Parse(Console.ReadLine());
            double secNum = double.Parse(Console.ReadLine());


            if (operation == "add")
            {
                AddMeth(firstNum, secNum);
            }
            else if (operation == "multiply")
            {
                MultiplyMeth(firstNum, secNum);
            }
            else if (operation == "substract")
            {
                SubsMeth(firstNum, secNum);
            }
            else if (operation == "divide")
            {
                DivMeth(firstNum, secNum);
            }
        }

        private static void DivMeth(double firstNum, double secNum)
        {
            Console.WriteLine(firstNum/secNum);
        }

        private static void SubsMeth(double firstNum, double secNum)
        {
            Console.WriteLine(firstNum - secNum);

        }

        private static void MultiplyMeth(double firstNum, double secNum)
        {
            Console.WriteLine(firstNum * secNum);

        }

        private static void AddMeth(double firstNum, double secNum)
        {
            Console.WriteLine(firstNum + secNum);

        }
    }
}
