using System;
using System.Collections.Generic;
using System.Linq;

namespace _103.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();

            string[] newEntry = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            while (newEntry[0] != "Revision")
            {
                string currShop = newEntry[0];
                string currProduct = newEntry[1];
                double price = double.Parse(newEntry[2]);

                if (!shops.ContainsKey(currShop))
                {
                    shops.Add(currShop, new Dictionary<string, double>());
                }

                shops[currShop].Add(currProduct, price);

                newEntry = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var shop in shops.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
