using System;

namespace MultiplTable2
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            if (multiplier>10)
            {
                Console.WriteLine($"{input} X {multiplier} = {input*multiplier}");
            }
            else
            {
                while (multiplier<=10)
                {
                    Console.WriteLine($"{input} X {multiplier} = {input * multiplier}");
                    multiplier++;
                }
            }
        }
    }
}
