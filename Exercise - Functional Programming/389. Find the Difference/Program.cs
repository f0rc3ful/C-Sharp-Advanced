using System;

class Program
{
    static void Main(string[] args)
    { 
        string s = Console.ReadLine();
        string t = Console.ReadLine();
        Console.WriteLine(FindTheDifference(s,t));
    }
    static char FindTheDifference(string s, string t)
    {
        List<char> list = t.ToList();
        int counter = 0;
        while (list.Count > 1)
        {
            if (list.Contains(s[counter]))
            {
                list.Remove(s[counter]);
            }
            counter++;
        }
        return char.Parse(string.Join("", list));
    }
}