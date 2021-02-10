using System;
using System.Net.Http.Headers;

namespace StrongNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string factorial = input.ToString();
            char[] digit = factorial.ToCharArray();
            int sum = 0;
            int multiplication = 1;

            for (int i = digit.Length - 1; i > -1; i--)
            {
                int num = (int)Char.GetNumericValue(digit[i]);
                for (int j = num; j > 0; j--)
                {
                    multiplication *= j;
                }
                sum += multiplication;
                multiplication = 1;
            }

            if (sum == input)
            {
                Console.WriteLine($"yes");
            }
            else
            {
                Console.WriteLine($"no");
            }
        }
    }
}
