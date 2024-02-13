class Program
{
    static void Main(string[] args)
    {
        Queue<int> tools = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
        Stack<int> substances = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));
        List<int> challenges = new List<int>(Console.ReadLine().Split().Select(int.Parse).ToList());

        int challenge;
        while (tools.Count > 0 && substances.Count > 0 && challenges.Count > 0)
        {
            for (int i = 0; i < challenges.Count; i++)
            {
                int tool = tools.Dequeue();
                int substance = substances.Pop();
                int product = tool * substance;
                if (challenges.Contains(product))
                {
                    challenges.Remove(product);
                }
                else
                {
                    tools.Enqueue(tool + 1);
                    if (substance - 1 > 0)
                    {
                        substances.Push(substance - 1);
                    }    
                    

                }
            }
        }

        if (challenges.Count == 0)
        {
            Console.WriteLine($"Harry found an ostracon, which is dated to the 6th century BCE.");
            if (tools.Count > 0)
            {
                QueuePrinter(tools);
            }
            if (substances.Count > 0)
            {
                StackPrinter(substances);
            }
        }
        else
        {
            Console.WriteLine("Harry is lost in the temple. Oblivion awaits him.");
            if (tools.Count > 0)
            {
                QueuePrinter(tools);
            }
            if (substances.Count > 0)
            {
                StackPrinter(substances);
            }
            if (challenges.Count > 0)
            {
                ListPrinter(challenges);
            }
        }

    }

    static void QueuePrinter(Queue<int> q) // toolss
    {
        Console.WriteLine($"Tools: {string.Join(", ", q)}");
    }

    static void StackPrinter(Stack<int> stack) // substances
    {
        Console.WriteLine($"Substances: {string.Join(", ", stack)}");
    }

    static void ListPrinter(List<int> list) // tools
    {
        Console.WriteLine($"Challenges: {string.Join(", ", list)}");
    }
}