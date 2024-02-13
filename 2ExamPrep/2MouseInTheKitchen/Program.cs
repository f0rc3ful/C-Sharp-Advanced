class Program
{
    static void Main(string[] args)
    {
        string indexes = Console.ReadLine();
        int rows = (int)Char.GetNumericValue(indexes[0]);
        int cols = (int)Char.GetNumericValue(indexes[2]);
        char[,] matrix = new char[rows, cols];
        int x = 0;
        int y = 0;

        for (int row = 0; row < rows; row++)
        {
            string input = Console.ReadLine();
            for (int col = 0; col < cols; col++)
            {
                if (input[col] == 'M')
                {
                    x = row; y = col;
                }
                matrix[row, col] = input[col];
            }
        }

        string command;
        while ((command = Console.ReadLine()) != "danger")
        {
            if (command == "left")
            {
                if (y - 1 < 0) // check if outside of cupboard
                {
                    Console.WriteLine("No more cheese for tonight!");
                    break;
                }
                else if (matrix[x, y - 1] == '@') // check whether the next move is to be skipped
                {
                    continue;
                }
                else if (matrix[x, y - 1] == 'C') // check whether the next char is C
                {
                    matrix[x, y] = '*'; // replace old position with a *
                    y -= 1;             // decrease y by 1 and therefore move M to the left
                    matrix[x, y] = 'M'; // assign M to the new position
                    
                    if (!ContainsCheese(matrix))
                    {
                        Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                        break;
                    }
                }
                else if (matrix[x, y - 1] == 'T') // check whether the next char is C
                {
                    matrix[x, y] = '*'; // replace old position with a *
                    y -= 1;             // decrease y by 1 and therefore move M to the left
                    matrix[x, y] = 'M'; // assign M to the new position

                    Console.WriteLine("Mouse is trapped!");
                    break;
                }
                else if (matrix[x, y - 1] == '*') // check whether the next char is a star and if yes just move to it
                {
                    matrix[x, y] = '*'; // replace old position with a *
                    y -= 1;             // decrease y by 1 and therefore move M to the left
                    matrix[x, y] = 'M'; // assign M to the new position
                }
            }
            else if (command == "right")
            {
                if (y + 1 == cols) // check if outside of cupboard
                {
                    Console.WriteLine("No more cheese for tonight!");
                    break;
                }
                else if (matrix[x, y + 1] == '@') // check whether the next move is to be skipped
                {
                    continue;
                }
                else if (matrix[x, y + 1] == 'C') // check whether the next char is C
                {
                    matrix[x, y] = '*'; // replace old position with a *
                    y += 1;             // decrease y by 1 and therefore move M to the left
                    matrix[x, y] = 'M'; // assign M to the new position

                    if (!ContainsCheese(matrix))
                    {
                        Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                        break;
                    }
                }
                else if (matrix[x, y + 1] == 'T') // check whether the next char is C
                {
                    matrix[x, y] = '*'; // replace old position with a *
                    y += 1;             // decrease y by 1 and therefore move M to the left
                    matrix[x, y] = 'M'; // assign M to the new position

                    Console.WriteLine("Mouse is trapped!");
                    break;
                }
                else if (matrix[x, y + 1] == '*') // check whether the next char is a star and if yes just move to it
                {
                    matrix[x, y] = '*'; // replace old position with a *
                    y += 1;             // decrease y by 1 and therefore move M to the left
                    matrix[x, y] = 'M'; // assign M to the new position
                }
            }
            else if (command == "up")
            {
                if (x - 1 < 0) // check if outside of cupboard
                {
                    Console.WriteLine("No more cheese for tonight!");
                    break;
                }
                else if (matrix[x - 1, y] == '@') // check whether the next move is to be skipped
                {
                    continue;
                }
                else if (matrix[x - 1, y] == 'C') // check whether the next char is C
                {
                    matrix[x, y] = '*'; // replace old position with a *
                    x -= 1;             // decrease y by 1 and therefore move M to the left
                    matrix[x, y] = 'M'; // assign M to the new position

                    if (!ContainsCheese(matrix))
                    {
                        Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                        break;
                    }
                }
                else if (matrix[x - 1, y] == 'T') // check whether the next char is C
                {
                    matrix[x, y] = '*'; // replace old position with a *
                    x -= 1;             // decrease y by 1 and therefore move M to the left
                    matrix[x, y] = 'M'; // assign M to the new position

                    Console.WriteLine("Mouse is trapped!");
                    break;
                }
                else if (matrix[x - 1, y] == '*') // check whether the next char is a star and if yes just move to it
                {
                    matrix[x, y] = '*'; // replace old position with a *
                    x -= 1;             // decrease y by 1 and therefore move M to the left
                    matrix[x, y] = 'M'; // assign M to the new position
                }
            }
            else if (command == "down")
            {
                if (x + 1 == cols) // check if outside of cupboard
                {
                    Console.WriteLine("No more cheese for tonight!");
                    break;
                }
                else if (matrix[x + 1, y] == '@') // check whether the next move is to be skipped
                {
                    continue;
                }
                else if (matrix[x + 1, y] == 'C') // check whether the next char is C
                {
                    matrix[x, y] = '*'; // replace old position with a *
                    x += 1;             // decrease y by 1 and therefore move M to the left
                    matrix[x, y] = 'M'; // assign M to the new position

                    if (!ContainsCheese(matrix))
                    {
                        Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                        break;
                    }
                }
                else if (matrix[x + 1, y] == 'T') // check whether the next char is C
                {
                    matrix[x, y] = '*'; // replace old position with a *
                    x += 1;             // decrease y by 1 and therefore move M to the left
                    matrix[x, y] = 'M'; // assign M to the new position

                    Console.WriteLine("Mouse is trapped!");
                    break;
                }
                else if (matrix[x + 1, y] == '*') // check whether the next char is a star and if yes just move to it
                {
                    matrix[x, y] = '*'; // replace old position with a *
                    x += 1;             // decrease y by 1 and therefore move M to the left
                    matrix[x, y] = 'M'; // assign M to the new position
                }
            }

        }

        if (command == "danger")
        {
            Console.WriteLine("Mouse will come back later!");
        }
        MatrixPrinter(matrix);
    }

    static void MatrixPrinter(char[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col]);
            }
            Console.WriteLine();
        }
    }

    static bool ContainsCheese(char[,] matrix)
    {
        foreach (char element in matrix)
        {
            if (element == 'C')
            {
                return true;
            }
        }
        return false;
    }
}