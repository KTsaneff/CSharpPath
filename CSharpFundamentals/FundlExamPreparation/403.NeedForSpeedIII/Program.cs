using System;
using System.Collections.Generic;
using System.Linq;

namespace _403.NeedForSpeedIII
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxPossibleCount = int.Parse(Console.ReadLine());
            string[] carInfo;
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            for (int i = 0; i < maxPossibleCount; i++)
            {
                carInfo = Console.ReadLine().Split("|");
                string carName = carInfo[0];
                int mileage = int.Parse(carInfo[1]);
                int fuel = int.Parse(carInfo[2]);

                Car newCar = new Car(carName, mileage, fuel);
                cars.Add(carName, newCar);
            }

            string[] instructions;
            while ((instructions = Console.ReadLine().Split(" : "))[0] != "Stop")
            {
                string command = instructions[0];

                if (command == "Drive")
                {
                    string car = instructions[1];
                    int distance = int.Parse(instructions[2]);
                    int neededFuel = int.Parse(instructions[3]);

                    if (cars[car].Fuel - neededFuel < 0)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                        continue;
                    }
                    else
                    {
                        cars[car].Fuel -= neededFuel;
                        cars[car].Mileage += distance;
                        Console.WriteLine($"{car} driven for {distance} kilometers. {neededFuel} liters of fuel consumed.");
                        if (cars[car].Mileage >= 100000)
                        {
                            cars.Remove(car);
                            Console.WriteLine($"Time to sell the {car}!");
                        }
                        continue;
                    }
                }
                
                if (command == "Refuel")
                {
                    string car = instructions[1];
                    int refuel = int.Parse(instructions[2]);

                    if (cars[car].Fuel + refuel > 75)
                    {
                        refuel = 75 - cars[car].Fuel;
                        cars[car].Fuel = 75;
                    }
                    else
                    {
                        cars[car].Fuel += refuel;
                    }

                    Console.WriteLine($"{car} refueled with {refuel} liters");
                    continue;
                }

                if (command == "Revert")
                {
                    string car = instructions[1];
                    int kilometres = int.Parse(instructions[2]);

                    if (cars[car].Mileage - kilometres < 10000)
                    {
                        cars[car].Mileage = 10000;
                    }
                    else
                    {
                        cars[car].Mileage -= kilometres;
                        Console.WriteLine($"{car} mileage decreased by {kilometres} kilometers");
                    }
                }
            }

            foreach (var car in cars.Values.OrderByDescending(x => x.Mileage).ThenBy(x => x.CarName))
            {
                Console.WriteLine($"{car.CarName} -> Mileage: {car.Mileage} kms, Fuel in the tank: {car.Fuel} lt.");
            }
        }
    }

    class Car
    {
        public Car(string carName, int mileage, int fuel)
        {
            CarName = carName;
            Mileage = mileage;
            Fuel = fuel;
        }

        public string CarName { get; set; }
        public int Mileage { get; set; }
        public int Fuel { get; set; }
    }
}
