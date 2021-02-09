using System;
using System.Linq;

namespace _109.PalindromeInt
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input != "END")
                {
                    bool isPalindrome = ValidatePalindrome(input);
                    string value = string.Empty;

                    if (isPalindrome)
                    {
                        value = "true";
                    }
                    else
                    {
                        value = "false";
                    }

                    Console.WriteLine(value);
                }
                else
                {
                    break;
                }
            }
            
        }

        private static bool ValidatePalindrome(string input)
        {
            char[] toText = input.ToCharArray();
            char[] revText = new char[toText.Length];

            for (int i = 0; i < toText.Length; i++)
            {
                for (int j = revText.Length - (i+1); j >= 0; j--)
                {
                    revText[j] = toText[i];
                    break;
                }
            }

            if (string.Join("",toText) == string.Join("",revText))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
