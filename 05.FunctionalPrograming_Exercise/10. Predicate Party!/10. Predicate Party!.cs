namespace _10._Predicate_Party_
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class PredicateParty
    {
        static void Main(string[] args)
        {
            //Party!

            //Pesho Misho Stefan
            List<string> names = Console.ReadLine()
                                    .Split()
                                    .ToList();

            string commandLine = Console.ReadLine();

            //Func<string, string, bool> nameStart = (name, criteria) => name.StartsWith(criteria);
            //Func<string, string, bool> nameEnd = (name, criteria) => name.EndsWith(criteria);
            //Func<string, int, bool> lenghtName = (name, lenght) => name.Length == lenght;

            while (commandLine != "Party!")
            {
                string[] commands = commandLine.Split(' ');
                string action = commands[0];
                string criteria = commands[1];
                string parameter = commands[2];
                //Remove StartsWith P
                if (action == "Remove")
                {
                    names.RemoveAll(getPredicate(criteria, parameter));
                }

                else if (action == "Double")
                {

                    var newGuests = names.FindAll(getPredicate(criteria, parameter));
                    foreach (var guest in newGuests)
                    {
                        int indexOfGuest = names.IndexOf(guest);
                        names.Insert(indexOfGuest + 1, guest);
                    }

                }
                commandLine = Console.ReadLine();
            }
            if (names.Count > 0)
            {
                Console.WriteLine(string.Join(", ", names) + " are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }

        }

        private static Predicate<String> getPredicate(String type, String parameter)
        {
            switch (type)
            {
                case "StartsWith":
                    return text => text.StartsWith(parameter);
                case "EndsWith":
                    return text => text.EndsWith(parameter);
                case "Length":
                    return text => text.Length == int.Parse(parameter);
                default:
                    return text => false;
            }
        }
    }
}
