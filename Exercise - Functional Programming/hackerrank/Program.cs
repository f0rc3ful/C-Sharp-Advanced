using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
    static void Main(string[] args)
    {
        string str1 = Console.ReadLine();
        string str2 = Console.ReadLine();
        string output = GcdOfStrings(str1, str2);
        Console.WriteLine(output);
    }
    static string GcdOfStrings(string str1, string str2)
    {
        string output = "";
        string shorter;
        string longer;
        if (str1.Length > str2.Length)
        {
            shorter = str2;
            longer = str1;
        }
        else
        {
            shorter = str1;
            longer = str2;
        }
        List<char> chars1= new List<char>();
        for (int i = 0; i < shorter.Length; i++)
        {
            if (!chars1.Contains(shorter[i]))
            {
                chars1.Add(shorter[i]);
            }
        }
        List<char> chars2 = new List<char>();
        for (int i = 0; i < longer.Length; i++)
        {
            if (!chars2.Contains(longer[i]))
            {
                chars2.Add(longer[i]);
            }
        }
        if (chars1.Count > 1 && chars2.Count > 1 && chars1 == chars2)
        {
            output = string.Join("", chars1);
        }
        return output;
    }

}


