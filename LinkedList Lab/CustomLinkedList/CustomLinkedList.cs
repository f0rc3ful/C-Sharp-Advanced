using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    public class CustomLinkedList
    {
         public Node Head { get; set; }
         public Node Tail { get; set; }

        public void AddLast(int value)
        {
            Node newNode = new Node(value);
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
                return;
            }
            newNode.Previous = Tail;
            Tail.Next = newNode;
            Tail = newNode;
        }

        public void AddFirst(int value)
        {
            Node newNode = new Node(value);
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
                return;
            }
            newNode.Next = Head;
            Head.Previous = newNode;
            Head = newNode;
        }

        public void RemoveFirst() 
        {
            Node toBeRemoved = Head;
            Head = toBeRemoved.Next;
            toBeRemoved.Previous = null;

        }
        public void RemoveLast()
        {
            Node toBeRemoved = Tail;
            Tail = toBeRemoved.Previous;
            toBeRemoved.Next = null;

        }
    }
}
