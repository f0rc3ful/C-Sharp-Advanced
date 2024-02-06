
Console.WriteLine(string.Join(", ", GenerateElements(5, 10)));
Console.WriteLine(string.Join(", ", GenerateElements("five", 10)));
Console.WriteLine(string.Join(", ", GenerateElements(DateTime.Today, 10)));

static List<T> GenerateElements<T> (T element, int n)
{
    List<T> list = new List<T>();
    for (int i = 0; i < n; i++)
    {
        list.Add(element);
    }
    return list;
}