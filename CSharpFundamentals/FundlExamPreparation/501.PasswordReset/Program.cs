using System;

namespace _501.PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] instructions;

            while ((instructions = Console.ReadLine().Split())[0] != "Done")
            {
                string command = instructions[0];

                if (command == "TakeOdd")
                {
                    string temp = string.Empty;
                    for (int i = 1; i < input.Length; i+=2)
                    {
                        
                        temp += input[i];
                    }

                    input = temp;
                    Console.WriteLine(input);
                    continue;
                }
                if (command == "Cut")
                {
                    int index = int.Parse(instructions[1]);
                    int cutLength = int.Parse(instructions[2]);

                    input = input.Remove(index, cutLength);
                    Console.WriteLine(input);
                    continue;
                }
                if (command == "Substitute")
                {
                    string subString = instructions[1];
                    string substitude = instructions[2];

                    if (input.Contains(subString))
                    {
                        input = input.Replace(subString, substitude);
                        Console.WriteLine(input);
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
            }

            Console.WriteLine($"Your password is: {input}");
        }
    }
}
