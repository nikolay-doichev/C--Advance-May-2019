namespace _04._Add_VAT
{
    using System;
    using System.Linq;
    class AddVAT
    {
        static void Main(string[] args)
        {
            double[] prices = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(p => p * 1.2)
                .ToArray();

            foreach (var item in prices)
            {
                Console.WriteLine($"{item:F2}");
            }
        }
    }
}
