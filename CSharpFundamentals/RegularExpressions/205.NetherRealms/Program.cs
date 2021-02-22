using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _205.NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Daemon> allDaemons = new List<Daemon>();
            string pattern = @"[-+]?[0-9]+\.?[0-9]*";

            Regex numbersRegex = new Regex(pattern);
            string[] daemons = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var daemon in daemons)
            {
                string filter = "0123456789+-/*.";

                int health = daemon.Where(c => !filter.Contains(c)).Sum(c => c);
                double damage = CalulateDamage(numbersRegex, daemon);

                allDaemons.Add(new Daemon { Name = daemon, Health = health, Damage = damage });
            }

            foreach (var currDaemon in allDaemons.OrderBy(x => x.Name))
            {
                Console.WriteLine(currDaemon);
            }
        }

        private static double CalulateDamage(Regex numbersRegex, string daemon)
        {
            MatchCollection numberMatches = numbersRegex.Matches(daemon);
            double damage = 0;

            foreach (Match match in numberMatches)
            {
                damage += double.Parse(match.Value);
            }
            foreach (var ch in daemon)
            {
                if (ch == '*')
                {
                    damage *= 2.0;
                }
                else if (ch == '/')
                {
                    damage /= 2.0;
                }
            }

            return damage;
        }
    }
    class Daemon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public double Damage { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Health} health, {Damage:f2} damage";
        }
    }
}
