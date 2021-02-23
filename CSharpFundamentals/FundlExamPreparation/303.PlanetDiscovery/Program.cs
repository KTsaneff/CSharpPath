using System;
using System.Collections.Generic;
using System.Linq;

namespace _303.PlanetDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Plant> plants = new Dictionary<string, Plant>();

            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string[] newEntry = Console.ReadLine().Split("<->");
                string plantName = newEntry[0];
                int rarity = int.Parse(newEntry[1]);

                Plant newPlant = new Plant(plantName, rarity, new List<double>(), 0);

                if (!plants.ContainsKey(plantName))
                {
                    plants[plantName] = newPlant;
                }
                else
                {
                    plants[plantName].Rarity = rarity;
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "Exhibition")
            {
                string[] cmdArg = command.Split(": ");
                string action = cmdArg[0];

                if (action == "Rate")
                {
                    string[] temp = cmdArg[1].Split(" - ");
                    string plant = temp[0];
                    double rating = double.Parse(temp[1]);

                    if (plants.ContainsKey(plant))
                    {
                        plants[plant].Rating.Add(rating);
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("error");
                        continue;
                    }

                }
                else if (action == "Update")
                {
                    string[] temp = cmdArg[1].Split(" - ");
                    string plant = temp[0];
                    int newRarity = int.Parse(temp[1]);

                    if (plants.ContainsKey(plant))
                    {
                        plants[plant].Rarity = newRarity;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("error");
                        continue;
                    }
                }
                else if (action == "Reset")
                {
                    string plant = cmdArg[1];

                    if (plants.ContainsKey(plant))
                    {
                        plants[plant].Rating.RemoveAll(x => x != null);
                        plants[plant].AverageRating = 0;
                    }
                    else
                    {
                        Console.WriteLine("error");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("error");
                    continue;
                }
            }

            foreach (var plant in plants.Values)
            {
                if (plant.Rating.Count > 0)
                {
                    plant.AverageRating = plant.Rating.Average();
                }
            }

            Console.WriteLine($"Plants for the exhibition:");

            foreach (var item in plants.Values.OrderByDescending(x => x.Rarity).ThenByDescending(x => x.AverageRating))
            {
                Console.WriteLine(item);
            }
        }
    }
    class Plant
    {
        public Plant(string name, int rarity, List<double> rating, double averageRating)
        {
            Name = name;
            Rarity = rarity;
            Rating = rating;
            AverageRating = averageRating;
        }

        public string Name { get; set; }
        public int Rarity { get; set; }
        public List<double> Rating { get; set; }
        public double AverageRating { get; set; }

        public override string ToString()
        {
            return $"- {Name}; Rarity: {Rarity}; Rating: {AverageRating:f2}";
        }
    }
}
