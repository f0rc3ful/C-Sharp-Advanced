namespace Date_Modifier
{
    class Program
    {
        static void Main()
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            DateModifier difference = new DateModifier(input1, input2);
            Console.WriteLine(difference.DifferenceInDays);
        }
    }
        
}
