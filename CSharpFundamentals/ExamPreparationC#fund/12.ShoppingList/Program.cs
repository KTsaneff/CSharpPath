using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shopingList = Console.ReadLine().Split("!").ToList();

            string command;

            while ((command = Console.ReadLine()) != "Go Shopping!")
            {
                string[] cmdArg = command.Split().ToArray();
                string action = cmdArg[0];
                string product = cmdArg[1];

                if (action == "Urgent")
                {
                    if (shopingList.Contains(product))
                    {
                        continue;
                    }
                    else
                    {
                        shopingList.Insert(0, product);
                    }
                }
                if (action == "Unnecessary")
                {
                    if (shopingList.Contains(product))
                    {
                        shopingList.Remove(product);
                    }
                    else
                    {
                        continue;
                    }
                }
                if (action == "Correct")
                {
                    string newProduct = cmdArg[2];

                    if (shopingList.Contains(product))
                    {
                        int tempIndex = shopingList.IndexOf(product);
                        shopingList.Insert(tempIndex, newProduct);
                        shopingList.Remove(product);
                    }
                }
                if (action == "Rearrange")
                {
                    if (shopingList.Contains(product))
                    {
                        string tempProduct = product;
                        shopingList.Remove(product);
                        shopingList.Add(tempProduct);
                    }
                    else
                    {
                        continue;
                    }
                    
                }
            }

            Console.WriteLine(string.Join(", ", shopingList));
        }
    }
}
