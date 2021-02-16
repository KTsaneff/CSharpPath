using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _207.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split("|").ToList();

            StringBuilder output = new StringBuilder();

            for (int i = input.Count - 1; i >= 0; i--)
            {
                List<string> temp = input[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

                for (int j = 0; j < temp.Count; j++)
                {
                    output.Append(temp[j]).Append(" ");
                }
            }

            Console.WriteLine(output);
        }
    }
}
