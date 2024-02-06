namespace SpeedRacing
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string model = input[0];
                Car car = new Car(model, double.Parse(input[1]), double.Parse(input[2]));
                cars.Add(car);
            }

            string input2;
            while ((input2 = Console.ReadLine()) != "End")
            {
                string[] command = input2.Split(" ");
                string model = command[1];
                double kmsTravelled = double.Parse(command[2]);
                Car.DriveCheck(car.model, kmsTravelled);
            }

            
        }
    }
}