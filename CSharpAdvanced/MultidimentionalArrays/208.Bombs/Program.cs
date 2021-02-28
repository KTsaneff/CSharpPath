using System;
using System.Linq;

namespace _208.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            for (int row = 0; row < size; row++)
            {
                int[] rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            string[] bombsCoordinates = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int sumAliveCells = 0;
            int aliveCounter = 0;

            for (int i = 0; i < bombsCoordinates.Length; i++)
            {
                int bombRow = int.Parse(bombsCoordinates[i].Split(",", StringSplitOptions.RemoveEmptyEntries)[0]);
                int bombCol = int.Parse(bombsCoordinates[i].Split(",", StringSplitOptions.RemoveEmptyEntries)[1]);

                int bombStrenght = matrix[bombRow, bombCol];

                if (bombStrenght > 0)
                {
                    if (bombRow >= 0 && bombRow < size && bombCol >= 0 && bombCol < size && matrix[bombRow, bombCol] > 0)
                    {
                        matrix[bombRow, bombCol] -= bombStrenght;
                    }
                    if (bombRow >= 0 && bombRow < size && bombCol + 1 >= 0 && bombCol + 1 < size && matrix[bombRow, bombCol + 1] > 0)
                    {
                        matrix[bombRow, bombCol + 1] -= bombStrenght;
                    }
                    if (bombRow + 1 >= 0 && bombRow + 1 < size && bombCol + 1 >= 0 && bombCol + 1 < size && matrix[bombRow + 1, bombCol + 1] > 0)
                    {
                        matrix[bombRow + 1, bombCol + 1] -= bombStrenght;
                    }
                    if (bombRow + 1 >= 0 && bombRow + 1 < size && bombCol >= 0 && bombCol < size && matrix[bombRow + 1, bombCol] > 0)
                    {
                        matrix[bombRow + 1, bombCol] -= bombStrenght;
                    }
                    if (bombRow + 1 >= 0 && bombRow + 1 < size && bombCol - 1 >= 0 && bombCol - 1 < size && matrix[bombRow + 1, bombCol - 1] > 0)
                    {
                        matrix[bombRow + 1, bombCol - 1] -= bombStrenght;
                    }
                    if (bombRow >= 0 && bombRow < size && bombCol - 1 >= 0 && bombCol - 1 < size && matrix[bombRow, bombCol - 1] > 0)
                    {
                        matrix[bombRow, bombCol - 1] -= bombStrenght;
                    }
                    if (bombRow - 1 >= 0 && bombRow - 1 < size && bombCol - 1 >= 0 && bombCol - 1 < size && matrix[bombRow - 1, bombCol - 1] > 0)
                    {
                        matrix[bombRow - 1, bombCol - 1] -= bombStrenght;
                    }
                    if (bombRow - 1 >= 0 && bombRow - 1 < size && bombCol >= 0 && bombCol < size && matrix[bombRow - 1, bombCol] > 0)
                    {
                        matrix[bombRow - 1, bombCol] -= bombStrenght;
                    }
                    if (bombRow - 1 >= 0 && bombRow - 1 < size && bombCol + 1 >= 0 && bombCol + 1 < size && matrix[bombRow - 1, bombCol + 1] > 0)
                    {
                        matrix[bombRow - 1, bombCol + 1] -= bombStrenght;
                    }
                }
            }

            foreach (var item in matrix)
            {
                if (item > 0)
                {
                    sumAliveCells += item;
                    aliveCounter++;
                }
            }

            Console.WriteLine($"Alive cells: {aliveCounter}");
            Console.WriteLine($"Sum: {sumAliveCells}");

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
