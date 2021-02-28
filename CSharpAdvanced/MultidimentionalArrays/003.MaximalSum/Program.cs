using System;
using System.Linq;

namespace _003.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizeData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[][] matrix = new int[sizeData[0]][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            int maxSum = 0;
            int rowMax = 0;
            int colMax = 0;

            for (int row = 0; row < matrix.Length - 2; row++)
            {
                for (int col = 0; col < matrix[row].Length - 2; col++)
                {
                    int currSum = matrix[row][col] + matrix[row][col + 1] + matrix[row][col + 2] +
                                  matrix[row + 1][col] + matrix[row + 1][col + 1] + matrix[row + 1][col + 2] +
                                  matrix[row + 2][col] + matrix[row + 2][col + 1] + matrix[row + 2][col + 2];

                    if (currSum > maxSum)
                    {
                        rowMax = row;
                        colMax = col;
                        maxSum = currSum;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            for (int i = rowMax; i < rowMax + 3; i++)
            {
                for (int j = colMax; j < colMax + 3; j++)
                {
                    Console.Write($"{matrix[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
