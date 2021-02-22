using System;
using System.Text.RegularExpressions;

namespace _206.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string mailPattern = @"(^|(?<=\s))(([a-zA-Z0-9]+)([\.\-_]?)([A-Za-z0-9]+)(@)([a-zA-Z]+([\.\-][A-Za-z]+)+))(\b|(?=\s))";



            Regex regex = new Regex(mailPattern);
            MatchCollection matches = regex.Matches(text);

            if (regex.IsMatch(text))
            {
                foreach (Match match in matches)
                {
                    Console.WriteLine(match.Value);
                }
            }
        }
    }
}
