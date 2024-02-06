CustomGeneric<string> genericString = new CustomGeneric<string>();
genericString.AddElement("helou");
genericString.Name = "string";

CustomGeneric<DateTime> genericDateTime = new CustomGeneric<DateTime>();
genericDateTime.Name = DateTime.Now;
genericDateTime.AddElement(DateTime.Today);

public class CustomGeneric<T>
{
    public T x;
    public T Name { get; set; }

    public List<T> list = new List<T>();

    public void AddElement(T element)
    { 
        list.Add(element);
        Console.WriteLine(element);
    }
}