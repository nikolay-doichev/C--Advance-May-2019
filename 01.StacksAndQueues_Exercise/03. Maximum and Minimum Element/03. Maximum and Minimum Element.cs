using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int operation = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < operation; i++)
            {
                string input = Console.ReadLine();
                char command = input[0];
                if (command == '1')
                {
                    var arr = input.Split(' ').Select(int.Parse).ToArray();
                    int number =arr[1];
                    stack.Push(number);
                }
                else if (command == '2' && stack.Count>0)
                {
                    stack.Pop();
                }
                else if (command == '3' && stack.Count > 0)
                {
                    Console.WriteLine(stack.Max());
                }
                else if (command == '4' && stack.Count > 0)
                {
                    Console.WriteLine(stack.Min());
                }
            }
            stack.ToArray();
            Console.WriteLine(string.Join(", ",stack));
        }
    }
}
