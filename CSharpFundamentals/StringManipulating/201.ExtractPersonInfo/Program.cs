using System;
using System.Collections.Generic;

namespace _201.ExtractPersonInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            Dictionary<string, string> personalInformation = new Dictionary<string, string>();

            for (int i = 0; i < lines; i++)
            {
                string newEntry = Console.ReadLine();

                int nameStartIndex = newEntry.IndexOf('@');
                int nameEndIndex = newEntry.IndexOf('|');
                int lengthName = nameEndIndex - nameStartIndex;
                string name = newEntry.Substring(nameStartIndex +1, lengthName - 1);

                int ageStartIndex = newEntry.IndexOf('#');
                int ageEndIndex = newEntry.IndexOf('*');
                int lengthAge = ageEndIndex - ageStartIndex;
                string age = newEntry.Substring(ageStartIndex + 1, lengthAge - 1);

                personalInformation.Add(name, age);
            }

            foreach (var person in personalInformation)
            {
                Console.WriteLine($"{person.Key} is {person.Value} years old.");
            }
        }
    }
}
