using System;
using System.Collections.Generic;
using System.Linq;

namespace _303.SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int entries = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < entries; i++)
            {
                string[] newEntry = Console.ReadLine().Split();
                string model = newEntry[0];
                int fuelAmount = int.Parse(newEntry[1]);
                double consumption = double.Parse(newEntry[2]);

                Car car = new Car(model, fuelAmount, consumption);
                cars.Add(car);
            }

            string[] newTrip;
            while ((newTrip = Console.ReadLine().Split())[0] != "End")
            {
                string model = newTrip[1];
                double distance = double.Parse(newTrip[2]);

                Car currCar = cars.Where(x => x.Model == model).ToList().First();
                currCar.CheckIfTheFuelIsEnough(distance);
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TraveledDistance}");
            }
        }
    }

    class Car
    {
        public Car()
        {

        }
        public Car(string model, int fuelAmount, double consumption)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.Consumption = consumption;
            this.TraveledDistance = 0;
        }
        public string Model { get ; set ; }
        public double FuelAmount { get ; set; }
        public double Consumption { get ;  set ; }
        public double TraveledDistance { get ; set ; }

        public void CheckIfTheFuelIsEnough(double distance)
        {
            double totalConsumption = distance * Consumption;

            if (FuelAmount >= totalConsumption)
            {
                FuelAmount -= totalConsumption;
                TraveledDistance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
