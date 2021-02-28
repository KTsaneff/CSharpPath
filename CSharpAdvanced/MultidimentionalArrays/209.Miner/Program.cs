using System;

namespace _209.Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[,] matrix = new string[size, size];

            string[] commandsToMove = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int startRow = 0;
            int startCol = 0;
            int coalCounter = 0;

            for (int row = 0; row < size; row++)
            {
                string[] rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = rowData[col];

                    if (matrix[row, col] == "s")
                    {
                        startRow = row;
                        startCol = col;
                    }
                    if (matrix[row, col] == "c")
                    {
                        coalCounter++;
                    }
                }
            }

            for (int i = 0; i < commandsToMove.Length; i++)
            {
                string currCommand = commandsToMove[i];

                if (currCommand == "left")
                {
                    if (startRow >= 0 && startRow < size && startCol - 1 >= 0 && startCol - 1 < size)
                    {
                        startCol -= 1;
                    }
                }
                if (currCommand == "right")
                {
                    if (startRow >= 0 && startRow < size && startCol + 1 >= 0 && startCol + 1 < size)
                    {
                        startCol += 1;
                    }
                }
                if (currCommand == "up")
                {
                    if (startRow - 1 >= 0 && startRow - 1 < size && startCol >= 0 && startCol < size)
                    {
                        startRow -= 1;
                    }
                }
                if (currCommand == "down")
                {
                    if (startRow + 1 >= 0 && startRow + 1 < size && startCol >= 0 && startCol < size)
                    {
                        startRow += 1;
                    }
                }

                if (matrix[startRow,startCol] == "c")
                {
                    coalCounter--;
                    matrix[startRow, startCol] = "*";

                    if (coalCounter == 0)
                    {
                        Console.WriteLine($"You collected all coals! ({startRow}, {startCol})");
                        return;
                    }
                }

                if (matrix[startRow, startCol] == "e")
                {
                    Console.WriteLine($"Game over! ({startRow}, {startCol})");
                    return;
                }
            }

            Console.WriteLine($"{coalCounter} coals left. ({startRow}, {startCol})");
        }
    }
}
