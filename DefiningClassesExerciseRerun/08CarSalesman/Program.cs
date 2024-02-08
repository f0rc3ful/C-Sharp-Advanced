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
            Dictionary<string, Engine> enginesDict = new Dictionary<string, Engine>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] inputArr = Console.ReadLine().Split(" ");
                string model = inputArr[0];
                int power = int.Parse(inputArr[1]);
                int displacement;
                string efficiency;
                Engine engine = new Engine(model, power);
                if (inputArr.Length == 3)
                {
                    displacement = int.Parse(inputArr[2]);
                    engine = new Engine(model, power, displacement);
                }
                else if (inputArr.Length == 4)
                {
                    displacement = int.Parse(inputArr[2]);
                    efficiency = inputArr[3];
                    engine = new Engine(model, power, displacement, efficiency);
                }
                enginesDict.Add(model, engine);
            }

            List<Car> carsList = new List<Car>();
            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                string[] inputArr = Console.ReadLine().Split(" ");
                string carModel = inputArr[0];
                string engineModel = inputArr[1];
                int weight;
                string color;
                Car car = new Car(carModel, enginesDict[engineModel]);
                if (inputArr.Length == 3)
                {
                    color = inputArr[2];
                    car = new Car(carModel, enginesDict[engineModel], color);
                }
                else if (inputArr.Length == 4)
                {
                    weight = int.Parse(inputArr[2]);
                    color = inputArr[3];
                    car = new Car(carModel, enginesDict[engineModel], weight, color);
                }
                carsList.Add(car);
            }
            foreach (var car in carsList)
            {
                // Console.WriteLine($"Weight: {(car.Weight.HasValue ? car.Weight.ToString() : "n/a")}");
                Console.WriteLine(car.Model + ":");
                Console.WriteLine("  " + car.Engine.Model + ":");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                Console.WriteLine($"    Displacement: {(car.Engine.Displacement == 0 ? car.Engine.Displacement : "n/a")}"); // int
                Console.WriteLine($"    Efficiency: {(car.Engine.Efficiency != null ? car.Engine.Efficiency : "n/a")}"); // string
                Console.WriteLine($"  Weight: {(car.Weight == 0 ? car.Weight : "n")}");
                Console.WriteLine($"  Color: {(car.Color != null ? car.Color : "n/a")}");
            }
        }
    }
}
