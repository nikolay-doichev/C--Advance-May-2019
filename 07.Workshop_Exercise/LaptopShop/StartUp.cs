namespace LaptopShop
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var list = new List<int>();
            string laptopMake = "Asus";
            string laptopModel = "Rog HV34134";
            double laptopDisplaySize = 15.3;
            decimal laptopPrice = 333;
            int laptopRam = 32;
            int laptopSsd = 256;

            Laptop laptop = new Laptop(laptopMake,laptopModel, laptopDisplaySize, laptopPrice, laptopRam, laptopSsd);
            Console.WriteLine(laptop.Make);
            //Laptop
            //-Make
            //-Model
            //-DispaySize
            //-Price
            //-RAM
            //-SSD
            //--FullInfo
            var shop = new Shop();
            shop.AddLaptop(laptop);
            shop.PrintAllLaptops(x => Console.WriteLine(x.Fullinfo()));
            
            Console.WriteLine(shop.ContainsLaptop(laptop));
            //Shop
            //-Laptops
            //-Count
            //--AddLaptop
            //--RemoveLaptop
            //--ContainsLaptop
            //PrintAllLaptops
        }
    }
}
