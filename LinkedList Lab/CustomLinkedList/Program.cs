namespace CustomLinkedList
{
    class Program
    {
        static void Main()
        {
            CustomLinkedList customLinkedList = new CustomLinkedList();
            customLinkedList.AddLast(1);
            customLinkedList.AddLast(2);
            Node head = customLinkedList.Head;
            Console.WriteLine($"firt head: {head.Value}");
            Node tail = customLinkedList.Tail;
            Console.WriteLine($"first tail: {tail.Value}");

            customLinkedList.AddFirst(3);

            head = customLinkedList.Head;
            Console.WriteLine($"second head: {head.Value}");
            tail = customLinkedList.Tail;
            Console.WriteLine($"second tail: {tail.Value}");
        }
    }
}