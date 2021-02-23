using System;
using System.Collections.Generic;
using System.Linq;

namespace _000.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> newList = new List<int> { 1, 2, 3, 4, 5, 6 };

            double avg = newList.Average();

            Console.WriteLine($"{avg:f2}");
        }
    }
}
