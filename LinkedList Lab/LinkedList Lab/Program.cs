LinkedList<int> linkedList = new LinkedList<int>();
linkedList.AddFirst(5);
linkedList.AddFirst(0);
linkedList.AddFirst(5);
linkedList.AddFirst(2);

LinkedListNode<int> node = linkedList.First;
while (node != null)
{
    Console.WriteLine(node.Value);
    node = node.Next;
}