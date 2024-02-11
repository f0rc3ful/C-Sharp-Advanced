using System.Text;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char[,] matrix = new char[n, n];
        int posX = 0, posY = 0;
        int caught = 0;
        for (int i = 0; i < n; i++)
        { 
            string input = Console.ReadLine();
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = input[j];
                if (input[j] == 'S')
                {
                    posX = i; posY = j;
                }
            }
        }

        bool whirlpool = false;
        string command;
        while ((command = Console.ReadLine()) != "collect the nets")
        {
            if (command == "left")
            {
                matrix[posX, posY] = '-';
                posY = (posY - 1 + n) % n;
                if (matrix[posX, posY] == 'W')
                {
                    Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{posX},{posY}]");
                    whirlpool = true;
                    break;
                }
                else
                {
                    if (char.IsDigit(matrix[posX, posY]))
                    {
                        caught += (int)char.GetNumericValue(matrix[posX, posY]);
                    }
                    matrix[posX, posY] = 'S';
                }
            }
            else if (command == "right")
            {
                matrix[posX, posY] = '-';
                posY = (posY + 1 + n) % n;
                if (matrix[posX, posY] == 'W')
                {
                    Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{posX},{posY}]");
                    whirlpool = true;
                    break;
                }
                else
                {
                    if (char.IsDigit(matrix[posX, posY]))
                    {
                        caught += (int)char.GetNumericValue(matrix[posX, posY]);
                    }
                    matrix[posX, posY] = 'S';
                }
            }
            else if (command == "up")
            {
                matrix[posX, posY] = '-';
                posX = (posX - 1 + n) % n;
                if (matrix[posX, posY] == 'W')
                {
                    Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{posX},{posY}]");
                    whirlpool = true;
                    break;
                }
                else
                {
                    if (char.IsDigit(matrix[posX, posY]))
                    {
                        caught += (int)char.GetNumericValue(matrix[posX, posY]);
                    }
                    matrix[posX, posY] = 'S';
                }
            }
            else if (command == "down")
            {
                matrix[posX, posY] = '-';
                posX = (posX + 1 + n) % n;
                if (matrix[posX, posY] == 'W')
                {
                    Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{posX},{posY}]");
                    whirlpool = true;
                    break;
                }
                else
                {
                    if (char.IsDigit(matrix[posX, posY]))
                    {
                        caught += (int)char.GetNumericValue(matrix[posX, posY]);
                    }
                    matrix[posX, posY] = 'S';
                }
            }
        }
        if (!(whirlpool))
        {
            if (caught < 20)
            {
                Console.WriteLine($"You didn't catch enough fish and didn't reach the quota! You need {20 - caught} tons of fish more.");
                if (caught > 0)
                {
                    Console.WriteLine($"Amount of fish caught: {caught} tons.");
                }
            }
            else if (caught >= 20)
            {
                Console.WriteLine($"Success! You managed to reach the quota! ");
                Console.WriteLine($"Amount of fish caught: {caught} tons.");
            }
            PrintMatrix(matrix);
        }

    }

    static void PrintMatrix(char[,] matrix)
    {
        int n = matrix.GetLength(0);
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                sb.Append(matrix[i, j]);
            }
            sb.AppendLine();
        }
        Console.WriteLine(sb.ToString());
    }
}