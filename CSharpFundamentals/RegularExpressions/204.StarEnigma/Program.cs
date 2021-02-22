using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _204.StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            string pattern = @"([STARstar])";
            string textInput;

            List<Planet> attackedPlanets = new List<Planet>();
            List<Planet> destroyedPlanets = new List<Planet>();
            Regex regex = new Regex(pattern);

            for (int i = 0; i < lines; i++)
            {
                textInput = Console.ReadLine();
                MatchCollection matches = Regex.Matches(textInput, pattern);
                int matchesCount = matches.Count;
                string decriptedPlanet = string.Empty;

                foreach (char c in textInput)
                {
                    decriptedPlanet += Convert.ToChar(c - matchesCount);
                }

                string dPattern = @"@([A-Z][a-z]+)[^\@^\-^\!^\>^\:]*:(\d+)[^\@^\-^\!^\>^\:]*!([AD])![^\@^\-^\!^\:^\>]*->(\d+)";
                Regex regex1 = new Regex(dPattern);

                Match match = regex1.Match(decriptedPlanet);
                if (match.Success)
                {
                    string name = match.Groups[1].Value;
                    int population = int.Parse(match.Groups[2].Value);
                    string attackType = match.Groups[3].Value;
                    int soldiersCount = int.Parse(match.Groups[4].Value);

                    Planet newPlanet = new Planet(name, population, attackType, soldiersCount);

                    if (attackType == "A")
                    {
                        attackedPlanets.Add(newPlanet);
                    }
                    else
                    {
                        destroyedPlanets.Add(newPlanet);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            if (attackedPlanets.Count > 0)
            {
                foreach (var planet in attackedPlanets.OrderBy(x => x.Name))
                {
                    Console.WriteLine($"-> {planet.Name}");
                }
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            if (destroyedPlanets.Count > 0)
            {
                foreach (var planet in destroyedPlanets.OrderBy(x => x.Name))
                {
                    Console.WriteLine($"-> {planet.Name}");
                }
            }
        }
    }
    class Planet
    {
        public Planet(string name, int population, string attackType, int soldierCount)
        {
            Name = name;
            Population = population;
            AttackType = attackType;
            SoldierCount = soldierCount;
        }

        public string Name { get; set; }
        public int Population { get; set; }
        public string AttackType { get; set; }
        public int SoldierCount { get; set; }

    }
}
