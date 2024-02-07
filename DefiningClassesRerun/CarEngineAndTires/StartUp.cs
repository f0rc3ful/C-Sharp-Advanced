using CarManufacturer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            List<Tire[]> tiresList = new List<Tire[]>();
            string input;
            while ((input = Console.ReadLine()) != "No more tires")
            {
                string[] inputArr = input.Split(" ");
                var tires = new Tire[4];
                tires[0] = new Tire(int.Parse(inputArr[0]), double.Parse(inputArr[1]));
                tires[1] = new Tire(int.Parse(inputArr[2]), double.Parse(inputArr[3]));
                tires[2] = new Tire(int.Parse(inputArr[4]), double.Parse(inputArr[5]));
                tires[3] = new Tire(int.Parse(inputArr[6]), double.Parse(inputArr[7]));
                tiresList.Add(tires);
            }

            List<Engine> enginesList = new List<Engine>();
            while ((input = Console.ReadLine()) != "Engines done")
            {
                string[] inputArr = input.Split(" ");
                int horsePower = int.Parse(inputArr[0]);
                double cubicCapacity = double.Parse(inputArr[1]);
                Engine engine = new Engine(horsePower, cubicCapacity);
                enginesList.Add(engine);
            }

            List<Car> carsList = new List<Car>();
            while ((input = Console.ReadLine()) != "Show special")
            {
                string[] inputArr = input.Split(" ");
                string make = inputArr[0];
                string model = inputArr[1];
                int year = int.Parse(inputArr[2]);
                double fuelQuantity = double.Parse(inputArr[3]);
                double fuelConsumption = double.Parse(inputArr[4]);
                int engineIndex = int.Parse(inputArr[5]);
                int tiresIndex = int.Parse(inputArr[6]);
                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, enginesList[engineIndex], tiresList[tiresIndex]);
                carsList.Add(car);
            }

            carsList = carsList
                .Where(car => car.Year >= 2017 && car.Engine.HorsePower > 330 && car.Tires.Sum(tire => tire.Pressure) >= 9 && car.Tires.Sum(tire => tire.Pressure) <= 10)
                .ToList();

            foreach (Car car in carsList)
            {
                car.Drive(20);
                Console.WriteLine($"Make: {car.Make}");
                Console.WriteLine($"Model: {car.Model}");
                Console.WriteLine($"Year: {car.Year}");
                Console.WriteLine($"HorsePowers: {car.Engine.HorsePower}");
                Console.WriteLine($"FuelQuantity: {car.FuelQuantity}");
            }
        }
    }
}