using System;
using System.Linq;

namespace _205.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizeData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string[,] matrix = new string[sizeData[0], sizeData[1]];
            char[] snake = Console.ReadLine().ToCharArray();
            int counter = 0;

            string direction = "right";

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (direction == "right")
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = snake[counter].ToString();

                        counter++;
                        if (counter == snake.Length)
                        {
                            counter = 0;
                        }
                    }
                }
               
                if (direction == "left")
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        matrix[row, col] = snake[counter].ToString();

                        counter++;
                        if (counter == snake.Length)
                        {
                            counter = 0;
                        }
                    }
                }

                if (direction == "right")
                {
                    direction = "left";
                }
                else
                {
                    direction = "right";
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
