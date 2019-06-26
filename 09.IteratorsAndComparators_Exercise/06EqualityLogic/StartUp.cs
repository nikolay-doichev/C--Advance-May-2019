namespace _06EqualityLogic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            HashSet<Person> personHash = new HashSet<Person>();
            SortedSet<Person> sortedSet = new SortedSet<Person>();

            int counter = int.Parse(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);

                personHash.Add(person);
                sortedSet.Add(person);
            }

            Console.WriteLine(personHash.Count);
            Console.WriteLine(sortedSet.Count);
        }
    }
}
