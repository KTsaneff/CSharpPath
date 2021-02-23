using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _102.AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([#|\|])(?<Name>[A-Za-z\s?]+)(\1)(?<Day>0[1-9]|1[0-9]|2[0-9]|3[0-1])([\/])(?<Month>0[1-9]|1[0-2])([\/])(?<Year>[0-9][0-9])(\1)(?<Calories>[0-9]?[0-9?][0-9]?[0-9])(\1)";

            MatchCollection matches = Regex.Matches(input, pattern);
            List<Food> foods = new List<Food>();

            foreach (Match match in matches)
            {
                string name = match.Groups["Name"].Value;
                int day = int.Parse(match.Groups["Day"].Value);
                int month = int.Parse(match.Groups["Month"].Value);
                int year = int.Parse(match.Groups["Year"].Value);
                int calories = int.Parse(match.Groups["Calories"].Value);

                Food newFood = new Food(name, new Date(day, month, year), calories);
                foods.Add(newFood);
            }

            int caloriesSum = foods.Sum(x => x.Calories);
            int daysToGo = caloriesSum / 2000;

            Console.WriteLine($"You have food to last you for: {daysToGo} days!");

            foreach (Food food in foods)
            {
                Console.WriteLine($"Item: {food.Name}, Best before: {food.ExpireDate}, Nutrition: {food.Calories}");
            }
        }
    }
    class Food
    {
        public Food(string name, Date expireDate, int calories)
        {
            Name = name;
            ExpireDate = expireDate;
            Calories = calories;
        }

        public string Name { get; set; }
        public Date ExpireDate { get; set; }
        public int Calories { get; set; }

    }
    class Date
    {
        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return $"{Day:d2}/{Month:d2}/{Year}";
        }
    }
}
