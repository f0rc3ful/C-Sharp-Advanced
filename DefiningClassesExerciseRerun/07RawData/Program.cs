using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07RawData
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> carsList = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];
                double tire1Pressure = double.Parse(input[5]); // tire 1
                int tire1Age = int.Parse(input[6]);
                double tire2Pressure = double.Parse(input[7]); // tire 2
                int tire2Age = int.Parse(input[8]);
                double tire3Pressure = double.Parse(input[9]); // tire 3
                int tire3Age = int.Parse(input[10]);
                double tire4Pressure = double.Parse(input[11]);
                int tire4Age = int.Parse(input[12]);
                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoType, cargoWeight);
                Tire[] tires = new Tire[4];
                tires[0] = new Tire(tire1Age, tire1Pressure);
                tires[1] = new Tire(tire2Age, tire2Pressure);
                tires[2] = new Tire(tire3Age, tire3Pressure);
                tires[3] = new Tire(tire4Age, tire4Pressure);
                Car car = new Car(model, engine, cargo, tires);
                carsList.Add(car);
            }

            string command = Console.ReadLine(); // fragile or flammable
            if (command == "fragile")
            {
                List<Car> fragileList = carsList
                    .Where(car => car.Tires.Any(tire => tire.Pressure < 1) && car.Cargo.Type == "fragile")
                    .ToList();
                foreach (Car fragileCar in fragileList)
                {
                    Console.WriteLine(fragileCar.Model);
                }
            }
            else if (command == "flammable")
            {
                List<Car> flammableList = carsList
                    .Where(car => car.Engine.Power > 250 && car.Cargo.Type == "flammable")
                    .ToList();
                foreach (Car flammableCar in flammableList)
                {
                    Console.WriteLine(flammableCar.Model);
                }
            }
        }
    }
}
