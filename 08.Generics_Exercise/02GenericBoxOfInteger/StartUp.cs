namespace _02GenericBoxOfInteger
{
    using System;   
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Box<int> box = new Box<int>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                int input = int.Parse(Console.ReadLine());
                box.Add(input);
            }
                       
            var result = box.ToString();
            Console.WriteLine(result);
        }
    }
}
