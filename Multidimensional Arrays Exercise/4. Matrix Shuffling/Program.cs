using System;

class Program
{
    static void Main(string[] args)
    {
        int[] xy = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int rows = xy[0];
        int cols = xy[1];
        string[,] matrix = new string[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            string[] inputRow = Console.ReadLine().Split();
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = inputRow[col];
            }
        }

        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            string[] command = input.Split(" ");
            if (command.Length != 5 || command[0] != "swap")
            {
                Console.WriteLine("Invalid input!");
                continue;
            }
            int row1 = int.Parse(command[1]);
            int col1 = int.Parse(command[2]);
            int row2 = int.Parse(command[3]);
            int col2 = int.Parse(command[4]);
            int dim1 = matrix.GetLength(0);
            int dim2 = matrix.GetLength(1);
            if (row1 < 0 || row1 > dim1 - 1 || col1 < 0 || col1 > dim2 - 1 || row2 < 0 || row2 > dim1 - 1 || col2 < 0 || col2 > dim2 - 1)
            {
                Console.WriteLine("Invalid input!");
                continue;
            }
            string temporary = matrix[row2, col2];
            matrix[row2, col2] = matrix[row1, col1];
            matrix[row1, col1] = temporary;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}