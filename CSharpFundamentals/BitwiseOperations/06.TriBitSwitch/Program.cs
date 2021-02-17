using System;

namespace _06.TriBitSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());

            int mask = 7 << position;

            input = input ^ mask;

            Console.WriteLine(input);
        }
    }
}
