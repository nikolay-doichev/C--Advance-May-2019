namespace _09._List_Of_Predicates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class ListOfPredicates
    {
        static void Main(string[] args)
        {
            int upperBound = int.Parse(Console.ReadLine());

            List<int> numbers = Enumerable.Range(1, upperBound).ToList();

            int[] deviders = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Distinct()
                .ToArray();

            

            for (int i = 0; i < deviders.Length; i++)
            {
                Predicate<int> diviseble = (num) =>
                {
                    return num % deviders[i] == 0;
                };
                numbers = numbers.FindAll(diviseble);
            }

            Console.WriteLine(string.Join(' ',numbers));
            
        }
    }
}
