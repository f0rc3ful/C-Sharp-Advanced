using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<string> strings = new List<string> { "abc", "abcd", "abcde", "abcdef", "abcdefg", };
        List<string> defaultWhereMethod = strings.Where(x => x.Length >= 5).ToList(); //predicate
        Console.WriteLine(string.Join(" ", defaultWhereMethod));
        List<string> customWhereMethod = Where2(strings, x => x.Length >= 5); // predicate
        Console.WriteLine(string.Join(" ", customWhereMethod));
    }

    static List<string> Where2(List<string> list, Func<string, bool> predicate) // predicate = func returning bool
    { 
        List<string> result = new List<string>();
        foreach (string s in list) 
        {
            if (predicate(s))
            {
                result.Add(s);
            }
        }
        return result;
    }

}