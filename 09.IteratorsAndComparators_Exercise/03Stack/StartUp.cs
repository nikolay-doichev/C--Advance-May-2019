namespace _03Stack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            CustomStack<int> stack = new CustomStack<int>();

            string input = Console.ReadLine();

            while (input != "END")
            {

                try
                {
                    if (input.Contains("Pop"))
                    {
                        stack.Pop();
                    }
                    else if (input.Contains("Push"))
                    {
                        string itemsForPush = input.Substring(5);
                        List<int> items = itemsForPush.Split(", ").Select(int.Parse).ToList();

                        foreach (var item in items)
                        {
                            stack.Push(item);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);                    
                }

                input = Console.ReadLine();
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
