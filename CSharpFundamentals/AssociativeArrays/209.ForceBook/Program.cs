using System;
using System.Collections.Generic;
using System.Linq;

namespace _209.ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> teamAndParticipants = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();

            while (input != "Lumpawaroo")
            {
                string side = string.Empty;
                string user = string.Empty;

                if (input.Contains("|"))
                {
                    string[] newEntry = input.Split("|");
                    side = newEntry[0].Trim();
                    user = newEntry[1].Trim();

                    CheckAndAddSideOrUser(teamAndParticipants, side, user);
                }
                else if (input.Contains("->"))
                {
                    string[] newEntry = input.Split(new[] {"->"}, StringSplitOptions.RemoveEmptyEntries);

                    user = newEntry[0].Trim();
                    side = newEntry[1].Trim();
                   
                    if (teamAndParticipants.Values.Any(x => x.Contains(user)))
                    {
                        foreach (var differentSide in teamAndParticipants)
                        {
                            differentSide.Value.Remove(user);
                        }
                    }

                    CheckAndAddSideOrUser(teamAndParticipants, side, user);
                    
                        Console.WriteLine($"{user} joins the {side} side!");
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in teamAndParticipants.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                if (kvp.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Value.Count}");
                    foreach (var item in kvp.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"! {item}");
                    }
                }
            }
        }

        private static void CheckAndAddSideOrUser(Dictionary<string, List<string>> teamAndParticipants, string side, string user)
        {
            if (!teamAndParticipants.ContainsKey(side))
            {
                teamAndParticipants.Add(side, new List<string>());
            }

            if (!teamAndParticipants.Values.Any(x => x.Contains(user)))
            {
                teamAndParticipants[side].Add(user);
            }
        }
    }
}
