namespace _05GenericCountMethodString
{
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Box<string> box = new Box<string>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                box.Add(input);
            }
            string stringToComapare = Console.ReadLine();

            box.Campare(stringToComapare);

            Console.WriteLine(box.CountGreater);

        }
    }
}
