using System;
using System.Linq;

namespace _07.MaxSeqOfEqElts
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();
            int counter = 0;
            int countMax = 0;
            string maxSeq = string.Empty;
            int tempInt = arr[0];
            string tempArr = String.Empty;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == tempInt)
                {
                    counter++;
                    tempArr += arr[i] + " ";
                    continue;
                }
                else
                {
                    if (countMax < counter)
                    {
                        countMax = counter;
                        maxSeq = tempArr;
                    }

                    tempArr = string.Empty;
                    tempInt = arr[i];
                    tempArr = arr[i] + " ";
                    counter = 1;
                }
            }

            if (countMax == 0)
            {
                Console.WriteLine(tempArr);
            }
            else
            {
                Console.WriteLine(maxSeq);
            }
            
        }
    }
}
