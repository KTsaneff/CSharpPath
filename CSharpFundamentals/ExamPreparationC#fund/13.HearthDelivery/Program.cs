using System;
using System.Collections.Generic;
using System.Linq;

namespace _13.HearthDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> neighbourhood = Console.ReadLine()
                                      .Split("@")
                                      .Select(int.Parse)
                                      .ToList();

            string command;
            int currPosition = 0;

            while ((command = Console.ReadLine()) != "Love!")
            {
                string[] cmdArg = command.Split();
                int jumpLength = int.Parse(cmdArg[1]);

                if (currPosition + jumpLength < neighbourhood.Count)
                {
                    currPosition += jumpLength;
                }
                else
                {
                    currPosition = 0;
                }

                int currHouse = neighbourhood[currPosition];

                if (currHouse > 0)
                {
                    currHouse -= 2;

                    if (currHouse == 0)
                    {
                        Console.WriteLine($"Place {currPosition} has Valentine's day.");
                        neighbourhood[currPosition] = currHouse;
                        continue;
                    }
                    else
                    {
                        neighbourhood[currPosition] = currHouse;
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine($"Place {currPosition} already had Valentine's day.");
                }
            }

            Console.WriteLine($"Cupid's last position was {currPosition}.");

            bool MissionFailed = false;
            int counter = 0;

            for (int i = 0; i < neighbourhood.Count; i++)
            {
                if (neighbourhood[i] > 0)
                {
                    counter++;
                    MissionFailed = true;
                }
            }

            if (MissionFailed)
            {
                Console.WriteLine($"Cupid has failed {counter} places.");
            }
            else
            {
                Console.WriteLine($"Mission was successful.");
            }
        }
    }
}
