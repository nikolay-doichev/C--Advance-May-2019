namespace _11._The_Party_Reservation_Filter_Module
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class PartyReservationFiltermodule
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                                    .Split()
                                    .ToArray();

            string filter = Console.ReadLine();
            List<string> filters = new List<string>();

            //Add filter;Starts with;P
            while (filter != "Print")
            {
                string[] filterInfo = filter.Split(';');

                string action = filterInfo[0];

                if (action == "Add filter")
                {
                    filters.Add($"{filterInfo[1]};{filterInfo[2]}");
                }
                else if (action == "Remove filter")
                {
                    filters.Remove($"{filterInfo[1]};{filterInfo[2]}");
                }
                filter = Console.ReadLine();
            }

            //•	"Starts with"
            //•	"Ends with"
            //•	"Length"
            //•	"Contains"
            Func<string, int, bool> lengthFilter = (name, lenght) => name.Length == lenght;
            Func<string, string, bool> startWithsFilter = (name, parameter) => name.StartsWith(parameter);
            Func<string, string, bool> endsWithsFilter = (name, parameter) => name.EndsWith(parameter);
            Func<string, string, bool> containsFilter = (name, parameter) => name.Contains(parameter);

            foreach (var currentFilter in filters)
            {
                string[] currentFilterInfo = currentFilter.Split(';');
                string action = currentFilterInfo[0];
                string parameter = currentFilterInfo[1];

                if (action == "Starts with")
                {
                    names = names.Where(name => !startWithsFilter(name, parameter)).ToArray();
                }
                else if(action == "Ends with")
                {
                    names = names.Where(name => !endsWithsFilter(name, parameter)).ToArray();
                }
                else if (action == "Length")
                {
                    int lenght = int.Parse(parameter);
                    names = names.Where(name => !lengthFilter(name, lenght)).ToArray();
                }
                else if (action == "Contains")
                {
                    names = names.Where(name => !containsFilter(name, parameter)).ToArray();
                }
            }
                Console.WriteLine(string.Join(" ",names));
        }
    }
}
