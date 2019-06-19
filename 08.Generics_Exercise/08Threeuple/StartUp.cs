namespace _08Threeuple
{
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] personInfo = Console.ReadLine().Split(" ");

            string[] personBeerInfo = Console.ReadLine().Split(" ");

            string[] numbersInfo = Console.ReadLine().Split(" ");

            string personName = personInfo[0] + " " + personInfo[1];
            string personAdress = personInfo[2];
            string personTown = personInfo[3];
            Tuple<string, string, string> personTuple = new Tuple<string, string, string>(personName,personAdress, personTown);

            string persenBeerName = personBeerInfo[0];
            int amountOfBeer = int.Parse(personBeerInfo[1]);
            string drinkOrNot = personBeerInfo[2] == "drunk" ? "True" : "False"; 
            Tuple<string, int, string> personBeerTuple = new Tuple<string, int, string>(persenBeerName, amountOfBeer, drinkOrNot);

            string bankAcountName = numbersInfo[0];
            double acountBalance = double.Parse(numbersInfo[1]);
            string bankName = numbersInfo[2];

            Tuple<string, double, string> numbersTuple = new Tuple<string, double,string>(bankAcountName, acountBalance, bankName);

            Console.WriteLine(personTuple.GetInfo());
            Console.WriteLine(personBeerTuple.GetInfo());
            Console.WriteLine(numbersTuple.GetInfo());
        }
    }
}
