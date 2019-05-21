namespace _04._Symbol_in_Matrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class SymbolInMatrix
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] charArray = new char[n, n];

            for (int row = 0; row < charArray.GetLength(0); row++)
            {
                char[] colElements = Console.ReadLine().ToArray();

                for (int col = 0; col < charArray.GetLength(1); col++)
                {
                    charArray[row, col] = colElements[col];
                }
            }

            char searchedSymbol = char.Parse(Console.ReadLine());
            bool isFind = false;
            for (int i = 0; i < charArray.GetLength(0); i++)
            {
                for (int j = 0; j < charArray.GetLength(1); j++)
                {
                    char symbol = charArray[i, j];
                    if (searchedSymbol==symbol)
                    {
                        Console.WriteLine($"({i}, {j})");
                        isFind = true;
                        return;
                    }
                }
            }
            if (isFind==false)
            {
                Console.WriteLine($"{searchedSymbol} does not occur in the matrix");
            }
        }
    }
}
