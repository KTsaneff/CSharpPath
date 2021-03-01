using System;
using System.Collections.Generic;

namespace _205.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();
            var characters = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!characters.ContainsKey(input[i]))
                {
                    characters.Add(input[i], 0);
                }
                characters[input[i]]++;
            }

            foreach (var character in characters)
            {
                Console.WriteLine($"{character.Key}: {character.Value} time/s");
            }
        }
    }
}
