namespace _05._Count_Symbols
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class CountSymbols
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> countSymbols = new SortedDictionary<char, int>();

            string input = Console.ReadLine();

            for (int index = 0; index < input.Length; index++)
            {
                char currentChar = input[index];

                if (!countSymbols.ContainsKey(currentChar))
                {
                    countSymbols[currentChar] = 1;
                }

                else
                {
                    countSymbols[currentChar]++;
                }
            }

            foreach (var symbol in countSymbols)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}
