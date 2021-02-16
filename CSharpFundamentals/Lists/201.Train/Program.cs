using System;
using System.Collections.Generic;
using System.Linq;

namespace _201.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                                        .Split()
                                        .Select(int.Parse)
                                        .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());
            string command;

            while ((command = Console.ReadLine().ToUpper()) != "END")
            {
                string[] cmdArg = command.Split();

                if (cmdArg[0].ToUpper() == "ADD")
                {
                    wagons.Add(int.Parse(cmdArg[1]));
                }
                else
                {
                    int passengers = int.Parse(cmdArg[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int currentWag = wagons[i];
                        bool IsEnoughSpace = currentWag + passengers <= maxCapacity;

                        if (IsEnoughSpace)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
