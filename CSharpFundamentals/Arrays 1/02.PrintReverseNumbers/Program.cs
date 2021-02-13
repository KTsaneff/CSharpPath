using System;
using System.Linq;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int[] arr = new int[lines];

            for (int i = 0; i < lines; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(string.Join(" ", arr.Reverse()));
        }
    }
}
