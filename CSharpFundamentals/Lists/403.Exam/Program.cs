using System;
using System.Collections.Generic;
using System.Linq;

namespace _403.Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShipPositions = Console.ReadLine().Split('>', StringSplitOptions.RemoveEmptyEntries)
                                            .Select(int.Parse).ToList();

            List<int> warShipPositions = Console.ReadLine().Split('>', StringSplitOptions.RemoveEmptyEntries)
                                            .Select(int.Parse).ToList();

            int maxHealth = int.Parse(Console.ReadLine());
            string command;
            bool warShipLost = false;
            bool pirateShipLost = false;

            while ((command = Console.ReadLine()) != "Retire")
            {
                string[] cmdArg = command.Split();
                string action = cmdArg[0];

                if (action == "Fire")
                {
                    int index = int.Parse(cmdArg[1]);
                    int damage = int.Parse(cmdArg[2]);

                    if (index >= 0 && index < warShipPositions.Count)
                    {
                        warShipPositions[index] -= damage;
                        if (warShipPositions[index] <= 0)
                        {
                            warShipLost = true;
                            break;
                        }
                        continue;
                    }
                    else
                    {
                        continue;
                    }

                }
                if (action == "Defend")
                {
                    int start = int.Parse(cmdArg[1]);
                    int end = int.Parse(cmdArg[2]);
                    int damage = int.Parse(cmdArg[3]);

                    if (start < 0)
                    {
                        start = 0;
                    }
                    if (end >= pirateShipPositions.Count)
                    {
                        end = pirateShipPositions.Count - 1;
                    }

                    for (int i = start; i <= end; i++)
                    {
                        pirateShipPositions[i] -= damage;
                        if (pirateShipPositions[i] <= 0)
                        {
                            pirateShipLost = true;
                            break;
                        }
                    }

                    if (pirateShipLost)
                    {
                        break;
                    }
                    continue;
                }
                if (action == "Repair")
                {
                    int index = int.Parse(cmdArg[1]);
                    int recover = int.Parse(cmdArg[2]);

                    if (index < 0 || index >= pirateShipPositions.Count)
                    {
                        continue;
                    }
                    else
                    {
                        pirateShipPositions[index] += recover;
                        if (pirateShipPositions[index] > maxHealth)
                        {
                            pirateShipPositions[index] = maxHealth;
                        }
                        continue;
                    }
                }
                if (action == "Status")
                {
                    int repairCounter = 0;
                    double criticLevel = maxHealth * 0.2;

                    for (int i = 0; i < pirateShipPositions.Count; i++)
                    {
                        if (pirateShipPositions[i] < criticLevel)
                        {
                            repairCounter++;
                        }
                    }

                    Console.WriteLine($"{repairCounter} sections need repair.");
                }
            }

            if (warShipLost)
            {
                Console.WriteLine("You won! The enemy ship has sunken.");
            }
            else if (pirateShipLost)
            {
                Console.WriteLine("You lost! The pirate ship has sunken.");
            }
            else
            {
                Console.WriteLine($"Pirate ship status: {pirateShipPositions.Sum()}");
                Console.WriteLine($"Warship status: {warShipPositions.Sum()}");

            }
        }
    }
}

