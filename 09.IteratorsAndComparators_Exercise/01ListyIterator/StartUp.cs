namespace _09.IteratorsAndComparators_Exercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            ListyIterator<string> listyiterator = null;

            string command = Console.ReadLine();


            while (command != "END")
            {
                try
                {
                    if (command.Contains("Create"))
                    {
                        List<string> items = command.Split().Skip(1).ToList();
                        listyiterator = new ListyIterator<string>(items);
                    }
                    else if (command == "Print")
                    {
                        listyiterator.Print();
                    }
                    else if (command == "HasNext")
                    {
                        Console.WriteLine(listyiterator.HasNext());
                    }
                    else if (command == "Move")
                    {
                        Console.WriteLine(listyiterator.Move());
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message); ;
                }




                command = Console.ReadLine();
            }
        }
    }
}
