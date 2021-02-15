using System;
using System.Collections.Generic;
using System.Linq;

namespace _42.ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> initialValues = Console.ReadLine().Split()
                                             .Select(int.Parse).ToList();

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArg = command.Split();
                string firstElement = cmdArg[0];

                if (firstElement == "swap")
                {
                    int index1 = int.Parse(cmdArg[1]);
                    int index2 = int.Parse(cmdArg[2]);
                    int swap = initialValues[index1];
                    initialValues[index1] = initialValues[index2];
                    initialValues[index2] = swap;
                    continue;
                }
                if (firstElement == "multiply")
                {
                    int index1 = int.Parse(cmdArg[1]);
                    int index2 = int.Parse(cmdArg[2]);
                    initialValues[index1] *= initialValues[index2];
                    continue;
                }
                if (firstElement == "decrease")
                {
                    for (int i = 0; i < initialValues.Count; i++)
                    {
                        initialValues[i] -= 1;
                        continue;
                    }
                }
            }

            Console.WriteLine(string.Join(", ", initialValues));
        }
    }
}
