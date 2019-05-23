namespace _03._Maximal_Sum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class MaximalSum
    {
        static void Main(string[] args)
        {
            int[] dim = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[,] arr = new int[dim[0], dim[1]];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = tokens[j];
                }
            }

            int maxSum = int.MinValue;
            int selectedRow = -1;
            int selectedCol = -1;

            for (int row = 0; row < arr.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < arr.GetLength(1) - 2; col++)
                {
                    int sum = arr[row, col] + arr[row, col + 1] + arr[row, col + 2] + 
                        arr[row + 1, col] + arr[row + 1, col + 1] + arr[row + 1, col + 2] +
                        arr[row + 2, col] + arr[row + 2, col + 1] + arr[row + 2, col + 2];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        selectedCol = col;
                        selectedRow = row;
                    }
                }

            }
            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine($"{arr[selectedRow, selectedCol]} {arr[selectedRow, selectedCol + 1]} {arr[selectedRow, selectedCol + 2]} " +
                $"\n{arr[selectedRow + 1, selectedCol]} {arr[selectedRow + 1, selectedCol + 1]} {arr[selectedRow + 1, selectedCol + 2]} " +
                $"\n{arr[selectedRow + 2, selectedCol]} {arr[selectedRow + 2, selectedCol + 1]} {arr[selectedRow + 2, selectedCol + 2]}");
        }
    }
}
