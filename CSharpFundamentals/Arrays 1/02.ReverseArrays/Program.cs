using System;
using System.Linq;

namespace _02.ReverseArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(string.Join(' ', arr.Reverse()));
        }
    }
}
