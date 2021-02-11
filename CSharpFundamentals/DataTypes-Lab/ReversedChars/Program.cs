using System;

namespace ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            char input;

            string text = String.Empty;

            for (int i = 0; i < 3; i++)
            {
                input = Convert.ToChar(Console.ReadLine());
                text += input + " ";
            }

            char[] textArray = text.ToCharArray();
            string reverseIt = String.Empty;

            for (int j = textArray.Length - 1; j > -1; j--)
            {
                reverseIt += textArray[j];
            }

            Console.WriteLine(reverseIt);
        }
    }
}
