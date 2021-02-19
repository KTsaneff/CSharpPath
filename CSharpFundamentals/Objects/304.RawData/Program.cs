using System;
using System.Collections.Generic;
using System.Linq;

namespace _304.RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int vehiclesInGarage = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            string[] newEntry ;

            for (int i = 0; i < vehiclesInGarage; i++)
            {
                newEntry = Console.ReadLine().Split();
                string model = newEntry[0];
                int engineSpeed = int.Parse(newEntry[1]);
                int enginePower = int.Parse(newEntry[2]);
                int cargoWeight = int.Parse(newEntry[3]);
                string cargoType = newEntry[4];

                Engine currEngine = new Engine(engineSpeed, enginePower);
                Cargo currCargo = new Cargo(cargoWeight, cargoType);
                Car car = new Car(model, currEngine, currCargo);

                cars.Add(car);
            }

            string printType = Console.ReadLine();
            if (printType == "fragile")
            {
                foreach (Car car in cars)
                {
                    if (car.Cargo.CargoType == printType && car.Cargo.CargoWeight < 1000)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
            else if (printType == "flamable")
            {
                foreach (Car car in cars)
                {
                    if (car.Cargo.CargoType == printType && car.Engine.EnginePower > 250)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }


        }
    }
    class Car
    {
        public Car(string model, Engine engine, Cargo cargo)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
    }
    class Engine
    {
        public Engine(int engineSpeed, int enginePower)
        {
            EngineSpeed = engineSpeed;
            EnginePower = enginePower;
        }

        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }
    }
    class Cargo
    {
        public Cargo(int cargoWeight, string cargoType)
        {
            CargoWeight = cargoWeight;
            CargoType = cargoType;
        }

        public int CargoWeight { get; set; }
        public string CargoType { get; set; }
    }
}
