using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleWaitnig = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());

            int runCounter = 0;

            if (peopleWaitnig < elevatorCapacity)
            {
                runCounter ++;
            }
            else
            {
                while (peopleWaitnig > 0)
                {
                    runCounter++;
                    peopleWaitnig -= elevatorCapacity;
                }
            }

            Console.WriteLine(runCounter);
        }

    }
}
