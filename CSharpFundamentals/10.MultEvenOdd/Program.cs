using System;
using System.Linq;

namespace _10.MultEvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int output = GetMultipleOfEvenOandOdds(input);

            Console.WriteLine(output);
        }

        private static int GetMultipleOfEvenOandOdds(int sums)
        {
            int sum = GetSumOfEvenDigits(sums) * GetSumOfOddDigits(sums);
            return sum;
        }

        private static int GetSumOfOddDigits(int sumOdds)
        {
            string toText = sumOdds.ToString();
            int tempSum = 0;
            int tempNum = sumOdds;

            for (int i = 0; i < toText.Length; i++)
            {
                int digit = tempNum % 10;
                if (digit % 2 !=0)
                {
                    tempSum += Math.Abs(digit);
                }

                tempNum /= 10;
            }

            return tempSum;
        }

        private static int GetSumOfEvenDigits(int sumEvens)
        {
            string toText = sumEvens.ToString();
            int tempSum = 0;
            int tempNum = sumEvens;

            for (int i = 0; i < toText.Length; i++)
            {
                int digit = tempNum % 10;
                if (digit % 2 == 0)
                {
                    tempSum += Math.Abs(digit);
                }

                tempNum /= 10;
            }

            return tempSum;
        }
    }
}
