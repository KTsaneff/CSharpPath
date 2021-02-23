using System;
using System.Linq;

namespace _401.SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string concealedMessage = Console.ReadLine();

            string[] instructions;
            while ((instructions = Console.ReadLine().Split(":|:"))[0] != "Reveal")
            {
                string command = instructions[0];

                if (command == "InsertSpace")
                {
                    int index = int.Parse(instructions[1]);
                    concealedMessage = concealedMessage.Insert(index, " ");
                    Console.WriteLine(concealedMessage);
                    continue;
                }
                if (command == "Reverse")
                {
                    string substring = instructions[1];

                    if (concealedMessage.Contains(substring))
                    {
                        int removeIndex = concealedMessage.IndexOf(substring);
                        concealedMessage = concealedMessage.Remove(removeIndex, substring.Length);
                        char[] temp = substring.ToCharArray();
                        temp = temp.Reverse().ToArray();
                        substring = string.Join("", temp);

                        concealedMessage = concealedMessage + substring;
                        Console.WriteLine(concealedMessage);
                    }
                    else
                    {
                        Console.WriteLine("error");
                        continue;
                    }
                }
                if (command == "ChangeAll")
                {
                    string substring = instructions[1];
                    string replacement = instructions[2];

                    concealedMessage = concealedMessage.Replace(substring, replacement);
                    Console.WriteLine(concealedMessage);
                    continue;
                }
            }

            Console.WriteLine($"You have a new text message: {concealedMessage}");
        }
    }
}
