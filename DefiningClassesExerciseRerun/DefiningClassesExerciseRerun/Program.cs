using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06SpeedRacing
{
    class Program   
    {
        static void Main()
        { 
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Car> carsList = new Dictionary<string, Car>();
            for (int i = 0; i < n; i++)
            {
                string[] inputArr = Console.ReadLine().Split(" ");
                string model = inputArr[0];
                double fuelAmount = double.Parse(inputArr[1]);
                double fuelConsumptionFor1km = double.Parse(inputArr[2]);
                Car car = new Car(model, fuelAmount, fuelConsumptionFor1km);
                carsList.Add(model, car);
            }

            string input;
            while ((input = Console.ReadLine()) != "End")
            { 
                string[] inputArr = input.Split(" ");
                string model = inputArr[1];
                double distance = double.Parse(inputArr[2]);
                carsList[model].DriveCheck(distance);
            }

            foreach (var car in carsList)
            {
                Console.WriteLine($"{car.Key} {car.Value.FuelAmount:F2} {car.Value.TravelledDistance}");
            }
        }
    }
}
