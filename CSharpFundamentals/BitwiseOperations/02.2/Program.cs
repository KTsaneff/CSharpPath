using System;

namespace _02._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int position =1;

            int bit = (number >> position) & 1;

            Console.WriteLine(bit);
        }
    }
}
