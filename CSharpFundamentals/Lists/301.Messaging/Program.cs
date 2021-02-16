using System;
using System.Collections.Generic;
using System.Linq;

namespace _301.Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> enigma = Console.ReadLine()
                                      .Split()
                                      .Select(int.Parse)
                                      .ToList();

            string code = Console.ReadLine();
            char[] elements = code.ToCharArray();
            List<char> characters = elements.ToList();
            string message = string.Empty;

            for (int i = 0; i < enigma.Count; i++)
            {
                int sumOfDigits = 0;

                while (enigma[i] != 0)
                {
                    sumOfDigits += enigma[i] % 10;
                    enigma[i] = enigma[i] / 10;
                }

                for (int j = 0; j <= sumOfDigits; j++)
                {
                    if (sumOfDigits >= characters.Count)
                    {
                        sumOfDigits -= characters.Count;
                        j--;
                        continue;
                    }

                    if (j == sumOfDigits)
                    {
                        message += characters[j].ToString();
                        characters.RemoveAt(j);

                    }
                }
            }

            Console.WriteLine(message);
        }
    }
}
