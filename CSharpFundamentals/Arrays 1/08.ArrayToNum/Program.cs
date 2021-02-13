using System;
using System.Linq;

namespace _08.ArrayToNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            while (arr.Length > 1)
            {
                int[] midArr = new int[arr.Length - 1];
                for (int i = 0; i < midArr.Length; i++)
                {
                    midArr[i] = arr[i] + arr[i + 1];
                }

                arr = midArr;
            }

            Console.WriteLine(arr[0]);
        }
    }
}
