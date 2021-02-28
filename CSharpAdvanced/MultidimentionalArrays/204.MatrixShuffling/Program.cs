using System;
using System.Linq;

namespace _204.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizeData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string[,] matrix = new string[sizeData[0], sizeData[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            string[] instructions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (instructions[0] != "END")
            {
                string command = instructions[0];

                if (command == "swap" && instructions.Length == 5)
                {
                    int row1 = int.Parse(instructions[1]);
                    int col1 = int.Parse(instructions[2]);
                    int row2 = int.Parse(instructions[3]);
                    int col2 = int.Parse(instructions[4]);

                    if (row1 < 0 || row1 >= sizeData[0] &&
                        col1 < 0 || col1 >= sizeData[1] &&
                        row2 < 0 || row2 >= sizeData[0] &&
                        col2 < 0 || col2 >= sizeData[1])
                    {
                        Console.WriteLine("Invalid input!");
                        instructions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                        continue;
                    }

                    string tempCell = matrix[row1, col1];
                    matrix[row1, col1] = matrix[row2, col2];
                    matrix[row2, col2] = tempCell;

                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            Console.Write($"{matrix[i,j]} ");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                instructions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
