using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SantaHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            int presentKey = int.Parse(Console.ReadLine());
            List<string> goodKids = new List<string>();

            string newKid;
            
            while((newKid = Console.ReadLine()) != "end")
            {
                newKid = new string(newKid.Select(c => (char) (c - presentKey)).ToArray());

                string pattern = @"@(?<name>[A-Za-z]+)([\^]?[^@][^-:!>]*)!(?<goodOrBad>[G|N])!";
                Match nameMatch = Regex.Match(newKid, pattern);
                string name = nameMatch.Groups["name"].Value;
                Match behaviorMatch = Regex.Match(newKid, pattern);
                string behavior = behaviorMatch.Groups["goodOrBad"].Value;

                if (behavior == "G")
                {
                    goodKids.Add(name);
                }
            }

            foreach (var kid in goodKids)
            {
                Console.WriteLine(kid);
            }
        }
    }
}
