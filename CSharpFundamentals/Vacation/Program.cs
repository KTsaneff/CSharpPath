using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string weekDay = Console.ReadLine();
            double price = 0;
            double discount = 0;

            if (type == "Students" && count < 30)
            {
                discount += 1;
                switch (weekDay)
                {
                    case "Friday":
                        price += 8.45;
                        break;
                    case "Saturday":
                        price += 9.80;
                        break;
                    case "Sunday":
                        price += 10.46;
                        break;
                }
            }
            if (type == "Students" && count >= 30)
            {
                discount += 0.85;
                switch (weekDay)
                {
                    case "Friday":
                        price += 8.45;
                        break;
                    case "Saturday":
                        price += 9.80;
                        break;
                    case "Sunday":
                        price += 10.46;
                        break;
                }
            }
            if (type == "Business" && count < 100)
            {
                discount += 1;
                switch (weekDay)
                {
                    case "Friday":
                        price += 10.90;
                        break;
                    case "Saturday":
                        price += 15.60;
                        break;
                    case "Sunday":
                        price += 16;
                        break;
                }
            }
            if (type == "Business" && count >= 100)
            {
                discount += 1;
                count -= 10;
                switch (weekDay)
                {
                    case "Friday":
                        price += 10.90;
                        break;
                    case "Saturday":
                        price += 15.60;
                        break;
                    case "Sunday":
                        price += 16;
                        break;
                }
            }
            if (type == "Regular" && (count < 10 || count > 20))
            {
                discount += 1;
                switch (weekDay)
                {
                    case "Friday":
                        price += 15;
                        break;
                    case "Saturday":
                        price += 20;
                        break;
                    case "Sunday":
                        price += 22.50;
                        break;
                }
            }
            if (type == "Regular" && count >=10 && count <= 20)
            {
                discount += 0.95;
                switch (weekDay)
                {
                    case "Friday":
                        price += 15;
                        break;
                    case "Saturday":
                        price += 20;
                        break;
                    case "Sunday":
                        price += 22.50;
                        break;
                }
            }

            Console.WriteLine($"Total price: {count*price*discount:f2}");
        }
    }
}
