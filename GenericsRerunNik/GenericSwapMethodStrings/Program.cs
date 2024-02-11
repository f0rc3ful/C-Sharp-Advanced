using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSwapMethodStrings
{
    class Program
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < lines; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }

            int[] indexes = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Switcher(list, indexes);
        }

        public static void Switcher<T>(List<T> list, int[] indexes)
        {
            int index1 = indexes[0];
            int index2 = indexes[1];
            T first = list[index1];
            T second = list[index2];
            list[index1] = second;
            list[index2] = first;
            StringBuilder sb = new StringBuilder();
            foreach (var item in list)
            { 
                
                sb.AppendLine($"{typeof(T)}: {item}");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}

