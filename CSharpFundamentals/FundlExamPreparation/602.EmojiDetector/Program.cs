using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _602.EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(::|\*\*)([A-Z][a-z]{2,})(\1)";
            string digitPattern = @"(\d)";

            int coolTreshold = 1;

            MatchCollection matches = Regex.Matches(input, pattern);
            MatchCollection digits = Regex.Matches(input, digitPattern);
            Dictionary<string, int> emojis = new Dictionary<string, int>();

            foreach (Match digit in digits)
            {
                int temp = int.Parse(digit.Value);
                coolTreshold *= temp;
            }

            foreach (Match match in matches)
            {
                string currEmoji = match.Value;
                string patternCoolness = @"([A-Z][a-z]+)";
                int coolSum = 0;

                Match ascii = Regex.Match(currEmoji, patternCoolness);
                foreach (Char ch in ascii.Value)
                {
                    int currChar = ch;
                    coolSum += currChar;
                }

                emojis.Add(currEmoji, coolSum);
            }

            Console.WriteLine($"Cool threshold: {coolTreshold}");
            Console.WriteLine($"{emojis.Count} emojis found in the text. The cool ones are:");

            foreach (var emoji in emojis)
            {
                if (emoji.Value >= coolTreshold)
                {
                    Console.WriteLine($"{emoji.Key}");
                }
            }
        }
    }
}
