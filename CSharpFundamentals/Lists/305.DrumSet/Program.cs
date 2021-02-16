using System;
using System.Collections.Generic;
using System.Linq;

namespace _305.DrumSet
{
    class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());
            List<int> initialDrumSet = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> currDrumQuality = new List<int>();
            for (int i = 0; i < initialDrumSet.Count; i++)
            {
                currDrumQuality.Add(initialDrumSet[i]);
            }

            string command;

            while ((command = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int currPower = int.Parse(command);

                for (int i = 0; i < currDrumQuality.Count; i++)
                {
                    currDrumQuality[i] -= currPower;
                }

                for (int j = 0; j < currDrumQuality.Count; j++)
                {
                    if (currDrumQuality[j] <= 0)
                    {
                        if (savings > 0 && savings - Math.Abs(initialDrumSet[j]) * 3 >= 0)
                        {
                            savings -= Math.Abs(initialDrumSet[j]) * 3;
                            currDrumQuality[j] = initialDrumSet[j];
                        }
                        else
                        {
                            currDrumQuality.RemoveAt(j);
                            initialDrumSet.RemoveAt(j);
                            j--;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", currDrumQuality));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}
