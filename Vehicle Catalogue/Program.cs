using System;
using System.Collections.Generic;
using System.Linq;

namespace Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalogue catalogue = new Catalogue();

            string inputCommand = Console.ReadLine();

            while (inputCommand != "end")
            {
                string[] tokans = inputCommand.Split("/");
                string type = tokans[0];

                switch (type)
                {
                    case "Car":
                        Car car = new Car
                        {
                           Brand= tokans[1],
                           Model= tokans[2],
                           HorsePower= int.Parse(tokans[3])
                        };
                        catalogue.Cars.Add(car);
                        break;

                    case "Truck":
                        Truck track = new Truck
                        {
                            Brand = tokans[1],
                            Model = tokans[2],
                            Weight = int.Parse(tokans[3])
                        };
                        catalogue.Trucks.Add(track);
                        break;
                }
                inputCommand = Console.ReadLine();
            }
            if (catalogue.Cars.Count > 0)
            {
                List<Car> orderedCars = catalogue.Cars.OrderBy(c => c.Brand).ToList();
                Console.WriteLine("Cars:");

                foreach (Car car in orderedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalogue.Trucks.Count > 0)
            {
                List<Truck> orderedTrack = catalogue.Trucks.OrderBy(c => c.Brand).ToList();
                Console.WriteLine("Trucks:");

                foreach (Truck track in orderedTrack)
                {
                    Console.WriteLine($"{track.Brand}: {track.Model} - {track.Weight}kg");
                }
            }
        }
    }
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
    class Car
    {
      
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
    class Catalogue
    {
        public Catalogue()
        {
            this.Cars = new List<Car>();
            this.Trucks = new List<Truck>();
        }
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
}
