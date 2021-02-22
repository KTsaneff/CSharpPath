using System;
using System.Text.RegularExpressions;

namespace _000.Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<day>(?:[1-3]?[0-9])|(?:3[01]))-(?<month>[A-Z][a-z]{2})-(?<year>[0-9]{4})";

            var regex = new Regex(pattern);
            string text = "Today is 25-Nov-2020";

            text = regex.Replace(text, "today");
            var match = regex.Match(text);

            Console.WriteLine(text);
        }
    }
}
