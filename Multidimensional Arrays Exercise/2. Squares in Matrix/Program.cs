using System;

class Program
{
    static void Main(string[] args)
    {
        int[] xy = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int rows = xy[0];
        int cols = xy[1];
        string[,] matrix = new string[rows,cols];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            string[] input = Console.ReadLine().Split();
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = input[col];
            }
        }

        int count = 0;
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                string a = matrix[row, col];
                string b = matrix[row, col + 1];
                string c = matrix[row + 1, col];
                string d = matrix[row + 1, col + 1];
                if (a == b && b == c && c == d)
                {
                    count++;
                }
            }
        }
            Console.WriteLine(count);
    }
}