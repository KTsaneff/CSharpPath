using System;

namespace _103.RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int position = int.Parse(Console.ReadLine());
            long firstElement = 1;
            long secondElement = 1;

            for (int i = 2; i < position; i++)
            {
                long temp = secondElement;
                secondElement = firstElement + secondElement;
                firstElement = temp;

            }

            if (position == 1)
            {
                Console.WriteLine(firstElement);
            }
            else
            {
                Console.WriteLine(secondElement);
            }
        }
    }
}
