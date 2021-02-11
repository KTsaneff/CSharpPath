using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startYield = int.Parse(Console.ReadLine());
            int totalExtracted = 0;
            int daysCounter = 0;

            while (startYield >= 100)
            {
                totalExtracted += startYield - 26;
                startYield -= 10;
                daysCounter++;
            }

            if (totalExtracted >= 26)
            {
                totalExtracted -= 26;
            }

            Console.WriteLine(daysCounter);
            Console.WriteLine(totalExtracted);
        }
    }
}
