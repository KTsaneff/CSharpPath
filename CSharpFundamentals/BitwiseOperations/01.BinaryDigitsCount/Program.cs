using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BinaryDigitsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int digit = int.Parse(Console.ReadLine());
            int outputSum = 0;

            int numberToBinary = ConvertDecimalToBinary(number);
            string binaryToText = numberToBinary.ToString();

            for (int i = 0; i < binaryToText.Length; i++)
            {
                int temp = int.Parse(binaryToText[i].ToString());
                if (temp == digit)
                {
                    outputSum++;
                }
            }
            

            Console.WriteLine(outputSum);
        }

        public static int ConvertDecimalToBinary(int number)
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
