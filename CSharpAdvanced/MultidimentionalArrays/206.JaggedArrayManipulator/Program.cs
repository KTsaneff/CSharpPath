using System;
using System.Linq;

namespace _206.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] matrix = new double[rows][];

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            }

            for (int row = 0; row < rows - 1; row++)
            {
                if (matrix[row].Length == matrix[row+1].Length)
                {
                    for (int i = 0; i < matrix[row].Length; i++)
                    {
                        matrix[row][i] *= 2;
                        matrix[row + 1][i] *= 2;
                    }
                }
                else
                {
                    for (int i = 0; i < matrix[row].Length; i++)
                    {
                        matrix[row][i] /= 2;
                    }
                    for (int i = 0; i < matrix[row + 1].Length; i++)
                    {
                        matrix[row + 1][i] /= 2;
                    }
                }
            }

            string[] instructions;
            while ((instructions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries))[0] != "End")
            {
                int doRow = int.Parse(instructions[1]);
                int doCol = int.Parse(instructions[2]);
                int value = int.Parse(instructions[3]);

                if (IndexIsOutsideTheBounds(doRow, doCol, matrix))
                {
                    continue;
                }

                if (instructions[0] == "Add")
                {
                    matrix[doRow][doCol] += value;
                }
                else if (instructions[0] == "Subtract")
                {
                    matrix[doRow][doCol] -= value;
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static bool IndexIsOutsideTheBounds(int doRow, int doCol, double[][] matrix)
        {
            if (doRow < 0 || doRow >= matrix.GetLength(0))
            {
                return true;
            }
            if (doCol < 0 || doCol >= matrix[doRow].Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
