using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList2
{
    class Program
    {
        static void Main()
        { 
            CustomLinkedList list = new CustomLinkedList();
            list.InsertAsHead(333);
            list.InsertAsHead(222);
            list.InsertAsHead(111);
            Console.WriteLine($"1st head: {list.Head.Value}");
            Console.WriteLine($"1st tail: {list.Tail.Value}");

            list.InsertAsTail(444);
            Console.WriteLine($"2nd tail: {list.Tail.Value}");

            list.RemoveTail();
            Console.WriteLine($"3rd tail: {list.Tail.Value}");

            list.RemoveTail();
            Console.WriteLine($"4th tail: {list.Tail.Value}");

            list.InsertAsHead(555);
            Console.WriteLine($"2nd head: {list.Head.Value}");

            list.RemoveHead();
            Console.WriteLine($"back to 1st head: {list.Head.Value}");

        }
    }
}