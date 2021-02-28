using System;
using System.Linq;

namespace _210.RAMVBunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];
            char[,] matrix = new char[rows, cols];

            int currRow = 0;
            int currCol = 0;

            int lastRow = 0;
            int lastCol = 0;

            for (int row = 0; row < rows; row++)
            {
                char[] rowData = Console.ReadLine().ToCharArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowData[col];

                    if (matrix[row, col] == 'P')
                    {
                        currRow = row;
                        currCol = col;
                    }
                }
            }

            char[] instructions = Console.ReadLine().ToUpper().ToCharArray();
            bool isEscaped = false;

            for (int i = 0; i < instructions.Length; i++)
            {
                matrix[currRow, currCol] = '.';

                if (currRow == 0 || currCol == 0)
                {
                    lastRow = currRow;
                    lastCol = currCol;
                }

                if (instructions[i] == 'U')
                {
                    currRow--;
                }
                if (instructions[i] == 'D')
                {
                    currRow++;
                }
                if (instructions[i] == 'L')
                {
                    currCol--;
                }
                if (instructions[i] == 'R')
                {
                    currCol++;
                }

                if (currRow < 0 || currRow >= matrix.GetLength(0) || currCol < 0 || currCol >= matrix.GetLength(1))
                {
                    isEscaped = true;
                    BunniesSpread(matrix);
                    break;
                }
                else
                {
                    if (matrix[currRow,currCol] == 'B')
                    {
                        BunniesSpread(matrix);
                        lastRow = currRow;
                        lastCol = currCol;
                        break;
                    }
                    else
                    {
                        matrix[currRow, currCol] = 'P';
                        BunniesSpread(matrix);
                        continue;
                    }
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }

            if (isEscaped)
            {
                Console.WriteLine($"won: {lastRow} {lastCol}");
            }
            else
            {
                Console.WriteLine($"dead: {lastRow} {lastCol}");
            }
        }

        private static void BunniesSpread(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'B')
                    {
                        if (row - 1 >= 0)
                        {
                            if (matrix[row - 1, col] != 'B')
                            {
                                matrix[row - 1, col] = 'b';
                            }
                        }
                        if (col + 1 < matrix.GetLength(1))
                        {
                            if (matrix[row, col + 1] != 'B')
                            {
                                matrix[row, col + 1] = 'b';
                            }
                        }
                        if (row + 1 < matrix.GetLength(0))
                        {
                            if (matrix[row + 1, col] != 'B')
                            {
                                matrix[row + 1, col] = 'b';
                            }
                        }
                        if (col - 1 >= 0)
                        {
                            if (matrix[row, col - 1] != 'B')
                            {
                                matrix[row, col - 1] = 'b';
                            }
                        }
                    }
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'b')
                    {
                        matrix[row, col] = 'B';
                    }
                }
            }
        }
    }
}
