using System;
using System.Collections.Generic;

namespace _06._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] children = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Queue<string> queue = new Queue<string>(children);

            int n = int.Parse(Console.ReadLine());

            while (queue.Count>1)
            {
                for (int i = 0; i < n-1; i++)
                {
                    string player = queue.Dequeue();
                    queue.Enqueue(player);
                }

                Console.WriteLine($"Removed {queue.Dequeue()}");
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
