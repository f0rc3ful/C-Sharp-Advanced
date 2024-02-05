using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList2
{
    public class CustomLinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public void InsertAsHead(int value)
        {
            Node newNode = new Node(value);
            if (Head == null)
            { 
                Head = newNode;
                Tail = newNode;
            }
            newNode.Next = Head;
            Head.Previous = newNode;
            Head = newNode;
        }

        public void InsertAsTail(int value) 
        {
            Node newNode = new Node(value);
            if (Tail == null)
            {
                newNode.Previous = null;
                newNode.Next = null;
            }
            newNode.Previous = Tail;
            Tail.Next = newNode;
            Tail = newNode;
        }

        public void RemoveTail()
        {
            Tail.Next = null;
            Tail = Tail.Previous;
        }

        public void RemoveHead()
        {
            Head = Head.Next;
            Head.Previous = null;
        }
    }
}
