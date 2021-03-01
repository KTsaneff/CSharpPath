using System;
using System.Collections.Generic;
using System.Linq;

namespace _100.CountSameValues
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            Dictionary<double, int> repetitions = new Dictionary<double, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!repetitions.ContainsKey(input[i]))
                {
                    repetitions.Add(input[i], 0);
                }
                repetitions[input[i]]++;
            }

            foreach (var repeat in repetitions)
            {
                Console.WriteLine($"{repeat.Key} - {repeat.Value} times");
            }
        }
    }
}
