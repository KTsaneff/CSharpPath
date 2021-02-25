using System;

namespace SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= counter; i++)
            {
                char input = Convert.ToChar(Console.ReadLine());
                int ascii = (int)input;
                sum += ascii;
                
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
