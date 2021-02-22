using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _001.Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<day>(?:[1-3]?[0-9])|(?:3[01]))-(?<month>[A-Z][a-z]{2})-(?<year>[0-9]{4})";
            string whitespace = @"\s+";

            var regex = new Regex(whitespace);
            string text = "1      4  3     1    6  4 3  5 6    7";

            int[] arr = Regex.Split(text, whitespace)
                .Select(int.Parse)
                .ToArray() ;

            Console.WriteLine(text);
        }
    }
}
