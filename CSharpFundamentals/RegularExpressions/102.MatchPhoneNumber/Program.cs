using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _102.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\+359)([\s-])([2])(\2)(\d{3})(\2)(\d{4})\b";
            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();
            MatchCollection phoneMatches = Regex.Matches(input, pattern);

            string[] phoneNumbers = phoneMatches.Cast<Match>().Select(x => x.Value.Trim()).ToArray();
            Console.WriteLine(string.Join(", ", phoneNumbers));
        }
    }
}
