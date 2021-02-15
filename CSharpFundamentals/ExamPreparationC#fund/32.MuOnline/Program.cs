using System;
using System.Collections.Generic;
using System.Linq;

namespace _32.MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialHealth = 100;
            int bitCoins = 0;
            int roomReached = 0;
            bool isAlive = true;

            List<string> roomsList = Console.ReadLine().Split("|").ToList();

            for (int i = 0; i < roomsList.Count; i++)
            {
                roomReached++;
                string[] cmdArg = roomsList[i].Split();
                string obstacle = cmdArg[0];
                int value = int.Parse(cmdArg[1]);

                if (obstacle == "potion")
                {
                    int healAmount = 0;

                    if (initialHealth + value > 100)
                    {
                        healAmount = 100 - initialHealth;
                        initialHealth = 100;
                    }
                    else
                    {
                        initialHealth += value;
                        healAmount = value;
                    }

                    Console.WriteLine($"You healed for {healAmount} hp.");
                    Console.WriteLine($"Current health: {initialHealth} hp.");
                }
                else if (obstacle == "chest")
                {
                    bitCoins += value;
                    Console.WriteLine($"You found {value} bitcoins.");
                }
                else
                {
                    initialHealth -= value;

                    if (initialHealth > 0)
                    {
                        Console.WriteLine($"You slayed {obstacle}.");
                    }
                    else
                    {
                        isAlive = false;
                        Console.WriteLine($"You died! Killed by {obstacle}.");
                        Console.WriteLine($"Best room: {roomReached}");
                        break;
                    }
                }
            }

            if (isAlive)
            {
                Console.WriteLine($"You've made it!{Environment.NewLine}" +
                                  $"Bitcoins: {bitCoins}{Environment.NewLine}" +
                                  $"Health: {initialHealth}");
            }
        }
    }
}
