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
            Car car1 = new Car();
            Car car2 = new Car("Hyundai", "Getz", 2005);
            Car car3 = new Car("Kia", "K7", 2023, 200, 8);

            Console.WriteLine(car1.WhoAmI());
            Console.WriteLine(car2.WhoAmI());
            Console.WriteLine(car3.WhoAmI());
        }
    }
}