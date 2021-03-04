using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _100.EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "../../../text.txt";
            string pattern = @"[-,.!?]";

            using (StreamReader reader = new StreamReader(filePath))
            {
                using (StreamWriter writer = new StreamWriter("output.txt"))
                {
                    int counter = 0;

                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        if (counter++ % 2 == 0)
                        {
                            string replacedLine = Regex.Replace(line, pattern, "@");
                            string[] words = replacedLine.Split();

                            writer.WriteLine(string.Join(" ", words.Reverse()));
                            Console.WriteLine(string.Join(" ", words.Reverse()));
                        }

                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
