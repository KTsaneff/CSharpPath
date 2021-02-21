using System;

namespace _104.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            foreach (char ch in input)
            {
                var currChar = (char)(ch + 3);
                Console.Write(currChar);
            }
        }
    }
}
