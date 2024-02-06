
WriteLine<string>("text");
WriteLine<double>(5.5);
WriteLine<DateTime>(DateTime.Now);


void WriteLine<T>(T input) // T takes the value type of the input where the method is called
{
    Console.WriteLine(input);
}