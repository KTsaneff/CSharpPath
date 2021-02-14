using System;
using System.Linq;

namespace _104.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray();

            int[] revFirstRow = new int[arr.Length / 4];
            int[] secRow = new int[arr.Length / 2];
            int[] revThirdRow = new int[arr.Length / 4];
            int firstRowCount = 0;
            int secRowCount = 0;
            int thirdRowCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i >= 0 && i < arr.Length / 4)
                {
                    revFirstRow[firstRowCount] = arr[i];
                    firstRowCount++;
                }
                if (i >= arr.Length / 4 && i < (arr.Length / 4) * 3)
                {
                    secRow[secRowCount] = arr[i];
                    secRowCount++;
                }
                if (i >= (arr.Length / 4) * 3 && i < arr.Length)
                {
                    revThirdRow[thirdRowCount] = arr[i];
                    thirdRowCount++;
                }
            }
         

            int[] firstRow = new int[arr.Length / 2];

            for (int j = 0; j < firstRow.Length; j++)
            {
                    if (j < firstRow.Length/2)
                    {
                        firstRow[j] = revFirstRow[firstRowCount-1];
                        firstRowCount--;
                    }
                    else
                    {
                        firstRow[j] = revThirdRow[thirdRowCount-1];
                        thirdRowCount--;
                    }
            }

                int[] finalArr = new int[arr.Length / 2];

                for (int k = 0; k < finalArr.Length; k++)
                {
                    finalArr[k] = firstRow[k] + secRow[k];
                }

                Console.WriteLine(string.Join(" ",finalArr));
        }
    }
}
