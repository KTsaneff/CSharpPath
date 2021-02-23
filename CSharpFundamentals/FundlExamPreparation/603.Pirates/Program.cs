using System;
using System.Collections.Generic;
using System.Linq;

namespace _603.Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Destination> destinations = new Dictionary<string, Destination>();

            string[] newDestination;
            while ((newDestination = Console.ReadLine().Split("||", StringSplitOptions.RemoveEmptyEntries))[0] != "Sail")
            {
                string city = newDestination[0];
                int population = int.Parse(newDestination[1]);
                int gold = int.Parse(newDestination[2]);

                Destination newCity = new Destination(city, population, gold);

                if (!destinations.ContainsKey(city))
                {
                    destinations[city] = newCity;
                }
                else
                {
                    destinations[city].Population += population;
                    destinations[city].Gold += gold;
                }
            }

            string[] newEvent;
            while ((newEvent = Console.ReadLine().Split("=>", StringSplitOptions.RemoveEmptyEntries))[0] != "End")
            {
                string action = newEvent[0];
                string city = newEvent[1];


                if (action == "Plunder")
                {
                    int killed = 0;
                    int stolen = 0;

                    int people = int.Parse(newEvent[2]);
                    if (destinations[city].Population - people < 0)
                    {
                        killed = destinations[city].Population;
                        destinations[city].Population = 0;
                    }
                    else
                    {
                        killed = people;
                        destinations[city].Population -= people;
                    }

                    int gold = int.Parse(newEvent[3]);
                    if (destinations[city].Gold - gold < 0)
                    {
                        stolen = destinations[city].Gold;
                        destinations[city].Gold = 0;
                    }
                    else
                    {
                        stolen = gold;
                        destinations[city].Gold -= gold;
                    }

                    Console.WriteLine($"{city} plundered! {stolen} gold stolen, {killed} citizens killed.");

                    if (destinations[city].Population == 0 || destinations[city].Gold == 0)
                    {
                        Console.WriteLine($"{city} has been wiped off the map!");
                        destinations.Remove(city);
                    }

                    continue;
                }
                if (action == "Prosper")
                {
                    int gold = int.Parse(newEvent[2]);

                    if (gold < 0)
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                        continue;
                    }
                    else
                    {
                        destinations[city].Gold += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {city} now has {destinations[city].Gold} gold.");
                    }


                }
            }

            if (destinations.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {destinations.Count} wealthy settlements to go to:");

                foreach (var town in destinations.Values.OrderByDescending(x => x.Gold).ThenBy(x => x.Name))
                {
                    Console.WriteLine($"{town.Name} -> Population: {town.Population} citizens, Gold: {town.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            
        }
    }
    class Destination
    {
        public Destination(string name, int population, int gold)
        {
            Name = name;
            Population = population;
            Gold = gold;
        }

        public string Name { get; set; }
        public int Population { get; set; }
        public int Gold { get; set; }
    }
}
