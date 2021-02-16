using System;
using System.Collections.Generic;

namespace _303.TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charCollection = Console.ReadLine().ToCharArray();
            List<int> digits = new List<int>();
            List<char> symbols = new List<char>();

            foreach (char element in charCollection)
            {
                if (element >= 48 && element <= 57)
                {
                    digits.Add(int.Parse(element.ToString()));
                }
                else
                {
                    symbols.Add(element);
                }
            }

            List<int> takeList = new List<int>(digits.Count / 2);
            List<int> skipList = new List<int>(digits.Count / 2);

            for (int i = 0; i < digits.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(digits[i]);
                }
                else
                {
                    skipList.Add(digits[i]);
                }
            }

            int symbolPosition = 0;
            string output = string.Empty;

            for (int i = 0; i < takeList.Count; i++)
            {
                for (int j = 0; j < takeList[i]; j++)
                {
                    if (symbolPosition == symbols.Count)
                    {
                        break;
                    }
                    output += symbols[symbolPosition].ToString();
                    symbolPosition++;
                }
                for (int k = 0; k < skipList[i]; k++)
                {
                    if (symbolPosition == symbols.Count)
                    {
                        break;
                    }
                    symbolPosition++;
                }
            }

            Console.WriteLine(output);
        }
    }
}
