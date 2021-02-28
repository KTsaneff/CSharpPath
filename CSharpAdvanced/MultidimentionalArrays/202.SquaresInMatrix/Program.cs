using System;
using System.Linq;

namespace _202.SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizeData = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = sizeData[0];
            int cols = sizeData[1];
            string[,] matrix = new string[rows, cols];
            int counter = 0;

            for (int row = 0; row < rows; row++)
            {
                string[] rowData = Console.ReadLine().Split();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            string[,] squareMatrix = new string[2, 2];

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    squareMatrix[0, 0] = matrix[row, col];
                    squareMatrix[0, 1] = matrix[row, col + 1];
                    squareMatrix[1, 0] = matrix[row + 1, col];
                    squareMatrix[1, 1] = matrix[row + 1, col + 1];

                    if (squareMatrix[0, 0] == squareMatrix[0, 1] &&
                        squareMatrix[0, 0] == squareMatrix[1, 0] &&
                        squareMatrix[0, 0] == squareMatrix[1, 1])
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
