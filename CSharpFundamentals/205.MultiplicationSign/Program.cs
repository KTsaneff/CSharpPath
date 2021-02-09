using System;

namespace _205.MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            int counterMinus = 0;
            int counterZero = 0;

            for (int i = 0; i < 3; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] < 0)
                {
                    counterMinus++;
                }
                if (arr[i] == 0)
                {
                    counterZero++;
                }
            }

            if (counterMinus % 2 != 0 && counterZero == 0)
            {
                Console.WriteLine("negative");
            }
            if (counterZero != 0)
            {
                Console.WriteLine("zero");
            }
            if (counterZero == 0 && (counterMinus % 2 == 0 || counterMinus == 0))
            {
                Console.WriteLine("positive");
            }
        }
    }
}
