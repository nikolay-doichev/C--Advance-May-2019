namespace _02Collection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
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
                    else if (command == "PrintAll")
                    {
                        foreach (var item in listyiterator)
                        {
                            Console.Write(item + " ");
                        }
                        Console.WriteLine();
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
