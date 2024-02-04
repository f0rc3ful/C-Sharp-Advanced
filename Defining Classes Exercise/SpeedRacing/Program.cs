namespace SpeedRacing
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                Car car = new Car(input[0], double.Parse(input[1]), double.Parse(input[2]));
            }

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] 
            }
        }
    }
}