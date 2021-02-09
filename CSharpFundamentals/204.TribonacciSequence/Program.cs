using System;

namespace _204.TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());

            int[] arr = new int[3] { 1, 1, 2 };
            int[] outputArr = new int[limit];

            for (int i = 0; i < arr.Length && i< outputArr.Length; i++)
            {
                outputArr[i] = arr[i];
            }

            if (limit > arr.Length)
            {
                for (int j = 3; j < outputArr.Length; j++)
                {
                    outputArr[j] = outputArr[j - 1] + outputArr[j - 2] + outputArr[j - 3];
                }
            }
            

            Console.WriteLine(string.Join(" ", outputArr));
        }
    }
}
