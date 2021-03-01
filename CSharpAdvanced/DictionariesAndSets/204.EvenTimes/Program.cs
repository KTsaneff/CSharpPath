using System;
using System.Collections.Generic;
using System.Linq;

namespace _204.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            Dictionary<int, int> numbers = new Dictionary<int, int>();

            for (int i = 0; i < lines; i++)
            {
                int newElement = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(newElement))
                {
                    numbers.Add(newElement, 0);
                }
                numbers[newElement]++;
            }

            KeyValuePair<int, int> kvp = numbers.First(kvp => kvp.Value % 2 == 0);
            Console.WriteLine(kvp.Key);
        }
    }
}
