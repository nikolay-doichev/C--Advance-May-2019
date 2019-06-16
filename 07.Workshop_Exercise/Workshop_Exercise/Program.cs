using System;

namespace Workshop
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var doublyLinedList = new DoubleLinkedList<string>();

            doublyLinedList.AddLast("string");
            doublyLinedList.AddLast("12312");
            doublyLinedList.AddLast("12343213");
            doublyLinedList.AddLast("test");

            Console.WriteLine(doublyLinedList.Contains("test"));
        }
    }
}