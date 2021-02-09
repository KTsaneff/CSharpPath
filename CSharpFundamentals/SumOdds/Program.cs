using System;

namespace SumOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int output = 1;
            int sum = 0;
            int outputCounter = 0;

            while (outputCounter < count)
            {
                if (output % 2 != 0)
                {
                    sum += output;
                    Console.WriteLine(output);
                    outputCounter++;
                }
                output++;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
