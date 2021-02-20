using System;
using System.Collections.Generic;

namespace _201.CountChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] letters = input.ToCharArray();

            Dictionary<string, int> counterBook = new Dictionary<string, int>();

            foreach (var letter in letters)
            {
                if (letter != ' ')
                {
                    string temp = letter.ToString();

                    if (counterBook.ContainsKey(temp))
                    {
                        counterBook[temp]++;
                    }
                    else
                    {
                        counterBook.Add(temp, 1);
                    }
                }
            }

            foreach (var counter in counterBook)
            {
                Console.WriteLine($"{counter.Key} -> {counter.Value}");
            }
        }
    }
}
