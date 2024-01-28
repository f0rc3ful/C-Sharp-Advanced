using System;
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;  
    }

} 
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<Person> people = new List<Person>(); 
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(", ");
            string name = input[0];
            int age = int.Parse(input[1]);
            Person person = new Person(name, age);
            people.Add(person);
        }
        Console.ReadLine();
        string condition = Console.ReadLine(); //•	Condition - "younger"(<) or "older"(>=)
        int ageThreshold = int.Parse(Console.ReadLine()); //•	Age threshold -integer\
        string format = Console.ReadLine(); //•	Format - "name", "age" or "name age"\
        
    }
}