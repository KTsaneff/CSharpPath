using System;
using System.Reflection.Metadata.Ecma335;

namespace _110.TopNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

           
            for (int i = 17; i <= input; i++)
            {
                if (MasterNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool MasterNumber(int currNum)
        {
            bool isMaster = SumIsDivBy8(currNum) &&
                            InputHoldsOneOddDigit(currNum);

            if (isMaster)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool InputHoldsOneOddDigit(int currNum)
        {
            int counter = 0;

            while (currNum != 0)
            {
                if (currNum % 2 != 0)
                {
                    counter++;
                }

                currNum = currNum / 10;
            }

            if (counter != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool SumIsDivBy8(int currNum)
        {
            int sumOfDigits = 0;
            
            while (currNum != 0)
            {
                sumOfDigits += currNum % 10;
                currNum = currNum / 10;
            }

            if (sumOfDigits % 8 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
