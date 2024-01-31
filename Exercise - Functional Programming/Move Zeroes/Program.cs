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
        int[] nums = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        IsSubsequence(nums);
    }
    static void IsSubsequence(int[] nums)
    {
        List<int> queue = new List<int>();
        int counter = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                queue.Add(nums[i]);
            }
            else
            {
                counter++;
            }
        }
        for (int i = 0; i < counter; i++)
        {
            queue.Add(0);
        }
        Console.WriteLine(string.Join(",", queue));
    }
}
