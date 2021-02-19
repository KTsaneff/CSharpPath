using System;
using System.Collections.Generic;
using System.Linq;

namespace _305.ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> allClients = new List<Person>();
            List<Product> allProducts = new List<Product>();

            try
            {
                string[] clientsList = Console.ReadLine().Split(new[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);
                string[] productsAvailable = Console.ReadLine().Split(new[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < clientsList.Length; i += 2)
                {
                    string name = clientsList[i];
                    double money = double.Parse(clientsList[i + 1]);

                    Person person = new Person(name, money);
                    allClients.Add(person);
                }

                for (int i = 0; i < productsAvailable.Length; i+=2)
                {
                    string name = productsAvailable[i];
                    double price = double.Parse(productsAvailable[i + 1]);

                    Product product = new Product(name, price);
                    allProducts.Add(product);
                }

                string purchase;
                while ((purchase = Console.ReadLine()) != "END")
                {
                    string[] newPurchase = purchase.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    Person currBuyer = allClients.FirstOrDefault(x => x.Name == newPurchase[0]);
                    Product currProduct = allProducts.FirstOrDefault(p => p.Name == newPurchase[1]);

                    currBuyer.BuyProducts(currProduct);
                }

                foreach (Person client in allClients)
                {
                    Console.WriteLine(client);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
    class Person
    {
        public Person(string name, double money)
        {
            Name = name;
            Money = money;
        }

        public string Name { get; set; }
        public double Money { get; set; }
        public List<string> BagOfProducts { get; set; } = new List<string>();

        public void BuyProducts(Product product)
        {
            if (product.Cost > Money)
            {
                Console.WriteLine($"{Name} can't afford {product.Name}");
            }
            else
            {
                Console.WriteLine($"{Name} bought {product.Name}");
                Money -= product.Cost;
                BagOfProducts.Add(product.Name);
            }
        }
        public override string ToString()
        {
            string person = $"{Name} - ";

            if (BagOfProducts.Count == 0)
            {
                person += "Nothing bought";
            }
            else
            {
                person += string.Join(", ", BagOfProducts);
            }
            return person;
        }
    }
    class Product
    {
        public Product(string name, double cost)
        {
            Name = name;
            Cost = cost;
        }

        public string Name { get; set; }
        public double Cost { get; set; }
    }
}
