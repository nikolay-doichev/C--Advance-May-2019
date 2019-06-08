namespace _07._Predicate_For_Names
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class PredicateForName
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());

            Predicate<string> validName = name => name.Length <= lenght;

            string[] names = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Where(name => validName(name))
                .ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}
