using System;
using System.Collections.Generic;
using System.Linq;

namespace _102.OddOccurances
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArr = Console.ReadLine()
                            .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            foreach (var element in inputArr)
            {
                string lowerCasedElement = element.ToLower();
                if (dictionary.ContainsKey(lowerCasedElement))
                {
                    dictionary[lowerCasedElement]++;
                }
                else
                {
                    dictionary.Add(lowerCasedElement, 1);
                }
            }

            foreach (var word in dictionary)
            {
                if (word.Value % 2 != 0)
                {
                    Console.Write(word.Key + " ");
                }
            }
        }
    }
}
