using System;

namespace TriplesLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                char a = (char)(i+96);
                for (int j = 1; j <= count; j++)
                {
                    char b = (char)(j+96);
                    for (int k = 1; k <= count; k++)
                    {
                        char c = (char)(k+96);
                        Console.WriteLine($"{a}{b}{c}");
                    }
                }
            }
        }
    }
}
