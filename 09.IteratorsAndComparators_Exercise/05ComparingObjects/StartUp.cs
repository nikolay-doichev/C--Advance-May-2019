namespace _05ComparingObjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] tokens = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string town = tokens[2];

                var person = new Person(name, age, town);
                people.Add(person);

                input = Console.ReadLine();
            }

            int n = int.Parse(Console.ReadLine());

            int countOfMathes = 1;
            int countOfNotEqualPeople = 0;
            Person targetPerson = people[n - 1];

            foreach (var item in people)
            {
                if (item == targetPerson)
                {
                    continue;
                }
                if (item.CompareTo(targetPerson) == 0)
                {
                    countOfMathes++;
                }
                else
                {
                    countOfNotEqualPeople++;
                }
            }
            if (countOfMathes == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{countOfMathes} {countOfNotEqualPeople} {people.Count}");
            }
        }
    }
}
