using System;
using System.Collections.Generic;
using System.Linq;

namespace _305.DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Dragon>> dragonArmy = new Dictionary<string, List<Dragon>>();

            int lines = int.Parse(Console.ReadLine());
            string input;

            for (int i = 0; i < lines; i++)
            {
                input = Console.ReadLine();

                string type = input.Split(" ", StringSplitOptions.RemoveEmptyEntries)[0];
                string name = input.Split(" ", StringSplitOptions.RemoveEmptyEntries)[1];

                int damage = input.Split(" ", StringSplitOptions.RemoveEmptyEntries)[2] ==
                    "null" ? 45 : int.Parse(input.Split(" ", StringSplitOptions.RemoveEmptyEntries)[2]);

                int health = input.Split(" ", StringSplitOptions.RemoveEmptyEntries)[3] ==
                    "null" ? 250 : int.Parse(input.Split(" ", StringSplitOptions.RemoveEmptyEntries)[3]);

                int armour = input.Split(" ", StringSplitOptions.RemoveEmptyEntries)[4] ==
                    "null" ? 10 : int.Parse(input.Split(" ", StringSplitOptions.RemoveEmptyEntries)[4]);


                if (!dragonArmy.ContainsKey(type))
                {
                    dragonArmy.Add(type, new List<Dragon>());
                }

                if (!dragonArmy[type].Exists(x => x.Name == name))
                {
                    Dragon newDragon = new Dragon(name, damage, health, armour);
                    dragonArmy[type].Add(newDragon);
                }

                if (dragonArmy.ContainsKey(type) && dragonArmy[type].Exists(x => x.Name == name))
                {
                    int currDamage = dragonArmy[type].First(x => x.Name == name).Damage;
                    int currHealth = dragonArmy[type].First(x => x.Name == name).Health;
                    int currArmour = dragonArmy[type].First(x => x.Name == name).Armour;

                    dragonArmy[type].RemoveAll(x => x.Name == name);

                    Dragon newDragon = new Dragon(name, damage, health, armour);
                    dragonArmy[type].Add(newDragon);
                }
            }

            foreach (var type in dragonArmy)
            {
                double avgDamage = type.Value.Average(x => x.Damage);
                double avgHealth = type.Value.Average(x => x.Health);
                double avgArmour = type.Value.Average(x => x.Armour);

                Console.WriteLine($"{type.Key}::({avgDamage:f2}/{avgHealth:f2}/{avgArmour:f2})");
                foreach (var dragon in type.Value.OrderBy(x => x.Name))
                {
                    Console.WriteLine($"-{dragon.Name} -> damage: {dragon.Damage}, health: {dragon.Health}, armor: {dragon.Armour}");
                }
            }
        }
    }

    public class Dragon
    {
        public Dragon(string name, int damage, int health, int armour)
        {
            Name = name;
            Damage = damage;
            Health = health;
            Armour = armour;
        }

        public string Name { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Armour { get; set; }
    }
}
