namespace _03._Periodic_Table
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class PeriodicTable
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> periodicSymbols = new SortedSet<string>();

            for (int index = 0; index < n; index++)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < input.Length; i++)
                {
                    periodicSymbols.Add(input[i]);
                }              

            }

            foreach (var symbol in periodicSymbols)
            {
                Console.Write(symbol+ " ");
            }
        }
    }
}
