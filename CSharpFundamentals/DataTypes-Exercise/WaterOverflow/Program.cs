using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int pourCounter = int.Parse(Console.ReadLine());
            int tankCapacity = 255;
            int litresInTank = 0;

            while (pourCounter > 0)
            {
                int litres = int.Parse(Console.ReadLine());
                tankCapacity -= litres;

                if (tankCapacity < 0)
                {
                    Console.WriteLine($"Insufficient capacity!");
                    tankCapacity += litres;
                }
                else
                {
                    litresInTank += litres;
                }

                pourCounter--;
            }

            Console.WriteLine(litresInTank);
        }
    }
}
