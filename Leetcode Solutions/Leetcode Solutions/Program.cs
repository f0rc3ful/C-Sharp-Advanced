using System;

class Program
{
    static void Main(string[] args)
    {
        string haysack = Console.ReadLine();
        string needle = Console.ReadLine();
        Console.WriteLine(StrStr(haysack, needle)); 
    }
    static int StrStr(string haystack, string needle)
    {
        if (haystack.Length == needle.Length)
        {
            if (haystack == needle)
            {
                return 0;
            }
        }
        int needleLength = needle.Length;
        for (int i = 0; i < haystack.Length - needleLength + 1; i++)
        {
            string comparator = haystack.Substring(i, needleLength);
            if (comparator == needle)
            {
                return i;
            }
        }
        return -1;
    }
}