using System;

namespace _01._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int bitValue = int.Parse(Console.ReadLine());
            int sum = 0;

            while (number != 0)
            {
                if ((number & 1) == bitValue)
                {
                    sum++;
                }
                number = number >> 1;
            }

            Console.WriteLine(sum);
        }
    }
}
