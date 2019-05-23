namespace _05._Snake_Moves
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class SnakeMaves
    {
        static void Main(string[] args)
        {
            int[] dim = Console.ReadLine()
                                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();
            char[,] snakeBody = new char[dim[0], dim[1]];
            int counter = 0;
            string snakeElements = Console.ReadLine();
            for (int row = 0; row < snakeBody.GetLength(0); row++)
            {               
                //SoftUn i
                //5 6
                for (int col = 0; col < snakeBody.GetLength(1); col++)
                {
                    char currentElement = snakeElements[counter];
                    counter++;
                    snakeBody[row, col] = currentElement;
                    if (counter>=snakeElements.Length)
                    {
                        counter = 0;
                    }
                }
            }

            for (int i = 0; i < snakeBody.GetLength(0); i++)
            {
                for (int j = 0; j < snakeBody.GetLength(1); j++)
                {
                    Console.Write(snakeBody[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
