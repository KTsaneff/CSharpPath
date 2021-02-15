using System;
using System.Collections.Generic;
using System.Linq;

namespace _33.Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(", ").ToList();
            string command;

            while ((command = Console.ReadLine()) != "Craft!" )
            {
                string[] cmdArg = command.Split(" - ");
                string action = cmdArg[0];
                string currItem = cmdArg[1];

                if (action == "Collect")
                {
                    if (items.Contains(currItem))
                    {
                        continue;
                    }
                    else
                    {
                        items.Add(currItem);
                        continue;
                    }
                }
                if (action == "Drop")
                {
                    if (items.Contains(currItem))
                    {
                        items.Remove(currItem);
                        continue;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (action == "Combine Items")
                {
                    string[] tempArr = currItem.Split(":");
                    if (items.Contains(tempArr[0]))
                    {
                        int index = items.IndexOf(tempArr[0].ToString());
                        items.Insert(index + 1, tempArr[1].ToString());
                        continue;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (action == "Renew")
                {
                    if (items.Contains(currItem))
                    {
                        string change = currItem;
                        items.Remove(currItem);
                        items.Add(change);
                        continue;
                    }
                }
            }

            Console.WriteLine(string.Join(", ", items));
        }
    }
}
