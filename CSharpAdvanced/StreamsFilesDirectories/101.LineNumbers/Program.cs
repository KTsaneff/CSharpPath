using System;
using System.Collections.Generic;
using System.IO;

namespace _101.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("../../../text.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                int lettersCount = 0;
                int symbolsCount = 0;

                string line = lines[i];
                foreach (char ch in line)
                {
                    if (char.IsLetter(ch))
                    {
                        lettersCount++;
                    }
                    else if(char.IsPunctuation(ch))
                    {
                        symbolsCount++;
                    }
                }

                string newLine = $"Line {i + 1}: {line} ({lettersCount})({symbolsCount})";
                File.AppendAllText("../../../output.txt", newLine + Environment.NewLine);
            }
        }
    }
}
