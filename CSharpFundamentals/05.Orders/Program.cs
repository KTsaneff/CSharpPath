using System;

namespace _05.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            PrintOutCheck(product, quantity);
        }

        private static void PrintOutCheck(string product, int quantity)
        {
            string[] products = new string[] { "coffee", "water", "coke", "snacks" };
            double[] prices = new double[] { 1.50, 1.00, 1.40, 2.00 };
            double check = 0;

            for (int i = 0; i < products.Length; i++)
            {
                if (product == products[i])
                {
                    check += quantity * prices[i];
                    break;
                }
            }

            Console.WriteLine($"{check:f2}");
        }
    }
}
