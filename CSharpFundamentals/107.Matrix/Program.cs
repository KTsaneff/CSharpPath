using System;

namespace _107.Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit = int.Parse(Console.ReadLine());

            PrintMatrix(digit);
        }

        private static void PrintMatrix(int digit)
        {
            for (int i = 0; i < digit; i++)
            {
                for (int j = 0; j < digit; j++)
                {
                    Console.Write(digit + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
