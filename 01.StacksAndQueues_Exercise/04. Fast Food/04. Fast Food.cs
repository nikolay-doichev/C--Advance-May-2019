using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> orders = new Queue<int>(array);

            Console.WriteLine(orders.Max());

            for (int index = 0; index < array.Length; index++)
            {
                //20 54 30 16 7 9
                int currentOrder = array[index];
                
                if (foodQuantity >= currentOrder)
                {
                    foodQuantity -= orders.Dequeue();
                }
                else
                {
                    Console.Write($"Orders left: {string.Join(' ', orders)}");
                    return;
                }
            }
            if (orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
