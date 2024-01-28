using System;
using System.Security.Cryptography.X509Certificates;
using System.Linq;

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

        string condition = Console.ReadLine(); // "younger"(<) or "older"(>=)
        int ageThreshold = int.Parse(Console.ReadLine()); // age threshold - integer\
        string outputFormat = Console.ReadLine(); // format - "name", "age" or "name age"\

        Func<Person, bool> filter = p => p.Age > 0;
        if (condition == "younger")
        { 
            filter = p => p.Age < ageThreshold;
        }
        else if (condition == "older")
        {
            filter = p => p.Age >= ageThreshold;
        }

        var filteredPeople = people.Where(filter).ToList();

        foreach (Person person in people)
        {
            Console.WriteLine($"{person.Name} -> {person.Age}");
        }
    }
}