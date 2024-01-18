Dictionary<string, double> fruits = new Dictionary<string, double>();

fruits["watermelon"] = 1.4;
fruits["audemars"] = 1.4;
fruits["banana"] = 2.5;
fruits["kiwi"] = 3.7;
fruits["apple"] = 1.4;

fruits = fruits
    .OrderBy(x => x.Value)
    .ThenBy(x => x.Key) // for instances where the first characteristic will be equal
    .ToDictionary(x => x.Key, x => x.Value);

Console.WriteLine(string.Join("\n", fruits.ToList()));