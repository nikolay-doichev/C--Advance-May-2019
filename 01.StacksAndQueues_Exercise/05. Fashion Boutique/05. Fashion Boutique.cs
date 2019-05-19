using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] array = Console.ReadLine()
                                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToArray();
            int rack = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>(array);
            int rackSum = 0;
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int clothes = stack.Pop();
                rackSum += clothes;
                //5 4 8 6 3 8 7 7 9
               
                if (rackSum>rack)
                {
                    counter++;
                    rackSum = 0;
                    rackSum += clothes;
                }
                else if (rackSum==rack)
                {
                    counter++;
                    rackSum = 0;
                }
                //1 7 8 2 5 4 7 8 9 6 3 2 5 4 6
            }
            if (rackSum>0 && rackSum<rack)
            {
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}
