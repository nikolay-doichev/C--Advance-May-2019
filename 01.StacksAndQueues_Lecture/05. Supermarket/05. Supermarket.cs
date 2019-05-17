using System;
using System.Collections.Generic;

namespace _5._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Queue<string> queue = new Queue<string>();
            int count = 0;

            while (input != "End")
            {
                if (input =="Paid")
                {
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                    queue.Clear();
                    count = 0;
                }
                else
                {
                    queue.Enqueue(input);
                    count++;
                }                
                input = Console.ReadLine();
            }
            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
