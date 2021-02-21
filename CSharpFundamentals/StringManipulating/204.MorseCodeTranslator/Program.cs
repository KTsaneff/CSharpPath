using System;
using System.Collections.Generic;
using System.Text;

namespace _204.MorseCodeTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> morseValues = new Dictionary<string, string>();
            {
                morseValues.Add(".-", "A");
                morseValues.Add("-...", "B");
                morseValues.Add("-.-.", "C");
                morseValues.Add("-..", "D");
                morseValues.Add(".", "E");
                morseValues.Add("..-.", "F");
                morseValues.Add("--.", "G");
                morseValues.Add("....", "H");
                morseValues.Add("..", "I");
                morseValues.Add(".---", "J");
                morseValues.Add("-.-", "K");
                morseValues.Add(".-..", "L");
                morseValues.Add("--", "M");
                morseValues.Add("-.", "N");
                morseValues.Add("---", "O");
                morseValues.Add(".--.", "P");
                morseValues.Add("--.-", "Q");
                morseValues.Add(".-.", "R");
                morseValues.Add("...", "S");
                morseValues.Add("-", "T");
                morseValues.Add("..-", "U");
                morseValues.Add("...-", "V");
                morseValues.Add(".--", "W");
                morseValues.Add("-..-", "X");
                morseValues.Add("-.--", "Y");
                morseValues.Add("--..", "Z");


            }

            string[] morseInput = Console.ReadLine().Split();
            StringBuilder sb = new StringBuilder();

            foreach (var letter in morseInput)
            {
                if (letter == "|")
                {
                    sb.Append(" ");
                }
                else if (morseValues.ContainsKey(letter))
                {
                    sb.Append(morseValues[letter]);
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}


//string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
//string[] morseCode = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };