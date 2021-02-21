using System;
using System.Linq;
using System.Text;

namespace _005.DigitsLettersOthres
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] inputArr = input.ToCharArray();

            string digits = string.Empty;
            string letters = string.Empty;
            string symbols = string.Empty;

            foreach (var sign in inputArr)
            {
                if (char.IsDigit(sign))
                {
                    digits += sign;
                }
                else if (char.IsLetter(sign))
                {
                    letters += sign;
                }
                else
                {
                    symbols += sign;
                }
            }

            if (digits.Length > 0)
            {
                Console.WriteLine(digits);
            }
            if (letters.Length > 0)
            {
                Console.WriteLine(letters);
            }
            if (symbols.Length > 0)
            {
                Console.WriteLine(symbols);
            }
        }
    }
}
