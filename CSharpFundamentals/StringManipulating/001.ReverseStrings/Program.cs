using System;
using System.Collections.Generic;
using System.Linq;

namespace _001.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputArr = new List<string>();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                inputArr.Add(input);
            }

            foreach (var word in inputArr)
            {
                char[] tempArr = word.ToCharArray(0, word.Length);
                Array.Reverse(tempArr);

                Console.WriteLine($"{word} = {string.Join("", tempArr)}");
            }
        }
    }
}
