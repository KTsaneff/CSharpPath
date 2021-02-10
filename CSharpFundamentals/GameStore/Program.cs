using System;

namespace GameStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            bool enoughMoney = true;
            double totalSp = balance;

            while (operation != "Game Time" && enoughMoney)
            {
                switch (operation)
                {
                    case "OutFall 4":
                        balance -= 39.99;
                        if (balance < 0)
                        {
                            Console.WriteLine($"Too Expensive");
                            balance += 39.99;
                        }
                        else
                        {
                            Console.WriteLine($"Bought {operation}");
                        }
                        break;
                    case "CS: OG":
                        balance -= 15.99;
                        if (balance < 0)
                        {
                            Console.WriteLine($"Too Expensive");
                            balance += 15.99;
                        }
                        else
                        {
                            Console.WriteLine($"Bought {operation}");
                        }
                        break;
                    case "Zplinter Zell":
                        balance -= 19.99;
                        if (balance < 0)
                        {
                            Console.WriteLine($"Too Expensive");
                            balance += 19.99;
                        }
                        else
                        {
                            Console.WriteLine($"Bought {operation}");
                        }
                        break;
                    case "Honored 2":
                        balance -= 59.99;
                        if (balance < 0)
                        {
                            Console.WriteLine($"Too Expensive");
                            balance += 59.99;
                        }
                        else
                        {
                            Console.WriteLine($"Bought {operation}");
                        }
                        break;
                    case "RoverWatch":
                        balance -= 29.99;
                        if (balance < 0)
                        {
                            Console.WriteLine($"Too Expensive");
                            balance += 29.99;
                        }
                        else
                        {
                            Console.WriteLine($"Bought {operation}");
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        balance -= 39.99;
                        if (balance < 0)
                        {
                            Console.WriteLine($"Too Expensive");
                            balance += 39.99;
                        }
                        else
                        {
                            Console.WriteLine($"Bought {operation}");
                        }
                        break;
                    default:
                        Console.WriteLine($"Not Found");
                        break;
                }

                if (balance==0)
                {
                    enoughMoney = false;
                    break;
                }

                operation = Console.ReadLine();
            }

            if (!enoughMoney)
            {
                Console.WriteLine($"Out of money!");
            }
            else
            {
                Console.WriteLine($"Total spent: ${totalSp - balance:f2}. Remaining: ${balance:f2}");
            }
        }
    }
}
