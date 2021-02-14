using System;

namespace _102.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int[] arr = new int[1]{1};

            for (int i = 1; i <= lines; i++)
            {
                Console.WriteLine(string.Join(" ", arr));

                int[] tempArr = new int[i + 2];
                tempArr[0] = 0;
                for (int j = 1; j < tempArr.Length-1; j++)
                {
                    tempArr[j] = arr[j - 1];
                }
                tempArr[tempArr.Length - 1] = 0;

                int[] newArr = new int[tempArr.Length - 1];
                
                for (int k = 0; k < newArr.Length; k++)
                {
                    newArr[k] = tempArr[k] + tempArr[k + 1];
                }

                arr = newArr;
            }
        }
    }
}
