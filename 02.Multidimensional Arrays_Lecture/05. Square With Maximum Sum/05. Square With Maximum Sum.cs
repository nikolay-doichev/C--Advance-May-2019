namespace _05._Square_With_Maximum_Sum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class SquareWithMaximumSum
    {
        static void Main(string[] args)
        {
            int[] dim = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[,] arr = new int[dim[0], dim[1]];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int[] tokens = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = tokens[j];
                }
            }

            int maxSum = int.MinValue;
            int selectedRow = -1;
            int seletedCol = -1;

            for (int row = 0; row < arr.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < arr.GetLength(1) - 1; col++)
                {
                    int sum = arr[row, col] + arr[row, col + 1] +
                        arr[row + 1, col] + arr[row + 1, col + 1];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        seletedCol = col;
                        selectedRow = row;
                    }
                }

            }

            Console.WriteLine($"{arr[selectedRow,seletedCol]} {arr[selectedRow,seletedCol+1]} " +
                $"\n{arr[selectedRow+1,seletedCol]} {arr[selectedRow+1,seletedCol+1]} " +
                $"\n{maxSum}");
        }
    }
}
