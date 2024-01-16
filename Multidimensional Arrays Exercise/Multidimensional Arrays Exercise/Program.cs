using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n,n];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row,col] = input[col];
            }
        }

        int primarySum = 0;
        for (int row = 0; row < matrix.GetLength(0); row++) // primary diagonal
        {
            primarySum += matrix[row, row];
        }

        int secondarySum = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            int diagonalMember = matrix[row, matrix.GetLength(0) - 1 - row];
            secondarySum += diagonalMember;
        }

        Console.WriteLine(Math.Abs(primarySum-secondarySum));
    }
}