namespace _06._Bomb_the_Basement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class BombTheBasement
    {
        static void Main(string[] args)
        {
            int[] dimension = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimension[0];
            int cols = dimension[1];

            int[][] basement = new int[rows][];

            for (int i = 0; i < basement.Length; i++)
            {
                basement[i] = new int[cols];
            }

            int[] coordinates = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int targetRow = coordinates[0];
            int targetCol = coordinates[1];
            int radius = coordinates[2];

            for (int row = 0; row < basement.Length; row++)
            {
                for (int col = 0; col < basement[row].Length; col++)
                {
                    bool isInRadius = Math.Pow(row - targetRow, 2) + Math.Pow(col - targetCol, 2) <= Math.Pow(radius,2);
                    if (isInRadius)
                    {
                        basement[row][col] = 1;
                    }
                }
            }

            int counter = 0;

            for (int col = 0; col < basement[0].Length; col++)
            {
                counter = 0;
                for (int row = 0; row < basement.Length; row++)
                {
                    if (basement[row][col] == 1)
                    {
                        counter++;
                        basement[row][col] = 0;
                    }
                }

                for (int row = 0; row < counter; row++)
                {
                    basement[row][col] = 1;
                }
            }
            foreach (var row in basement)
            {
                Console.WriteLine(string.Join("",row));
            }
        }
    }
}
