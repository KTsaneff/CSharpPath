using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _107.StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            string[] listEntry;

            while ((listEntry = Console.ReadLine().Split())[0] != "end")
            {
                string serialNumber = listEntry[0];
                string item = listEntry[1];
                int quantity = int.Parse(listEntry[2]);
                double itemPrice = double.Parse(listEntry[3]);

                boxes.Add(new Box(serialNumber, new Item(item, itemPrice), quantity));
            }

            boxes.OrderByDescending(p => p.PriceBox).ToList().ForEach(p => Console.WriteLine(p));
        }
    }
    class Box
    {
        public Box(string serialNumber, Item item, int quantity)
        {
            SerialNumber = serialNumber;
            Item = item;
            Quantity = quantity;
        }

        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public double PriceBox { get { return Item.ItemPrice * Quantity; } }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(SerialNumber);
            sb.AppendLine($"-- {Item.Name} - ${Item.ItemPrice:f2}: {Quantity}");
            sb.AppendLine($"-- ${PriceBox:f2}");
            return sb.ToString();
        }
    }
    class Item
    {
        public Item(string name, double price)
        {
            Name = name;
            ItemPrice = price;
        }

        public string Name { get; set; }
        public double ItemPrice { get; set; }
    }
}
