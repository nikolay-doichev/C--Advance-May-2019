namespace _04._Even_Times
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class EvenTimes
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> evenNumbers = new Dictionary<int, int>();

            for (int index = 0; index < n; index++)
            {
                int number = int.Parse(Console.ReadLine());

                if (!evenNumbers.ContainsKey(number))
                {
                    evenNumbers[number] = 1;
                }
                else
                {
                    evenNumbers[number]++;
                }
            }

            foreach (var number in evenNumbers)
            {
                if (number.Value %2 == 0)
                {
                    Console.WriteLine(number.Key);
                }
            }
        }
    }
}
