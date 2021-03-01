using System;
using System.Collections.Generic;

namespace _206.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            var clothes = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < lines; i++)
            {
                var newLine = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string color = newLine[0];
                var newClothes = newLine[1].Split(",", StringSplitOptions.RemoveEmptyEntries);

                if (!clothes.ContainsKey(color))
                {
                    clothes.Add(color, new Dictionary<string, int>());
                }

                for (int j = 0; j < newClothes.Length; j++)
                {
                    if (!clothes[color].ContainsKey(newClothes[j]))
                    {
                        clothes[color].Add(newClothes[j], 0);
                    }

                    clothes[color][newClothes[j]]++;
                }
            }

            string[] searchFor = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string searchedColor = searchFor[0];
            string searchedCloth = searchFor[1];

            foreach (var differentColor in clothes)
            {
                Console.WriteLine($"{differentColor.Key} clothes:");
                foreach (var cloth in differentColor.Value)
                {
                    Console.Write($"* {cloth.Key} - {cloth.Value}");

                    if (differentColor.Key == searchedColor && cloth.Key == searchedCloth)
                    {
                        Console.Write($" (found!)");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
