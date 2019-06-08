namespace _05.FunctionalPrograming_Exercise
{
    using System;
    using System.Linq;
    class ActionPoint
    {
        static void Main(string[] args)
        {
            Action<string[]> printNames = names => Console.WriteLine(string.Join(Environment.NewLine,names)); ;

            string[] inputNames = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            printNames(inputNames);
        }
    }
}
