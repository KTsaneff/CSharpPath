using System;

namespace _101.TheImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string instructions;
            while ((instructions = Console.ReadLine()) != "Decode")
            {
                string[] cmdArg = instructions.Split("|");
                string action = cmdArg[0];

                if (action == "Move")
                {
                    int firstN = int.Parse(cmdArg[1]);

                    string firstPart = input.Substring(0, firstN); //0_1_2_3_4_
                    string secPart = input.Substring(firstN, input.Length - firstN);

                    input = string.Empty;
                    input = secPart + firstPart;
                }

                if (action == "Insert")
                {
                    int index = int.Parse(cmdArg[1]);
                    string value = cmdArg[2];

                    input = input.Insert(index, value);
                }

                if (action == "ChangeAll")
                {
                    string substring = cmdArg[1];
                    string newText = cmdArg[2];

                    input = input.Replace(substring, newText);
                }
            }

            Console.WriteLine($"The decrypted message is: {input}");
        }
    }
}
