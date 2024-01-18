using System;

class Program
{
    static void Main(string[] args)
    {
        int[] xy = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int rows = xy[0];
        int cols = xy[1];
        char[,] matrix = new char[rows, cols];
        string input = Console.ReadLine();
        Queue<char> queue = new Queue<char>();
        foreach (char letter in input)
        {
            queue.Enqueue(letter);
        }

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            if (row % 2 == 0)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    char temporary = queue.Dequeue();
                    matrix[row, col] = temporary;
                    queue.Enqueue(temporary);
                }
            }
            else if (row % 2 == 1)
            {
                for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                {
                    char temporary = queue.Dequeue();
                    matrix[row, col] = temporary;
                    queue.Enqueue(temporary);
                }
            }

        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j]);
            }
            Console.WriteLine();
        }



    }
}