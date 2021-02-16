using System;
using System.Collections.Generic;
using System.Linq;

namespace _103.MerginLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                            .Select(int.Parse)
                                            .ToList();

            List<int> secondList = Console.ReadLine()
                                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                            .Select(int.Parse)
                                            .ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < Math.Min(firstList.Count, secondList.Count); i++)
            {
                result.Add(firstList[i]);
                result.Add(secondList[i]);
            }

            for (int i = Math.Min(firstList.Count, secondList.Count); i < Math.Max(firstList.Count, secondList.Count); i++)
            {
                if (i >= firstList.Count)
                {
                    result.Add(secondList[i]);
                }
                else
                {
                    result.Add(firstList[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
