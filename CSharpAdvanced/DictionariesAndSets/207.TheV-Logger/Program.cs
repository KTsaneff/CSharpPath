using System;
using System.Collections.Generic;
using System.Linq;

namespace _207.TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Vlogger> vloggers = new Dictionary<string, Vlogger>();
            int counter = 1;

            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (input[0] != "Statistics")
            {
                string currVlogger = input[0];

                if (!vloggers.ContainsKey(currVlogger) && input[1] != "followed")
                {
                    Vlogger newVlogger = new Vlogger(currVlogger, new HashSet<string>(), new HashSet<string>());
                    vloggers.Add(currVlogger, newVlogger);
                    input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    continue;
                }

                if (input[1] == "followed" && vloggers.ContainsKey(currVlogger) && vloggers.ContainsKey(input[2]) && vloggers[currVlogger] != vloggers[input[2]])
                {
                    string secVlogger = input[2];
                    vloggers[currVlogger].Following.Add(secVlogger);
                    vloggers[secVlogger].Followers.Add(currVlogger);
                }

                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");

            var mostFamousVlogger = vloggers.Values.OrderByDescending(f => f.Followers.Count).ThenBy(f => f.Following.Count).First();
            Console.WriteLine($"{counter}. {mostFamousVlogger.Name} : {mostFamousVlogger.Followers.Count} followers, {mostFamousVlogger.Following.Count} following");

            if (mostFamousVlogger.Followers.Count > 0)
            {
                foreach (var follower in mostFamousVlogger.Followers.OrderBy(n => n))
                {
                    Console.WriteLine($"*  {follower}");
                }
            }

            vloggers.Remove(mostFamousVlogger.Name);

            foreach (Vlogger vlogger in vloggers.Values.OrderByDescending(c => c.Followers.Count).ThenBy(c => c.Following.Count))
            {
                counter++;
                Console.WriteLine($"{counter}. {vlogger.Name} : {vlogger.Followers.Count} followers, {vlogger.Following.Count} following");
            }
        }
    }
    class Vlogger
    {
        public Vlogger(string name, HashSet<string> followers, HashSet<string> following)
        {
            Name = name;
            Followers = followers;
            Following = following;
        }

        public string Name { get; set; }
        public HashSet<string> Followers { get; set; }
        public HashSet<string> Following { get; set; }
    }
}
