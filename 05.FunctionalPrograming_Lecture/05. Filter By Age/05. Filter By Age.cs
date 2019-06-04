﻿namespace _05._Filter_By_Age
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class FileterByAge
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());

            List<KeyValuePair<string, int>> people = new List<KeyValuePair<string, int>>(); 

            for (int i = 0; i < peopleCount; i++)
            {
                string[] person = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);
                people.Add(new KeyValuePair<string, int>(person[0], int.Parse(person[1])));
            }

            string filter = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            string[] printPatern = Console.ReadLine().Split(' ');

            people.Where(p => filter == "younger" ? p.Value <= age : p.Value >= age)
                .ToList()
                .ForEach(p => Printer(p, printPatern));

        }
        static void Printer(KeyValuePair<string, int> person, string[]printPatern)
        {
            if (printPatern.Length==2)
            {
                Console.WriteLine(printPatern[0] == "name" ? $"{person.Key} - {person.Value}" :
                    $"{person.Value} - {person.Key}");
            }

            else
            {
                Console.WriteLine(printPatern[0] == "name" ? $"{person.Key}" :
                    $"{person.Value}");
            }
        }
    }
}
