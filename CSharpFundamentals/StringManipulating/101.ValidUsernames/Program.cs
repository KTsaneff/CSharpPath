using System;
using System.Linq;

namespace _101.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = Console.ReadLine().Split(", ");

            foreach (var username in userNames)
            {
                if (ContainsOnlyAllowedSymbols(username))
                {
                    Console.WriteLine(username);
                }
            }
        }

        private static bool ContainsOnlyAllowedSymbols(string username)
        {
            return username.Length >= 3 && username.Length <= 16
                && username.All(c => char.IsLetterOrDigit(c))
                || username.Contains("-") || username.Contains("_");
        }
    }
}
