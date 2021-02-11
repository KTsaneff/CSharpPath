using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            double maxVolume = 0;
            double volume = 0;
            string biggerCap = String.Empty;

            for (int i = 0; i < counter; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                volume = Math.Pow(radius, 2) * Math.PI * height;

                if (volume > maxVolume)
                {   
                    maxVolume = volume;
                    biggerCap = model;
                }
            }

            Console.WriteLine(biggerCap);
        }
    }
}
