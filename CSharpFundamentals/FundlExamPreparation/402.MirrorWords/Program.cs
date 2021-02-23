using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _402.MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> saveList = new List<string>();

            string pattern = @"([@|#])(?<firstWord>[A-Za-z]{3,})(\1)(\1)(?<secWord>[A-Za-z]{3,})(\1)";

            MatchCollection matches = Regex.Matches(input, pattern);
            foreach (Match match in matches)
            {
                string firstWord = match.Groups["firstWord"].ToString();
                string secondWord = match.Groups["secWord"].ToString();

                char[] check = secondWord.ToCharArray();
                check = check.Reverse().ToArray();
                string tempWord = string.Join("", check);

                if (firstWord == tempWord)
                {
                    string toAdd = firstWord + " <=> " + secondWord;
                    saveList.Add(toAdd);
                }
            }

            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine($"No mirror words!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");

                if (saveList.Count == 0)
                {
                    Console.WriteLine("No mirror words!");
                }
                else
                {
                    Console.WriteLine($"The mirror words are:");
                    Console.Write($"{string.Join(", ", saveList)}");
                }
            }
        }
    }
}
;