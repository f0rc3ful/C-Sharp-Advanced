using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Dictionary<string, decimal>> supermarkets = new Dictionary<string, Dictionary<string, decimal>>();
        string input;

        while ((input = Console.ReadLine()) != "Revision")
        {
            string[] command = input.Split(", ");
            string store = command[0];
            string product = command[1];
            decimal price = decimal.Parse(command[2]);
            if (!supermarkets.ContainsKey(store))
            { 
                supermarkets.Add(store, new Dictionary<string, decimal>());
            }
            supermarkets[store].Add(product, price);
        }

        supermarkets = supermarkets.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

        foreach (var (supermarket, products) in supermarkets)
        {
            Console.WriteLine($"{supermarket}->");
            foreach (var product in products)
            {
                Console.WriteLine($"Product: {product.Key}, Price: {product.Value:F2}");
            }
        }
    }
}