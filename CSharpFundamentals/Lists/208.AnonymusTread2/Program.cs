using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _208.AnonymusTread2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            string command;

            while ((command = Console.ReadLine()) != "3:1")
            {
                string[] cmdArg = command.Split().ToArray();
                string operation = cmdArg[0];

                if (operation == "merge")
                {
                    int startIndex = int.Parse(cmdArg[1]);
                    int endIndex = int.Parse(cmdArg[2]);
                    string temp = String.Empty;

                    if (startIndex < 0 && endIndex < 0 || startIndex >= input.Count && endIndex >= input.Count)
                    {
                        continue;
                    }
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex >= input.Count)
                    {
                        endIndex = input.Count - 1;
                    }

                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        temp += input[i];
                    }

                    input.RemoveRange(startIndex, (endIndex - startIndex) + 1);
                    input.Insert(startIndex, temp);

                }
                else if (operation == "divide")
                {
                    int index = int.Parse(cmdArg[1]);
                    int partitions = int.Parse(cmdArg[2]);

                    char[] currElement = input[index].ToCharArray();
                    int partLength = currElement.Length / partitions;
                    int lastElementLength = partLength + currElement.Length % partitions;

                    input.RemoveAt(index);
                    string[] tempArr = new string[partitions];
                    int arrCounter = 0;

                    for (int i = 0; i < tempArr.Length; i++)
                    {
                        string tempElement = string.Empty;
                        if (i == tempArr.Length - 1)
                        {
                            partLength = lastElementLength;
                        }
                        for (int j = 0; j < partLength; j++)
                        {
                            tempElement += currElement[arrCounter].ToString();
                            arrCounter++;
                        }

                        tempArr[i] = tempElement;
                    }


                    for (int i = 0; i < tempArr.Length; i++)
                    {
                        input.Insert(index + i, tempArr[i]);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
