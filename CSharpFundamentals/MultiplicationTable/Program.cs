using System;
using System.Diagnostics.Tracing;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int counter = 1;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{input} X {counter} = {input*counter}");
                counter++;
            }
        }
    }
}
