using System;
using System.Collections.Generic;
using System.Linq;

namespace _203.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> storageSpace = new Dictionary<string, int>()
            {
                {"shards", 0},
                {"fragments", 0},
                {"motes", 0}
            };
            Dictionary<string, int> junksCollected = new Dictionary<string, int>();

            string legendaryItem = string.Empty;
            bool isLegendaryCollected = false;

            while (true)
            {
                string[] newMaterials = Console.ReadLine()
                                               .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < newMaterials.Length - 1; i += 2)
                {
                    string newMaterial = newMaterials[i + 1].ToLower();
                    int quantity = int.Parse(newMaterials[i]);

                    AddNewResource(newMaterial, quantity, storageSpace, junksCollected);

                    if (ResourceIsLegendary(newMaterial) && MaterialIsEnough(storageSpace, newMaterial))
                    {
                        legendaryItem = newMaterial;
                        storageSpace[newMaterial] -= 250;
                        isLegendaryCollected = true;
                        break;
                    }
                }

                if (isLegendaryCollected)
                {
                    break;
                }
            }

            legendaryItem = ConvertResourceToLegendary(legendaryItem);

            Console.WriteLine($"{legendaryItem} obtained!");

            var MaterialsList = storageSpace.ToList();
            var OrderedMaterials = MaterialsList.OrderByDescending(m => m.Value).ThenBy(m => m.Key).ToList();

            foreach (var item in OrderedMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            var JunkList = junksCollected.ToList();
            var OrderedJunk = JunkList.OrderBy(j => j.Key).ToList();

            foreach (var item in OrderedJunk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        private static string ConvertResourceToLegendary(string legendaryItem)
        {
            if (legendaryItem == "shards")
            {
                legendaryItem = "Shadowmourne";
            }
            if (legendaryItem == "fragments")
            {
                legendaryItem = "Valanyr";
            }
            if (legendaryItem == "motes")
            {
                legendaryItem = "Dragonwrath";
            }

            return legendaryItem;
        }

        private static bool ResourceIsLegendary(string newMaterial)
        {
            if (newMaterial == "shards" || newMaterial == "fragments" || newMaterial == "motes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool MaterialIsEnough(Dictionary<string, int> storageSpace, string newMaterial)
        {
            if (storageSpace[newMaterial] >= 250)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void AddNewResource(string newMaterial, int quantity, Dictionary<string, int> storageSpace, Dictionary<string, int> junksCollected)
        {
            if (ResourceIsLegendary(newMaterial))
            {
                storageSpace[newMaterial] += quantity;
            }
            else
            {
                if (junksCollected.ContainsKey(newMaterial))
                {
                    junksCollected[newMaterial] += quantity;
                }
                else
                {
                    junksCollected.Add(newMaterial, quantity);
                }
            }
        }
    }


}
