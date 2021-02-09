using System;

namespace _106.MiddleChar
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PrintMiddleCharacter(input);
        }

        private static void PrintMiddleCharacter(string input)
        {
            char[] stringToChar = input.ToCharArray();
            while (stringToChar.Length > 2)
            {
                char[] tempText = new char[stringToChar.Length - 2];

                for (int i = 0; i < tempText.Length; i++)
                {
                    tempText[i] = stringToChar[i + 1];
                }

                stringToChar = tempText;
            }

            Console.WriteLine(string.Join("", stringToChar));
        }
    }
}
