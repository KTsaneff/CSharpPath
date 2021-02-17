using System;
using System.Collections.Generic;

namespace _02.BitAtPos1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int numberToBinery = ConvertDecimalToBinary(number);
            string binaryToText = numberToBinery.ToString();

            int output = int.Parse(binaryToText[binaryToText.Length - 2].ToString());

            Console.WriteLine(output);
        }

        private static int ConvertDecimalToBinary(int number)
        {
            string numberToText = number.ToString();
            List<string> result = new List<string>(numberToText.Length);

            while (number > 0)
            {
                int currElement = number % 2;
                result.Add(currElement.ToString());
                number = number / 2;
            }

            result.Reverse();
            string resultToText = string.Join("", result);
            int numberToBinary = int.Parse(resultToText);
            return numberToBinary;
        }
    }
}
