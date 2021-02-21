using System;

namespace _202.AsciiSumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] chars = new char[2];
            int sum = 0;

            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = Console.ReadLine()[0];
            }

            string input = Console.ReadLine();

            int start = chars[0];
            int end = chars[1];
            if (start > end)
            {
                start = chars[1];
                end = chars[0];
            }

            foreach (char symbol in input)
            {
                if (symbol > start && symbol < end)
                {
                    sum += symbol;
                }
            }

            Console.WriteLine($"{sum}");
        }
    }
}
