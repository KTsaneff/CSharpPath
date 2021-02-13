using System;
using System.Linq;

namespace _102.ReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            string[] arr = new string[lines];

            for (int i = 0; i < lines; i++)
            {
                arr[i] = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", arr.Reverse()));
        }
    }
}
