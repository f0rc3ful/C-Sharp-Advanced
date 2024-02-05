Queue<string> queue =  new Queue<string>();
LinkedList<string> linkedListQ= new LinkedList<string>();

queue.Enqueue("Toshko");
linkedListQ.AddLast("Toshko");

queue.Enqueue("Niki");
linkedListQ.AddLast("Niki");

queue.Enqueue("Moni");
linkedListQ.AddLast("Moni");

while (queue.Count > 0)
{ 
    string served = queue.Dequeue();
    Console.WriteLine($"Queue: {served}");
}

LinkedListNode<string> person = linkedListQ.First;
while (person != null)
{
    Console.WriteLine($"Linked list: {person.Value}");
    linkedListQ.RemoveFirst();
    person = linkedListQ.First;
}

