using System;

namespace _201.DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string constant = Console.ReadLine();

                string output = OperateWithType(input, constant);
                Console.WriteLine(output);
            
        }

        private static string OperateWithType(string input, string constant)
        {
            string output = string.Empty;

            if (input == "int")
            {
               Int32Operator(constant);
            }
            if (input == "real")
            {
                RealTypeOperator(constant);
            }
            if (input == "string")
            {
                StringOperator(constant);
            }

            return output;
        }

        private static void StringOperator(string constant)
        {
            Console.WriteLine($"${constant}$");
        }

        private static void RealTypeOperator(string constant)
        {
            double result = double.Parse(constant);
            result = result * 1.5;
            Console.WriteLine($"{result:f2}");
        }

        private static void Int32Operator(string constant)
        {
            int result = int.Parse(constant) * 2;

            Console.WriteLine(result);
        }
    }
}
