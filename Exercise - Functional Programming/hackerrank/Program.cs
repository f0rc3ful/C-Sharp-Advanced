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
        int n = int.Parse(Console.ReadLine());
        List<List<int>> ints= new List<List<int>>();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < arr.Count; j++)
            {
                dig1 += arr[i][j];
            }
            
        }
    }
    public static int diagonalDifference(List<List<int>> arr)
    {
        int dig1 = 0;
        int dig2 = 0;
        for (int i = 0; i < arr.Count; i++)
        {
            for (int j1 = 0; j1 < arr.Count; j1++)
            {
                dig1 += arr[i][j1];
            }
            for (int j2 = arr.Count - 1; j2 >= 0; j2--)
            {
                dig2 += arr[i][j2];
            }
        }
        return Math.Abs(dig1 - dig2);
    }

}


