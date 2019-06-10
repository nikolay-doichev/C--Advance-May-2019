using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            double distance = 20.0;
            List<Tire[]> tiresList = new List<Tire[]>();
            List<Engine> enginesList = new List<Engine>();
            List<Car> carsList = new List<Car>();

            string input = Console.ReadLine();

            while (input != "No more tires")
            {
                string[] tires = input
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Tire[] allFourTires = new Tire[4]
                {
                    new Tire(int.Parse(tires[0]), double.Parse(tires[1])),
                    new Tire(int.Parse(tires[2]), double.Parse(tires[3])),
                    new Tire(int.Parse(tires[4]), double.Parse(tires[5])),
                    new Tire(int.Parse(tires[6]), double.Parse(tires[7])),
                };

                tiresList.Add(allFourTires);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "Engines done")
            {
                string[] engines = input
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int horsepower = int.Parse(engines[0]);
                double cubicCapacity = double.Parse(engines[1]);

                Engine engine = new Engine(horsepower, cubicCapacity);

                enginesList.Add(engine);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "Show special")
            {
                string[] cars = input
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string make = cars[0];
                string model = cars[1];
                int year = int.Parse(cars[2]);
                double fuelQantity = double.Parse(cars[3]);
                double fuelConsumption = double.Parse(cars[4]);
                int engineIndex = int.Parse(cars[5]);
                int tiresIndex = int.Parse(cars[6]);

                Car car = new Car(make, model, year, fuelQantity, fuelConsumption, enginesList[engineIndex], tiresList[tiresIndex]);

                bool tirePressureBetween9and10 = car.Tires.Select(x => x.Pressure).Sum() >= 9
                    && car.Tires.Select(x => x.Pressure).Sum() <= 10;

                bool isCarSpecial = car.Year >= 2017 && car.Engine.HorsePower > 300 && tirePressureBetween9and10;

                if (isCarSpecial)
                {
                    car.Drive(distance);
                    carsList.Add(car);
                }

                input = Console.ReadLine();
            }

            foreach (var car in carsList)
            {
                Console.WriteLine($"Make: {car.Make}");
                Console.WriteLine($"Model: {car.Model}");
                Console.WriteLine($"Year: {car.Year}");
                Console.WriteLine($"HorsePowers: {car.Engine.HorsePower}");
                Console.WriteLine($"FuelQuantity: {car.FuelQuantity}");
            }
        }
    }
}   
