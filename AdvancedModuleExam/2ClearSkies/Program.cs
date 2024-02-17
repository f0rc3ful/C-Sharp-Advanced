using System.Runtime.CompilerServices;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        char[,] matrix = new char[n, n];
        int posX = 0, posY = 0, enemies = 0, armor = 300;
        for (int row = 0; row < n; row++)
        {
            string input = Console.ReadLine();
            for (int col = 0; col < n; col++)
            {
                matrix[row, col] = input[col];
                if (input[col] == 'J')
                { 
                    posX = row;
                    posY = col;
                }
                if (input[col] == 'E')
                {
                    enemies++;
                }
            }
        }

        string command;
        while (enemies > 0 && armor > 0)
        {
            matrix[posX, posY] = '-';
            command = Console.ReadLine();
            if (command == "up")
            {
                posX -= 1;
                if (matrix[posX, posY] == 'R')
                {
                    armor = 300;
                    matrix[posX, posY] = 'J';
                }
                else if (matrix[posX, posY] == 'E')
                {
                    armor -= 100;
                    matrix[posX, posY] = 'J';
                    if (armor == 0)
                    {
                        break;
                    }
                    else
                    {
                        enemies--;
                    }
                }
                else // if next char isn't '-', just replace the new position character with J
                {
                    matrix[posX, posY] = 'J';
                }
            }
            else if (command == "down")
            {
                posX += 1;
                if (matrix[posX, posY] == 'R')
                {
                    armor = 300;
                    matrix[posX, posY] = 'J';
                }
                else if (matrix[posX, posY] == 'E')
                {
                    armor -= 100;
                    matrix[posX, posY] = 'J';
                    if (armor == 0)
                    {
                        break;
                    }
                    else
                    {
                        enemies--;
                    }
                }
                else // if next char isn't '-', just replace the new position character with J
                {
                    matrix[posX, posY] = 'J';
                }
            }
            else if (command == "left")
            {
                posY -= 1;
                if (matrix[posX, posY] == 'R')
                {
                    armor = 300;
                    matrix[posX, posY] = 'J';
                }
                else if (matrix[posX, posY] == 'E')
                {
                    armor -= 100;
                    matrix[posX, posY] = 'J';
                    if (armor == 0)
                    {
                        break;
                    }
                    else
                    {
                        enemies--;
                    }
                }
                else // if next char isn't '-', just replace the new position character with J
                {
                    matrix[posX, posY] = 'J';
                }
            }
            else if (command == "right")
            {
                posY += 1;
                if (matrix[posX, posY] == 'R')
                {
                    armor = 300;
                    matrix[posX, posY] = 'J';
                }
                else if (matrix[posX, posY] == 'E')
                {
                    armor -= 100;
                    matrix[posX, posY] = 'J';
                    if (armor == 0)
                    {
                        break;
                    }
                    else
                    {
                        enemies--;
                    }
                }
                else // if next char isn't '-', just replace the new position character with J
                {
                    matrix[posX, posY] = 'J';
                }
            }
        }

        if (enemies == 0)
        {
            Console.WriteLine("Mission accomplished, you neutralized the aerial threat!");
        }
        else if (armor == 0)
        {
            Console.WriteLine($"Mission failed, your jetfighter was shot down! Last coordinates [{posX}, {posY}]!");
        }

        PrintMatrix(matrix);
    }

    static void PrintMatrix(char[,] matrix)
    {
        StringBuilder sb = new StringBuilder();
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                sb.Append(matrix[row, col]);
            }
            sb.AppendLine();
        }

        Console.WriteLine(sb.ToString());  
    }
}