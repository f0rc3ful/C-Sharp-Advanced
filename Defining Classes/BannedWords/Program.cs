string[] bannedWords = new string[] { "kur", "iz", "nad"};

string inputWord;

while ((inputWord = Console.ReadLine().ToLower()) != "end") // ToLower standardizes the input
{   // takes any string from the string[] and verifies whether it is a substring of the current inputWord:
    if (bannedWords.Any(bannedWord => inputWord.Contains(bannedWord)))
    {
        Console.WriteLine("You are using forbidden language");
    }
    else
    {
        Console.WriteLine("Valid input");
    }
}
Console.WriteLine("Program is closing...");