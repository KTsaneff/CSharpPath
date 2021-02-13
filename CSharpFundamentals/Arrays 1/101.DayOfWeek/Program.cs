using System;

namespace _101.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dayArr = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int input = int.Parse(Console.ReadLine());

            if (input>=1 && input <=7)
            {
                Console.WriteLine(dayArr[input-1]);
            }
            else
            {
                Console.WriteLine($"Invalid day!");
            }
        }
    }
}
