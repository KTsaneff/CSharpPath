using System;

namespace TheatrePromo
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayType = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());
            string output = "";

            if (age >= 0 && age <= 18)
            {
                switch (dayType)
                {
                    case "Weekday":
                        output += "12$";
                        break;
                    case "Weekend":
                        output += "15$";
                        break;
                    case "Holiday":
                        output += "5$";
                        break;
                }
            }
            if (age > 18 && age <= 64)
            {
                switch (dayType)
                {
                    case "Weekday":
                        output += "18$";
                        break;
                    case "Weekend":
                        output += "20$";
                        break;
                    case "Holiday":
                        output += "12$";
                        break;
                }
            }

            if (age > 64 && age <= 122)
            {
                switch (dayType)
                {
                    case "Weekday":
                        output += "12$";
                        break;
                    case "Weekend":
                        output += "15$";
                        break;
                    case "Holiday":
                        output += "10$";
                        break;
                }
            }
            else if (age < 0 || age >122)
            {
                output = "Error!";
            }
            Console.WriteLine(output);
        }
    }
}
