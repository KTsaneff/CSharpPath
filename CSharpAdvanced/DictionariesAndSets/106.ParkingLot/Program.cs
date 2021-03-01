using System;
using System.Collections.Generic;

namespace _106.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> carsEntered = new HashSet<string>();

            string[] newOperation = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);
            while (newOperation[0] != "END")
            {
                string direction = newOperation[0];
                string registration = newOperation[1];

                if (direction == "IN")
                {
                    carsEntered.Add(registration);
                }
                else if (direction == "OUT")
                {
                    carsEntered.Remove(registration);
                }

                newOperation = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);
            }

            if (carsEntered.Count > 0)
            {
                foreach (var car in carsEntered)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
