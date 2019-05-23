namespace _04._Matrix_Shuffling
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class MatrixShufflingl
    {
        static void Main(string[] args)
        {
            int[] dim = Console.ReadLine()
                               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();

            string[,] matrix = new string[dim[0], dim[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] tokens = Console.ReadLine()
                               .Split(' ', StringSplitOptions.RemoveEmptyEntries)                               
                               .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = tokens[col];
                }
            }

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] line = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                //swap 0 0 1 1
                string command = line[0];
                //row1, row2, col1, col2                
                if (command=="swap" && line.Length == 5)
                {
                    int row1 = int.Parse(line[1]);
                    int col1 = int.Parse(line[2]);
                    int row2 = int.Parse(line[3]);
                    int col2 = int.Parse(line[4]);

                    if (row1>=0 && row1<matrix.GetLength(0) && row2 >= 0 && row2 < matrix.GetLength(0) 
                        && col1 >=0 && col1<matrix.GetLength(1) && col2 >= 0 && col2 < matrix.GetLength(1))
                    {
                        string intForMove1 = matrix[row1, col1];
                        string intForMove2 = matrix[row2, col2];

                        matrix[row1, col1] = intForMove2;
                        matrix[row2, col2] = intForMove1;

                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                Console.Write(matrix[i,j] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                input = Console.ReadLine();
            }
        }
    }
}
