using System;
using System.Dynamic;
using System.Linq;

namespace _02.FromLeftToRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                int leftNumSum = 0;
                string leftNum = String.Empty;
                int rightNumSum = 0;
                string rightNum = String.Empty;
                string input = Console.ReadLine();
                bool writeFirstNum = true;

                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j].ToString() == "-")
                    {
                        if (writeFirstNum)
                        {
                            leftNum += input[j].ToString();
                        }
                        if (!writeFirstNum)
                        {
                            rightNum += input[j].ToString();
                        }
                        continue;
                    }
                    if (input[j].ToString() == " ")
                    {
                        writeFirstNum = false;
                        continue;
                    }

                    if (writeFirstNum)
                    {
                        leftNum += input[j];
                        int addValue = int.Parse(input[j].ToString());
                        leftNumSum += addValue;
                    }
                    else
                    {
                        rightNum += input[j];
                        int addValue = int.Parse(input[j].ToString());
                        rightNumSum += addValue;
                    }
                }

                long compareFirstNum = long.Parse(leftNum);
                long compareSecNum = long.Parse(rightNum);

                if (compareFirstNum > compareSecNum)
                {
                    Console.WriteLine(leftNumSum);
                }
                else
                {
                    Console.WriteLine(rightNumSum);
                }
                
            }
        }
    }
}
