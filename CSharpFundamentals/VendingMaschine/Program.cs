using System;

namespace VendingMaschine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double sum = 0;

            while (command != "Start")
            {
                double coinsValue = double.Parse(command)*1.00;

                if (coinsValue == 0.1 || coinsValue == 0.2 || coinsValue == 0.5 || coinsValue == 1.0 || coinsValue == 2.0)
                {
                    sum += coinsValue;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coinsValue}");
                }
                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                switch (command)
                {
                    case "Nuts":
                        sum -= 2.0;
                        if (sum<0)
                        {
                            sum += 2.0;
                            Console.WriteLine($"Sorry, not enough money");
                        }
                        else
                        {
                            Console.WriteLine($"Purchased nuts");
                        }
                        break;
                    case "Water":
                        sum -= 0.7;
                        if (sum < 0)
                        {
                            sum += 0.7;
                            Console.WriteLine($"Sorry, not enough money");
                        }
                        else
                        {
                            Console.WriteLine($"Purchased water");
                        }
                        break;
                    case "Crisps":
                        sum -= 1.5;
                        if (sum < 0)
                        {
                            sum += 1.5;
                            Console.WriteLine($"Sorry, not enough money");
                        }
                        else
                        {
                            Console.WriteLine($"Purchased crisps");
                        }
                        break;
                    case "Soda":
                        sum -= 0.8;
                        if (sum < 0)
                        {
                            sum += 0.8;
                            Console.WriteLine($"Sorry, not enough money");
                        }
                        else
                        {
                            Console.WriteLine($"Purchased soda");
                        }
                        break;
                    case "Coke":
                        sum -= 1.0;
                        if (sum < 0)
                        {
                            sum += 1.0;
                            Console.WriteLine($"Sorry, not enough money");
                        }
                        else
                        {
                            Console.WriteLine($"Purchased coke");
                        }
                        break;

                    default:
                        Console.WriteLine($"Invalid product");
                        break;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}
