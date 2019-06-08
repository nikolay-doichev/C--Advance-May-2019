namespace _03._Custom_Min_Function
{
    using System;
    using System.Linq;
    class CustomMinFunction
    {
        static void Main(string[] args)
        {
            Func<int[], int> minFunction = numbers =>
             {
                 int minValue = int.MaxValue;

                 foreach (var number in numbers)
                 {
                     if (number<minValue)
                     {
                         minValue = number;
                     }
                 }
                 return minValue;
             };
            Action<int> printNumber = x => Console.WriteLine(x);
            int[] inputNames = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int minNumber = minFunction(inputNames);
            printNumber(minNumber);
        }
    }
}
