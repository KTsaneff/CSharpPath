using System;
using System.Collections.Generic;
using System.Linq;

namespace _23.MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> initialList = Console.ReadLine()
                                           .Split().ToList();
            string command;
            int movesCounter = 0;
            int hitAll = initialList.Count;

            while ((command = Console.ReadLine()) != "end")
            {
                movesCounter++;
                string[] newGuess = command.Split();
                int firstIndex = int.Parse(newGuess[0]);
                int secondIndex = int.Parse(newGuess[1]);

                if (IndexOutsideTheBounds(firstIndex, secondIndex, initialList.Count - 1))
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    initialList.Insert(initialList.Count/2, $"{-movesCounter}a");
                    initialList.Insert(initialList.Count/2, $"{-movesCounter}a");
                    continue;
                }

                if (initialList[firstIndex] == initialList[secondIndex])
                {
                    hitAll -=2;
                    Console.WriteLine($"Congrats! You have found matching elements - {initialList[firstIndex]}!");
                    initialList.RemoveAt(Math.Max(firstIndex, secondIndex));
                    initialList.RemoveAt(Math.Min(firstIndex, secondIndex));
                    
                    if (hitAll == 0)
                    {
                        break;
                    }
                    continue;
                }
                else
                {
                    Console.WriteLine("Try again!");
                }
            }

            while (command != "end")
            {
                command = Console.ReadLine();
            }

            if (hitAll > 0)
            {
                Console.WriteLine($"Sorry you lose :({Environment.NewLine}{string.Join(" ", initialList)}");
            }
            if (hitAll == 0)
            {
                Console.WriteLine($"You have won in {movesCounter} turns!");
            }
        }

        private static bool IndexOutsideTheBounds(int firstIndex, int secondIndex, int bounds)
        {
            if (firstIndex >= 0 && secondIndex >= 0 && firstIndex <= bounds && secondIndex <= bounds && firstIndex != secondIndex)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
