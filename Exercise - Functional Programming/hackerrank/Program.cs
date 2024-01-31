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
        string s = Console.ReadLine();
        string t = Console.ReadLine();
        Console.WriteLine(IsSubsequence(s, t));
    }
    static bool IsSubsequence(string s, string t)
    {
        string shorter1;
        string longer1;
        if (s == "")
        {
            return true;
        }
        else if (t == "")
        {
            return false;
        }
        if (s.Length > t.Length)
        {
            shorter1 = t;
            longer1 = s;
        }
        else
        {
            shorter1 = s;
            longer1 = t;
        }
        List<char> shorter = shorter1.ToList();
        List<char> longer = longer1.ToList();
        for (int i = 0; i < longer.Count; i++)
        {
            if (!(shorter.Contains(longer[i])))
            {
                longer.Remove(longer[i]);
                i--;
            }
        }
        string shorterStr = string.Join("", shorter);
        string longerStr = string.Join("", longer);
        if (longerStr.Contains(shorterStr))
        {
            return true;
        }
        return shorterStr == longerStr; 
    }

}


