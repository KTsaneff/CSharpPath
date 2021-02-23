using System;
using System.Collections.Generic;
using System.Linq;

namespace _503.HeroesOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int heroesCount = int.Parse(Console.ReadLine());
            Dictionary<string, Hero> heroes = new Dictionary<string, Hero>();
            string[] newEntry;

            for (int i = 0; i < heroesCount; i++)
            {
                newEntry = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = newEntry[0];
                
                int hitPoints = int.Parse(newEntry[1]);
                if (hitPoints > 200)
                {
                    hitPoints = 200;
                }
                
                int manaPoints = int.Parse(newEntry[2]);
                if (manaPoints > 200)
                {
                    manaPoints = 200;
                }

                Hero newHero = new Hero(name, hitPoints, manaPoints);
                heroes.Add(name, newHero);
            }

            string[] instructions;
            while ((instructions = Console.ReadLine().Split(" - "))[0] != "End")
            {
                string command = instructions[0];
                string name = instructions[1];
                switch (command)
                {
                    case "CastSpell":
                        int manaPointsNeeded = int.Parse(instructions[2]);
                        string spellName = instructions[3];

                        if (heroes[name].ManaPoints >= manaPointsNeeded)
                        {
                            heroes[name].ManaPoints -= manaPointsNeeded;
                            Console.WriteLine($"{name} has successfully cast {spellName} and now has {heroes[name].ManaPoints} MP!");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine($"{name} does not have enough MP to cast {spellName}!");
                            continue;
                        }
                        break;

                    case "TakeDamage":
                        int damage = int.Parse(instructions[2]);
                        string attacker = instructions[3];

                        if (heroes[name].HitPoints - damage > 0)
                        {
                            heroes[name].HitPoints -= damage;
                            Console.WriteLine($"{name} was hit for {damage} HP by {attacker} and now has {heroes[name].HitPoints} HP left!");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine($"{name} has been killed by {attacker}!");
                            heroes.Remove(name);
                            continue;
                        }
                        break;

                    case "Recharge":
                        int rechargeAmount = int.Parse(instructions[2]);
                        int currManaPoints = heroes[name].ManaPoints;

                        heroes[name].ManaPoints += rechargeAmount;
                        if (heroes[name].ManaPoints > 200)
                        {
                            heroes[name].ManaPoints = 200;
                        }

                        Console.WriteLine($"{name} recharged for {heroes[name].ManaPoints - currManaPoints} MP!");
                        break;

                    case "Heal":
                        int healAmount = int.Parse(instructions[2]);
                        int currHitPoints = heroes[name].HitPoints;

                        heroes[name].HitPoints += healAmount;
                        if (heroes[name].HitPoints > 100)
                        {
                            heroes[name].HitPoints = 100;
                        }

                        Console.WriteLine($"{name} healed for {heroes[name].HitPoints - currHitPoints} HP!");
                        break;
                }
            }

            foreach (var hero in heroes.Values.OrderByDescending(x => x.HitPoints).ThenBy(x => x.Name))
            {
                Console.WriteLine($"{hero.Name}");
                Console.WriteLine($"  HP: {hero.HitPoints}");
                Console.WriteLine($"  MP: {hero.ManaPoints}");
            }
        }
    }

    class Hero
    {
        public Hero(string name, int hitPoints, int manaPoints)
        {
            Name = name;
            HitPoints = hitPoints;
            ManaPoints = manaPoints;
        }

        public string Name { get; set; }
        public int HitPoints { get; set; }
        public int ManaPoints { get; set; }
    }
}
