using System;

namespace LowerToUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = Convert.ToChar(Console.ReadLine());

            bool isUpper;
            isUpper = Char.IsUpper(input);

            if (isUpper)
            {
                Console.WriteLine($"upper-case");
            }
            else
            {
                Console.WriteLine($"lower-case");
            }
        }
    }
}
