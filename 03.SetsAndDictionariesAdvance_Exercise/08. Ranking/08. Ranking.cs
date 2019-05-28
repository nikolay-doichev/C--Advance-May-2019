namespace _08._Ranking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Ranking
    {
        static void Main(string[] args)
        {
           
            var contest = new Dictionary<string, string>();
            var submissions = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "end of contests")
            {
                //Part One Interview:success
                string[] tokens = input.Split(':');
                string contestName = tokens[0];
                string password = tokens[1];

                if (!contest.ContainsKey(contestName))
                {
                    contest.Add(contestName, password);
                }
                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input!= "end of submissions")
            {
                //C# Fundamentals=>fundPass=>Tanya=>350
                string[] tokens = input.Split("=>");
                string contestName = tokens[0];
                string contestPass = tokens[1];
                string username = tokens[2];
                int points = int.Parse(tokens[3]);

                if (!contest.ContainsKey(contestName) || contest[contestName] != contestPass)
                {
                    input = Console.ReadLine();
                    continue;
                }
                if (!submissions.ContainsKey(username))
                {
                    submissions.Add(username, new Dictionary<string, int>());
                }
                if (!submissions[username].ContainsKey(contestName))
                {
                    submissions[username].Add(contestName, 0);
                }
                if (submissions[username][contestName]<points)
                {
                    submissions[username][contestName] = points;
                }
                input = Console.ReadLine();
            }
            var bestCandidate = submissions.OrderByDescending(v => v.Value.Values.Sum(x => x))
                .FirstOrDefault();

            string bestCandidateName = bestCandidate.Key;
            int topPoints = bestCandidate.Value.Values.Sum(x => x);

            Console.WriteLine($"Best candidate is {bestCandidateName} with total {topPoints} points.");
            Console.WriteLine("Ranking:");

            foreach (var (key,value) in submissions.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{key}");

                foreach (var (contestName, points) in value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contestName} -> {points}");
                }
            }
        }
    }
}
