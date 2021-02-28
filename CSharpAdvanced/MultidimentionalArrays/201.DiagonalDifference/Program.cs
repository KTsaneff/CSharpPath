using System;
using System.Linq;

namespace _201.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            for (int row = 0; row < size; row++)
            {
                int[] rowData = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            int diagonal1 = 0;
            int diagonal2 = 0;

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col = row)
                {
                    diagonal1 += matrix[row, col];
                    row++;
                }
            }

            for (int row = 0; row < size; row++)
            {
                for (int col = size - 1; col >= 0; col--)
                {
                    diagonal2 += matrix[row, col];
                    row++;
                }
            }

            int diff = Math.Abs(diagonal1 - diagonal2);
            Console.WriteLine(diff);
        }
    }
}
