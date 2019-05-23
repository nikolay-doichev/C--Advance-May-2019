namespace _02._Squares_in_Matrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class SquaresInMatrix
    {
        static void Main(string[] args)
        {
            int[] dim = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            char[,] arr = new char[dim[0], dim[1]];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                char[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = tokens[j];
                }
            }            
            int counter = 0;
            
            for (int row = 0; row < arr.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < arr.GetLength(1) - 1; col++)
                {
                    char currentSymbol = arr[row, col];

                    if (currentSymbol == arr[row, col + 1]
                        && currentSymbol == arr[row + 1, col]
                        && currentSymbol == arr[row + 1, col + 1])
                    {
                        counter++;
                    }
                }

            }
            Console.WriteLine(counter);

        }
    }
}
