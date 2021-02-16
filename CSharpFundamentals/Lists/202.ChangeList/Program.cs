using System;
using System.Collections.Generic;
using System.Linq;

namespace _202.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                        .Split()
                                        .Select(int.Parse)
                                        .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] cmdArg = command.Split();
                string firstCommand = cmdArg[0];
                int element = int.Parse(cmdArg[1]);

                if (firstCommand == "Delete")
                {
                    numbers.RemoveAll(x => x == element);
                }
                else if (firstCommand == "Insert")
                {
                    int index = int.Parse(cmdArg[2]);
                    numbers.Insert(index, element);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
