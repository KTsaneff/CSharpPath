using System;
using System.Collections.Generic;
using System.Linq;

namespace _108.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] newEntry;
            Catalogue newCatalogue = new Catalogue();

            while ((newEntry = Console.ReadLine().Split("/"))[0] != "end")
            {
                string vehicleType = newEntry[0];
                string brand = newEntry[1];
                string model = newEntry[2];
                int constant = int.Parse(newEntry[3]);

                if (vehicleType == "Car")
                {
                    Car newCarEntry = new Car(brand, model, constant);
                    newCatalogue.Cars.Add(newCarEntry);
                    
                }
                else if (vehicleType == "Truck")
                {
                    Truck newTruckEntry = new Truck(brand, model, constant);
                    newCatalogue.Trucks.Add(newTruckEntry);
                }
            }

            if (newCatalogue.Cars.Count >0)
            {
                Console.WriteLine("Cars:");
                foreach (var car in newCatalogue.Cars.OrderBy(x => x.CarBrand))
                {
                    Console.WriteLine($"{car.CarBrand}: {car.CarModel} - {car.HorsePower}hp");
                }
            }
            if (newCatalogue.Trucks.Count >0)
            {
                Console.WriteLine("Trucks:");
                foreach (var truck in newCatalogue.Trucks.OrderBy(x => x.TruckBrand))
                {
                    Console.WriteLine($"{truck.TruckBrand}: {truck.TruckModel} - {truck.Weight}kg");
                }
            }
        }
    }

    class Truck
    {
        public Truck(string truckBrand, string truckModel, int weight)
        {
            TruckBrand = truckBrand;
            TruckModel = truckModel;
            Weight = weight;
        }

        public string TruckBrand { get; set; }
        public string TruckModel { get; set; }
        public int Weight { get; set; }
    }

    class Car
    {
        public Car(string carBrand, string carModel, int horsePower)
        {
            CarBrand = carBrand;
            CarModel = carModel;
            HorsePower = horsePower;
        }

        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public int HorsePower { get; set; }

    }
    class Catalogue
    {
        public Catalogue()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }

        public List<Car> Cars { get; }
        public List<Truck> Trucks { get; }
    }
}
