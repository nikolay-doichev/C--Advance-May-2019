namespace _02.Multidimensional_Arrays_Exercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class DiagonalDifference
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int sumOfPrimalDiagonal = 0;
            int sumOfSecondDiagonal = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] matrixElements = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = matrixElements[col];
                }
                sumOfPrimalDiagonal += matrix[row, row];
                sumOfSecondDiagonal += matrix[row, matrix.GetLength(0) - 1 - row];
            }
            int difference = Math.Abs(sumOfPrimalDiagonal - sumOfSecondDiagonal);
            Console.WriteLine(difference);
        }
    }
}
