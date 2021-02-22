using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace _302.RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();
            string groupsPattern = @"[\D]+[0-9]+"; //seperates to groups
            string numPattern = @"[\d]+"; //selects the seperating numbers
            string textPattern = @"[\D]+";//groupsymbols wothout numbers

            MatchCollection wordsWithCounts = Regex.Matches(input, groupsPattern);
            StringBuilder output = new StringBuilder();

            foreach (Match group in wordsWithCounts)
            {
                Match repeatCount = Regex.Match(group.ToString(), numPattern);
                Match textOnly = Regex.Match(group.ToString(), textPattern);

                int repetitions = int.Parse(repeatCount.Value);
                for (int i = 0; i < repetitions; i++)
                {
                    output.Append(textOnly.ToString());
                }
            }

            int uniqueSymbols = output.ToString().Distinct().Count();

            Console.WriteLine($"Unique symbols used: {uniqueSymbols}");
            Console.WriteLine(output.ToString());
        }
    }
}
