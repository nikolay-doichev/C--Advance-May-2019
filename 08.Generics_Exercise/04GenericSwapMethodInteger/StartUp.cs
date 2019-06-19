namespace _04GenericSwapMethodInteger
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

            string[] indexers = Console.ReadLine().ToString().Split(' ');
            int firstIndex = int.Parse(indexers[0]);
            int secondIndex = int.Parse(indexers[1]);
            box.Swap(firstIndex, secondIndex);
            var result = box.ToString();
            Console.WriteLine(result);
        }
    }
}
