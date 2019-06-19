namespace _06GenericCountMethodDouble
{
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Box<double> box = new Box<double>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                double input = double.Parse(Console.ReadLine());
                box.Add(input);
            }
            double stringToComapare = double.Parse(Console.ReadLine());

            box.Campare(stringToComapare);

            Console.WriteLine(box.CountGreater);
        }
    }
}
