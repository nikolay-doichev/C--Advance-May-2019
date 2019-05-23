namespace _07._Knight_Game
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class KnightGame
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            char[,] board = new char[rows, rows];

            for (int row = 0; row < rows; row++)
            {
                char[] indexRow = Console.ReadLine()
                    .ToCharArray();
                for (int col = 0; col < rows; col++)
                {
                    board[row, col] = indexRow[col];
                }
            }
            int counter = 0;
            while (true)
            {
                int maxCount = 0;
                int knightsCount = 0;
                int knightRow = 0;
                int knightCol = 0;
                for (int row = 0; row < board.GetLength(0); row++)
                {
                    for (int col = 0; col < board.GetLength(1); col++)
                    {
                        int currentCount = 0;
                        if (board[row, col] == 'K')
                        {                            
                            //row-2  col+1
                            if (isInside(board, row - 2, col + 1) && board[row - 2, col + 1] == 'K')
                            {
                                currentCount++;
                            }
                            if (isInside(board, row - 2, col - 1) && board[row - 2, col - 1] == 'K')
                            {
                                currentCount++;
                            }
                            if (isInside(board, row + 2, col + 1) && board[row + 2, col + 1] == 'K')
                            {
                                currentCount++;
                            }
                            if (isInside(board, row + 2, col - 1) && board[row + 2, col - 1] == 'K')
                            {
                                currentCount++;
                            }
                            if (isInside(board, row - 1, col - 2) && board[row - 1, col - 2] == 'K')
                            {
                                currentCount++;
                            }
                            if (isInside(board, row + 1, col - 2) && board[row + 1, col - 2] == 'K')
                            {
                                currentCount++;
                            }
                            if (isInside(board, row + 1, col + 2) && board[row + 1, col + 2] == 'K')
                            {
                                currentCount++;
                            }
                            if (isInside(board, row - 1, col + 2) && board[row - 1, col + 2] == 'K')
                            {
                                currentCount++;
                            }
                        }
                        if (currentCount > maxCount)
                        {
                            maxCount = currentCount;
                            knightRow = row;
                            knightCol = col;
                           
                        }
                    }
                }
                if (maxCount == 0)
                {
                    break;
                }
                board[knightRow, knightCol] = '0';
                counter++;
            }
            Console.WriteLine(counter);
        }

        private static bool isInside(char[,] board, int desiredRow, int desiredCol)
        {
            return desiredRow < board.GetLength(0) && desiredRow >= 0 &&
                 desiredCol < board.GetLength(1) && desiredCol >= 0;
        }
    }
}
