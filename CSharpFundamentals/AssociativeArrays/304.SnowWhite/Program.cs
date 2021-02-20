using System;
using System.Collections.Generic;
using System.Linq;

namespace _304.SnowWhite
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dwarfList = new Dictionary<string, int>();
            
            string input;
            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                string[] newDwarf = input.Split(" <:> ", StringSplitOptions.RemoveEmptyEntries);
                string dwarfName = newDwarf[0];
                string hatColor = newDwarf[1];
                int physicsValue = int.Parse(newDwarf[2]);

                string uniqueDwarf = dwarfName + ":" + hatColor;

                if (dwarfList.ContainsKey(uniqueDwarf) == false)
                {
                    dwarfList.Add(uniqueDwarf, physicsValue);
                }
                else
                {
                    dwarfList[uniqueDwarf] = Math.Max(physicsValue, dwarfList[uniqueDwarf]);
                }
            }

            foreach (var dwarf in dwarfList
                .OrderByDescending(x => x.Value)
                .ThenByDescending(x => dwarfList.Where(y => y.Key.Split(':')[1] == x.Key.Split(':')[1])
                .Count()))
            {
                Console.WriteLine("({0}) {1} <-> {2}", 
                    dwarf.Key.Split(':')[1], 
                    dwarf.Key.Split(':')[0], 
                    dwarf.Value);
            }
        }
    }
}
