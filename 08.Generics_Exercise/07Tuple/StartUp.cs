namespace _07Tuple
{
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            //Adam Smith -> California
            //Mark-> 2
            //23-> 21.23212321

            string[] personInfo = Console.ReadLine().Split(" ");

            string[] personBeerInfo = Console.ReadLine().Split(" ");

            string[] numbersInfo = Console.ReadLine().Split(" ");

            string personName = personInfo[0] + " " + personInfo[1];
            string personTown = personInfo[2];
            Tuple<string, string> personTuple = new Tuple<string, string>(personName, personTown);

            string persenBeerName = personBeerInfo[0];
            int amountOfBeer = int.Parse(personBeerInfo[1]);
            Tuple<string, int> personBeerTuple = new Tuple<string, int>(persenBeerName,amountOfBeer);

            int myInteger = int.Parse(numbersInfo[0]);
            double myDouble = double.Parse(numbersInfo[1]);
            Tuple<int, double> numbersTuple = new Tuple<int, double>(myInteger,myDouble);

            Console.WriteLine(personTuple.GetInfo());
            Console.WriteLine(personBeerTuple.GetInfo());
            Console.WriteLine(numbersTuple.GetInfo());
        }
    }
}
