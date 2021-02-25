using System;
using System.Security.Cryptography;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingPokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int ExhFactor = int.Parse(Console.ReadLine());

            int presentPower = startingPokePower;
            int targetCounter = 0;

            while (presentPower >= distance)
            {
                targetCounter++;
                presentPower -= distance;

                if (2*presentPower == startingPokePower)
                {
                    if (ExhFactor != 0)
                    {
                        presentPower /= ExhFactor;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine(presentPower);
            Console.WriteLine(targetCounter);
        }
    }
}
