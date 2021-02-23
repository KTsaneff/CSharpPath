using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _302.DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([=|\/])([A-Z][A-Za-z]{2,})(\1)";
            string clearDestination = @"([A-Za-z]+)";
            int totalPoints = 0;

            MatchCollection matches = Regex.Matches(input, pattern);
            List<string> finalMatches = new List<string>();

            foreach (Match match in matches)
            {
                Match currMatch = Regex.Match(match.ToString(), clearDestination);
                finalMatches.Add(currMatch.ToString());
            }

            foreach (var destionation in finalMatches)
            {
                totalPoints += destionation.Length;
            }

            Console.WriteLine($"Destinations: {string.Join(", ", finalMatches)}");
            Console.WriteLine($"Travel Points: {totalPoints}");
        }
    }
}
