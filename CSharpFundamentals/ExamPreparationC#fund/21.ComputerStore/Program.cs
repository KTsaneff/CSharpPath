using System;

namespace _21.ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;
            double currPrice;
            double netPrice = 0;
            double VAT = 1.2;
            double specialDiscount = 0.9;

            while ((command = Console.ReadLine()) != "special" && command != "regular")
            {
                currPrice = double.Parse(command);

                if (currPrice < 0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }

                netPrice += currPrice;
            }

            double totalPrice = netPrice * VAT;

            if (totalPrice == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                if (command == "special")
                {
                    totalPrice *= specialDiscount;
                    Console.WriteLine($"Congratulations you've just bought a new computer!{Environment.NewLine}" +
                                      $"Price without taxes: {netPrice:f2}${Environment.NewLine}" +
                                      $"Taxes: {(totalPrice/specialDiscount - netPrice):f2}${Environment.NewLine}" +
                                      $"-----------{Environment.NewLine}" +
                                      $"Total price: {totalPrice:f2}$");
                }
                else if (command == "regular")
                {
                    Console.WriteLine($"Congratulations you've just bought a new computer!{Environment.NewLine}" +
                                     $"Price without taxes: {netPrice:f2}${Environment.NewLine}" +
                                     $"Taxes: {(totalPrice - netPrice):f2}${Environment.NewLine}" +
                                     $"-----------{Environment.NewLine}" +
                                     $"Total price: {totalPrice:f2}$");
                }
            }
        }
    }
}
