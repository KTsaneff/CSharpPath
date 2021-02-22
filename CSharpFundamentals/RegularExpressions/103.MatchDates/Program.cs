﻿using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _103.MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);
            MatchCollection collectedMatches = Regex.Matches(input, pattern);

            foreach (Match date in collectedMatches)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
