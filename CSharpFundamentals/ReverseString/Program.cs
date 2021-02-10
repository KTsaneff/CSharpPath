using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string toRev = "";

            char[] reverseString = input.ToCharArray();

            for (int i = reverseString.Length-1; i > -1; i--)
            {
                toRev += reverseString[i];
            }

            Console.WriteLine(toRev);
        }
    }
}
