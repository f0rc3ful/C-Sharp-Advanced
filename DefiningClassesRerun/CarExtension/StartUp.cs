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
            Car car = new Car();
            car.Make = "Hyundai";
            car.Model = "Getz";
            car.Year = 2005;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(car.Make);
            sb.AppendLine(car.Model);
            sb.AppendLine(car.Year.ToString());

            Console.WriteLine(sb);
        }
    }
}