using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.OddTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if ((arr[i] ^ arr[j]) == 0)
                    {
                        arr[i] = 0;
                        arr[j] = 0;
                        break;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    result = arr[i] ^ result;
                }
            }

            Console.WriteLine(result);
        }
    }
}
