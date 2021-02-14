using System;
using System.Linq;

namespace _06.EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();

            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        rightSum += arr[j];
                    }
                }
                else if (i > 0 && i < arr.Length - 1)
                {
                    for (int k = 0; k < i; k++)
                    {
                        leftSum += arr[k];
                    }
                    for (int l = i + 1; l < arr.Length; l++)
                    {
                        rightSum += arr[l];
                    }
                }
                else if (i == arr.Length - 1)
                {
                    for (int m = 0; m < i; m++)
                    {
                        leftSum += arr[m];
                    }
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    break;
                }

                if (i != arr.Length - 1)
                {
                    leftSum = 0;
                    rightSum = 0;
                }
            }

            if (leftSum != rightSum)
            {
                Console.WriteLine($"no");
            }
        }
    }
}
