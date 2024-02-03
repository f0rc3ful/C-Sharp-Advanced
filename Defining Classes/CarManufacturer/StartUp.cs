using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var enginesList = new List<Engine>();
            var tiresList = new List<Tire[]>();
            string inputTires;
            while ((inputTires = Console.ReadLine()) != "No more tires")
            {
                string[] inputStr = inputTires.Split(" ");
                Tire[] tires = new Tire[4]
                {
                    new Tire(int.Parse(inputStr[0]), double.Parse(inputStr[1])),
                    new Tire(int.Parse(inputStr[2]), double.Parse(inputStr[3])),
                    new Tire(int.Parse(inputStr[4]), double.Parse(inputStr[5])),
                    new Tire(int.Parse(inputStr[6]), double.Parse(inputStr[7]))
                };
                tiresList.Add(tires);
            }

            string inputEngine;
            while ((inputEngine = Console.ReadLine()) != "Engines done")
            {
                string[] inputStr = inputEngine.Split(" ");
                var engine = new Engine(int.Parse(inputStr[0]), double.Parse(inputStr[1]));
                enginesList.Add(engine);
            }

            string inputCars;
            List<Car> carsList = new List<Car>();
            while ((inputCars = Console.ReadLine()) != "Show special")
            {
                string[] inputStr = inputCars.Split(" ");
                // {make} {model} {year} {fuelQuantity} {fuelConsumption} {engineIndex} {tiresIndex}
                string make = inputStr[0];
                string model = inputStr[1];
                int year = int.Parse(inputStr[2]);
                double fuelQuantity = double.Parse(inputStr[3]);
                double fuelConsumption = double.Parse(inputStr[4]);
                int engineIndex = int.Parse(inputStr[5]);
                int tiresIndex = int.Parse(inputStr[6]);
                var car = new Car(make, model, year, fuelQuantity, fuelConsumption, enginesList[engineIndex], tiresList[tiresIndex]);
                carsList.Add(car);
            }

            foreach (var car in carsList)
            {
                car.FuelQuantity = car.FuelQuantity - 0.2 * car.FuelConsumption;
            }
            carsList = carsList
                .Where(car => car.Year >= 2017 && car.Engine.HorsePower > 330 && car.Tires.Sum(tire => tire.Pressure) >= 9 && car.Tires.Sum(tire => tire.Pressure) <= 10)
                .ToList();

            
            foreach (var car in carsList)
            {
                Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}\nHorsePowers: {car.Engine.HorsePower}\nFuelQuantity: {car.FuelQuantity}");

            }

        }
    }
}
