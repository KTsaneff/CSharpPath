using System;

namespace _601.ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawKey = Console.ReadLine();
            string[] instructions;

            while ((instructions = Console.ReadLine().Split(">>>"))[0] != "Generate")
            {
                string command = instructions[0];

                if (command == "Contains")
                {
                    string substring = instructions[1];

                    if (rawKey.Contains(substring))
                    {
                        Console.WriteLine($"{rawKey} contains {substring}");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                        continue;
                    }
                }
                if (command == "Flip")
                {
                    string upperLower = instructions[1];
                    int startIndex = int.Parse(instructions[2]);
                    int endindex = int.Parse(instructions[3]);

                    if (endindex < startIndex)
                    {
                        int temp = startIndex;
                        startIndex = endindex;
                        endindex = temp;
                    }

                    if (upperLower == "Upper")
                    {
                        string change = rawKey.Substring(startIndex, endindex - startIndex).ToUpper();
                        string replace = rawKey.Substring(startIndex, endindex - startIndex);

                        rawKey = rawKey.Replace(replace, change);
                        Console.WriteLine(rawKey);
                        continue;
                    }
                    else
                    {
                        string change = rawKey.Substring(startIndex, endindex - startIndex).ToLower();
                        string replace = rawKey.Substring(startIndex, endindex - startIndex);

                        rawKey = rawKey.Replace(replace, change);
                        Console.WriteLine(rawKey);
                        continue;
                    }
                }
                if (command == "Slice")
                {
                    int startIndex = int.Parse(instructions[1]);
                    int endindex = int.Parse(instructions[2]);

                    if (endindex < startIndex)
                    {
                        int temp = startIndex;
                        startIndex = endindex;
                        endindex = temp;
                    }

                    rawKey = rawKey.Remove(startIndex, endindex - startIndex);
                    Console.WriteLine(rawKey);
                    continue;
                }
            }

            Console.WriteLine($"Your activation key is: {rawKey}");
        }
    }
}
