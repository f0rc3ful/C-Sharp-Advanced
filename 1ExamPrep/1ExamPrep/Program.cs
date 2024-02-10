class Program
{
    static void Main(string[] args)
    { 
    /// 1st line is fuel saved in a stack - we take the topmost index
    /// 2nd line is unexpected consumption in a queue - we take the first element
    /// 3rd line is a queue and we go through the elements 1 by 1
        int[] input1 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int[] input2 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int[] input3 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        Stack<int> fuel = new Stack<int>();
        Queue<int> unexpected = new Queue<int>();
        Queue<int> needed = new Queue<int>();
        for (int i = 0; i < input1.Length; i ++)
        {
            fuel.Push(input1[i]);
            unexpected.Enqueue(input2[i]);
            needed.Enqueue(input3[i]);
        }

        int counter = 0;
        for (int i = 0; i < input1.Length; i++)
        {
            int fuelLeft = fuel.Pop() - unexpected.Dequeue();
            if (fuelLeft - needed.Dequeue() >= 0)
            {
                counter++;
                Console.WriteLine($"John has reached: Altitude {counter}");
            }
            else
            {
                Console.WriteLine($"John did not reach: Altitude {counter + 1}");
                break;
            }
        }
        if (counter == input1.Length)
        {
            Console.WriteLine("John has reached all the altitudes and managed to reach the top!");
        }
        else if (counter > 0)
        {
            Console.WriteLine("John failed to reach the top.");
            Console.Write("Reached altitudes: ");
            for (int i = 0; i < counter; i++)
            {
                if (!(i + 1 == counter))
                {
                    Console.Write($"Altitude {i + 1}, ");
                }
                else
                {
                    Console.Write($"Altitude {i + 1}");
                }
            }
        }
        else if (counter == 0)
        {
            Console.WriteLine($"John failed to reach the top.");
            Console.WriteLine($"John didn't reach any altitude.");
        }
    }
}