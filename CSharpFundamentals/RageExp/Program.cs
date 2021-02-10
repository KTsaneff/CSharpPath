using System;

namespace RageExp
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPr = double.Parse(Console.ReadLine());
            double mousePr = double.Parse(Console.ReadLine());
            double keybPr = double.Parse(Console.ReadLine());
            double dispPr = double.Parse(Console.ReadLine());

            int headsetCounter = 0;
            int mouseCounter = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    headsetCounter++;
                }
                if (i % 3 == 0)
                {
                    mouseCounter++;
                }
            }

            int keyboardCounter = mouseCounter / 2;
            int displayCounter = keyboardCounter / 2;
            double rageExp = headsetPr * headsetCounter + mousePr * mouseCounter + keybPr * keyboardCounter + dispPr * displayCounter;

            Console.WriteLine($"Rage expenses: {rageExp:f2} lv.");
        }
    }
}
