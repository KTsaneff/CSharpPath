using System;

namespace _207.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] chessBoard = new int[size, size];
            int counter = 0;
            bool moreThreadsExisting = true;

            for (int row = 0; row < size; row++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                for (int col = 0; col < size; col++)
                {
                    if (input[col] == 'K')
                    {
                        chessBoard[row, col] = 1;
                    }
                    else
                    {
                        chessBoard[row, col] = 0;
                    }
                }
            }

            while (moreThreadsExisting)
            {
                int maxThreadCount = 0;
                int maxThreadRow = -1;
                int maxThreadCol = -1;

                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        int currThreads = 0;
                        if (chessBoard[row,col] == 1)
                        {
                            if (row + 1 < size && col + 2 < size)
                            {
                                if (chessBoard[row + 1, col + 2] == 1)
                                {
                                    currThreads++;
                                }
                            }
                            if (row + 2 < size && col + 1 < size)
                            {
                                if (chessBoard[row + 2, col + 1] == 1)
                                {
                                    currThreads++;
                                }
                            }
                            if (row + 2 < size && col - 1 >= 0)
                            {
                                if (chessBoard[row + 2, col - 1] == 1)
                                {
                                    currThreads++;
                                }
                            }
                            if (row + 1 < size && col - 2 >= 0)
                            {
                                if (chessBoard[row + 1, col - 2] == 1)
                                {
                                    currThreads++;
                                }
                            }
                            if (row - 1 >= 0 && col - 2 >= 0)
                            {
                                if (chessBoard[row - 1, col - 2] == 1)
                                {
                                    currThreads++;
                                }
                            }
                            if (row - 2 >= 0 && col - 1 >= 0)
                            {
                                if (chessBoard[row - 2, col - 1] == 1)
                                {
                                    currThreads++;
                                }
                            }
                            if (row - 2 >= 0 && col + 1 < size)
                            {
                                if (chessBoard[row - 2, col + 1] == 1)
                                {
                                    currThreads++;
                                }
                            }
                            if (row - 1 >= 0 && col + 2 < size)
                            {
                                if (chessBoard[row - 1, col + 2] == 1)
                                {
                                    currThreads++;
                                }
                            }

                        }
                        else
                        {
                            continue;
                        }

                        if (currThreads > maxThreadCount)
                        {
                            maxThreadCount = currThreads;
                            maxThreadRow = row;
                            maxThreadCol = col;
                        }
                    } 
                }
                
                if (maxThreadRow != -1)
                {
                    chessBoard[maxThreadRow, maxThreadCol] = 0;
                    counter++;
                }
                if (maxThreadCount == 0)
                {
                    moreThreadsExisting = false;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
