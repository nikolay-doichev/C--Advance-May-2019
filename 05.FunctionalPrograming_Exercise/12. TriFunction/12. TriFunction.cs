namespace _12._TriFunction
{
    using System;
    using System.Linq;
    class TriFunction
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine().Split(' ');

            //Qvor Qnaki Petromir Sadam
            Func<string, int, bool> isLarger = (name, charsLengh)
                => name.Sum(x => x) >= charsLengh;
            Func<string[], Func<string, int, bool>, string> nameFilter
                = (inputNames, isLargerFilter) => inputNames
                .FirstOrDefault(x => isLargerFilter(x,lenght));

            string resultName = nameFilter(names, isLarger);
            Console.WriteLine(resultName);
        }
    }
}
