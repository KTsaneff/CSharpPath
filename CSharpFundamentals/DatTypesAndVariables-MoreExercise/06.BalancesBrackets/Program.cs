using System;

namespace _06.BalancesBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            bool firstCheck = true;
            bool isBalanced = true;

            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();

                if (!firstCheck && input == "(")
                {
                    isBalanced = false;
                }

                if (input != "(" && input != ")")
                {
                    continue;
                }
                if (input =="(")
                {
                    firstCheck = false;
                    continue;
                }
                if (input == ")" && firstCheck)
                {
                    isBalanced = false;
                    continue;
                }
                if (input == ")" && !firstCheck)
                {
                    firstCheck = true;
                    continue;
                }
            }

            if (!isBalanced || !firstCheck)
            {
                Console.WriteLine($"UNBALANCED");
            }
            else
            {
                Console.WriteLine($"BALANCED");
            }
        }
    }
}
