using System;
using System.Numerics;

namespace SnowBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            int ballsNum = int.Parse(Console.ReadLine());

            BigInteger maxValue = 0;
            int maxQuality = 0;
            int maxShow = 0;
            int maxTime = 0;

            for (int i = 0; i < ballsNum; i++)
            {
                int ballShow = int.Parse(Console.ReadLine());
                int ballTime = int.Parse(Console.ReadLine());
                int ballQuality = int.Parse(Console.ReadLine());

                BigInteger ballValue = BigInteger.Pow(ballShow / ballTime, ballQuality);

                if (ballValue > maxValue)
                {
                    maxValue = ballValue;
                    maxQuality = ballQuality;
                    maxShow = ballShow;
                    maxTime = ballTime;
                }
            }

            Console.WriteLine($"{maxShow} : {maxTime} = {maxValue} ({maxQuality})");
        }
    }
}
