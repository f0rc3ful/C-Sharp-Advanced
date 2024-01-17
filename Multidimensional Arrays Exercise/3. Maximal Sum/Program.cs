using System;

class Program
{
    static void Main(string[] args)
    {
        int[] xy = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int rows = xy[0];
        int cols = xy[1];
        int[,] largeMatrix = new int[rows, cols];

        for (int row = 0; row < largeMatrix.GetLength(0); row++)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int col = 0; col < largeMatrix.GetLength(1); col++)
            {
                largeMatrix[row, col] = input[col];
            }
        }

        int[,] smallMatrix = new int[3,3];
        int sum = int.MinValue;
        for (int row = 0; row < rows - 2; row++)
        {
            for (int col = 0; col < cols - 2; col++)
            {
                int currentSum = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        currentSum += largeMatrix[row + i, row + j];
                    }
                }
                //int m00 = largeMatrix[row, col];
                //int m01 = largeMatrix[row, col + 1];
                //int m02 = largeMatrix[row, col + 2];
                //int m10 = largeMatrix[row + 1, col];
                //int m11 = largeMatrix[row + 1, col + 1];
                //int m12 = largeMatrix[row + 1, col + 2];
                //int m20 = largeMatrix[row + 2, col];
                //int m21 = largeMatrix[row + 2, col + 1];
                //int m22 = largeMatrix[row + 2, col + 2];
                //currentSum = m00 + m01 + m02 + m10 + m11 + m12 + m20 + m21 + m22;
                if (currentSum > sum)
                {
                    sum = currentSum;
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            smallMatrix[i, j] = largeMatrix[i, j];
                        }
                    }
                    //smallMatrix[0,0] = m00;
                    //smallMatrix[0, 1] = m01;
                    //smallMatrix[0, 2] = m02;
                    //smallMatrix[1, 0] = m10;
                    //smallMatrix[1, 1] = m11;
                    //smallMatrix[1, 2] = m12;
                    //smallMatrix[2, 0] = m20;
                    //smallMatrix[2, 1] = m21;
                    //smallMatrix[2, 2] = m22;
                }
            }
        }

        Console.WriteLine($"Sum = {sum}");
        for (int i = 0; i < 3; i++)
        { 
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"{smallMatrix[i,j]} ");
            }
            Console.WriteLine();
        }
    }
}