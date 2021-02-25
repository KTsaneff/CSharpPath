using System;

namespace PartOfAscii
{
    class Program
    {
        static void Main(string[] args)
        {
            int beginning = int.Parse(Console.ReadLine());
            int limit = int.Parse(Console.ReadLine());

            for (int i = beginning; i <= limit; i++)
            {
                Console.Write($"{Convert.ToChar(i)} ");
            }
        }
    }
}
