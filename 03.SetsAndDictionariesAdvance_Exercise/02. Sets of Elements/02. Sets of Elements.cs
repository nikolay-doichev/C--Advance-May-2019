namespace _02._Sets_of_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class SetsOfElements
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();  
            //1 3 5 7
            //3 4 5 
            HashSet<int> firstSet = new HashSet<int>();  // 1 3 5 7 4
            HashSet<int> secondSet = new HashSet<int>();  // 1 3 5 7 4

            for (int i = 0; i < n[0]; i++)
            {
                int number = int.Parse(Console.ReadLine());
                
                firstSet.Add(number);
            }

            for (int i = 0; i < n[1]; i++)
            {
                int number = int.Parse(Console.ReadLine());

                secondSet.Add(number);
            }

            foreach (var currentItem in firstSet)
            {
                if (secondSet.Contains(currentItem))
                {
                    Console.Write(currentItem + " ");
                }
            }
        }
    }
}
