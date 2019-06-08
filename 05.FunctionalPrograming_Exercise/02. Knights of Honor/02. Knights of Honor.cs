namespace _02._Knights_of_Honor
{
    using System;
    using System.Linq;
    class KnightsOfHonor
    {
        static void Main(string[] args)
        {
            Action<string[]> printNames = names => Console.WriteLine("Sir " + string.Join(Environment.NewLine + "Sir ", names));

            string[] inputNames = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            printNames(inputNames);
        }
    }
}
