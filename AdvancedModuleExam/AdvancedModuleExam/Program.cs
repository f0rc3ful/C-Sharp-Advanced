class Program
{
    static void Main(string[] args)
    { 
        Stack<int> moneyStack = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));
        Queue<int> pricesQueue = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
        int foodEaten = 0;
        int change = 0;
        while (moneyStack.Count > 0 && pricesQueue.Count > 0)
        {
            int money = moneyStack.Pop() + change;
            int price = pricesQueue.Dequeue();
            change = 0;
            if (money >= price)
            {
                change = money - price;
                foodEaten++;
            }
        }
        if (foodEaten >= 4)
        {
            Console.WriteLine($"Gluttony of the day! Henry ate {foodEaten} foods.");
        }
        else if (foodEaten > 0)
        {
            if (foodEaten == 1)
            {
                Console.WriteLine($"Henry ate: 1 food.");
            }
            else
            {
                Console.WriteLine($"Henry ate: {foodEaten} foods.");
            }
        }
        else if (foodEaten == 0)
        {
            Console.WriteLine("Henry remained hungry. He will try next weekend again.");
        }

    }
}