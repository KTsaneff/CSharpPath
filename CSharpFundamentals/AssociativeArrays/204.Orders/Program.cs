using System;
using System.Collections.Generic;

namespace _204.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> products = new Dictionary<string, int>();
            Dictionary<string, double> priceList = new Dictionary<string, double>();

            string[] newEntry;
            while ((newEntry = Console.ReadLine().Split())[0] != "buy")
            {
                string name = newEntry[0];
                double price = double.Parse(newEntry[1]);
                int quantity = int.Parse(newEntry[2]);

                if (products.ContainsKey(name))
                {
                    products[name] += quantity;
                    priceList[name] = price;
                }
                else
                {
                    products.Add(name, quantity);
                    priceList.Add(name, price);
                }
            }

            foreach (var line in products)
            {
                double currPrice = 0;
                foreach (var price in priceList)
                {
                    if (price.Key == line.Key)
                    {
                        currPrice = price.Value;
                    }
                }

                double totalPrice = currPrice * line.Value;

                Console.WriteLine($"{line.Key} -> {totalPrice:f2}");
            }
        }
    }
}
