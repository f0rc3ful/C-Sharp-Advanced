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
        List<Person> people = ReadPeople(); 
        string condition = Console.ReadLine(); //•	Condition - "younger"(<) or "older"(>=)
        int ageThreshold = int.Parse(Console.ReadLine()); //•	Age threshold -integer\
        string format = Console.ReadLine(); //•	Format - "name", "age" or "name age"\
        if (condition == "older")
        {
            people = people.Where(x => x.Age >= ageThreshold).ToList();
        }
        else if (condition == "younger")
        {
            people = people.Where(x => x.Age < ageThreshold).ToList();
        }

        foreach (Person person in people)
        {
            if (format == "age")
            {
                Console.WriteLine(person.Age);
            }
            else if (format == "name")
            {
                Console.WriteLine(person.Name);
            }
            else if (format.Length == 2)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }

    }

    static void ReadPeople()
    { 
    
    }
}