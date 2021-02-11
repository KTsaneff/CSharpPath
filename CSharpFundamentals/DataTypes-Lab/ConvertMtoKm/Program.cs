using System;

namespace ConvertMtoKm
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            double index = 0.001;

            double result = meters * index;

            Console.WriteLine($"{result:f2}");

        }
    }
}
