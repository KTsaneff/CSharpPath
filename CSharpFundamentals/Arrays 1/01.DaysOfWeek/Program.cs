using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayNum = int.Parse(Console.ReadLine());

            string[] dayName = new string[]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
            };

            if (dayNum >= 1 && dayNum <= 7)
            {
                Console.WriteLine(dayName[dayNum - 1]);
            }
            else
            {
                Console.WriteLine($"Invalid day!");
            }
        }
    }
}
