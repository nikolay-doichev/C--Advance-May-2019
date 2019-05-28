namespace _03.SetsAndDictionariesAdvance_Exercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class UniqueUsernames
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();
            

            for (int index = 0; index < n; index++)
            {
                string input = Console.ReadLine();
                names.Add(input);
            }
            
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
