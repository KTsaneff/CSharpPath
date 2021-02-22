using System;
using System.Text.RegularExpressions;

namespace _101.MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";
            Regex regex = new Regex(pattern);

            
            var matches = regex.Matches(text);

            Console.WriteLine(string.Join(' ', matches));
        }
    }
}
