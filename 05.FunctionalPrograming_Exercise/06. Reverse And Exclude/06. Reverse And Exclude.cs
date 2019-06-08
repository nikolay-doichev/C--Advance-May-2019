namespace _06._Reverse_And_Exclude
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class ReverseAndExclude
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();
            int devider = int.Parse(Console.ReadLine());
              
            Predicate<int> isDevide = number => number % devider != 0;

            //20 10 40 30 60 50
            //50 40 10 20

            Func<List<int>, List<int>> reverse = x =>
            {
                List<int> newNumbers = new List<int>();
                for (int i = x.Count - 1; i >= 0; i--)
                {
                    newNumbers.Add(x[i]);
                }
                return x = newNumbers.ToList();
            };

            Console.WriteLine(string.Join(' ',reverse(numbers).Where(x => isDevide(x))));
        }
    }
}
