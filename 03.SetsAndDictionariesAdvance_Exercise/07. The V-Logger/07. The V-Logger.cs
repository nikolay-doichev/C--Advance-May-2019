namespace _07._The_V_Logger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class TheVLoger
    {
        static void Main(string[] args)
        {
            var vlogerCollection = new Dictionary<string, Dictionary<string, HashSet<string>>>();

            string input = Console.ReadLine();

            while (input != "Statistics")
            {
                if (input.Contains("joined"))
                {
                    //EmilConrad joined The V-Logger
                    string username = input.Split(' ')[0];

                    if (!vlogerCollection.ContainsKey(username))
                    {
                        vlogerCollection.Add(username, new Dictionary<string, HashSet<string>>());

                        vlogerCollection[username].Add("followings", new HashSet<string>());
                        vlogerCollection[username].Add("followers", new HashSet<string>());
                    }
                }

                else if (input.Contains("followed"))
                {
                    //Saffrona joined The V-Logger
                    string[] usernames = input.Split(" ");

                    string firstVlogger = usernames[0];
                    string secondVlogger = usernames[2];
                    if (!vlogerCollection.ContainsKey(firstVlogger) || !vlogerCollection.ContainsKey(secondVlogger) || firstVlogger == secondVlogger)
                    {
                        input = Console.ReadLine();
                        continue;
                    }

                    vlogerCollection[firstVlogger]["followings"].Add(secondVlogger);
                    vlogerCollection[secondVlogger]["followers"].Add(firstVlogger);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"The V-Logger has a total of {vlogerCollection.Count} vloggers in its logs.");

            int count = 1;

            var sortedVloger = vlogerCollection
                .OrderByDescending(f => f.Value["followers"].Count)
                .ThenBy(f => f.Value["followings"].Count)
                .ToDictionary(k => k.Key, y => y.Value);
            foreach (var (username, value) in sortedVloger)
            {

            int follewrsCount = sortedVloger[username]["followers"].Count;
            int follewingsCount = sortedVloger[username]["followings"].Count;

                Console.WriteLine($"{count}. {username} : {follewrsCount} followers, {follewingsCount} following");
                if (count == 1)
                {
                    var followersCollection = value["followers"].OrderBy(x => x).ToList();
                    foreach (var currentUsername in followersCollection)
                    {
                        Console.WriteLine($"*  {currentUsername}");
                    }
                }
                count++;
            }

        }
    }
}
