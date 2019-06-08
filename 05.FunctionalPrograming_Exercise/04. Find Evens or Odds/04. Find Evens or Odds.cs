﻿namespace _04._Find_Evens_or_Odds
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class FindEvensorOdds
    {
        static void Main(string[] args)
        {
            int[] bounds = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int lowerBound = bounds[0];
            int upperBound = bounds[1];

            List<int> numbers = new List<int>();

            string numberType = Console.ReadLine();

            for (int i = lowerBound; i <= upperBound; i++)
            {
                numbers.Add(i);
            }

            Predicate<int> isEven = number => number % 2 == 0;
            Predicate<int> isOdd = number => number % 2 != 0;
            Action <List<int>> printNumbers = outputNumbers => Console.WriteLine((string.Join(" ", outputNumbers)));

            if (numberType == "odd")
            {
                numbers = numbers.Where(x => isOdd(x)).ToList(); 
            }
            else
            {
                numbers = numbers.Where(x => isEven(x)).ToList();
            }

            printNumbers(numbers);
        }
    }
}
