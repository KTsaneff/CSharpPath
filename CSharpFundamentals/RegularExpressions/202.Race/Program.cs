using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _202.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> ranking = new Dictionary<string, int>();
            string[] listOfPeople = Console.ReadLine().Split(", ");

            foreach (var participant in listOfPeople)
            {
                ranking.Add(participant, 0);
            }

            string namePattern = @"[\W\d]";
            string numberPattern = @"[\WA-Za-z]";
            string input = Console.ReadLine();

            while (input != "end of race")
            {
                string name = Regex.Replace(input, namePattern, "");
                string distance = Regex.Replace(input, numberPattern, "");
                int sum = 0;

                foreach (char digit in distance)
                {
                    int currDigit = int.Parse(digit.ToString());
                    sum += currDigit;
                }

                if (ranking.ContainsKey(name))
                {
                    ranking[name] += sum;
                }

                input = Console.ReadLine(); 
            }

            int count = 1;
            foreach (var kvp in ranking.OrderByDescending(x => x.Value))
            {
                string text = count == 1 ? "st" : count == 2 ? "nd" : "rd";

                if (count > 3)
                {
                    return;
                }
                Console.WriteLine($"{count}{text} place: {kvp.Key}");
                count++;
            }
        }
    }
}
