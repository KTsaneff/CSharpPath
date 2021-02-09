using System;

namespace _105.AddAndSubstract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondtNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int sum = Sum(firstNum, secondtNum, thirdNum);

            Console.WriteLine(sum);
        }

        private static int Sum(int firstNum, int secondNum, int thirdNum)
        {
            int sumFirstAndSecond = firstNum + secondNum;
            return Sustract(sumFirstAndSecond, thirdNum);
        }

        private static int Sustract(int sumFirstAndSecond, int thirdNum)
        {
            return sumFirstAndSecond - thirdNum;
        }
    }
}
