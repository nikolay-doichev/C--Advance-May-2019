namespace LaptopShop
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Laptop
    {
        private string laptopMake;
        private string laptopModel;
        private double laptopDisplaySize;
        private decimal laptopPrice;
        private int laptopRam;
        private int laptopSsd;

        public Laptop(string laptopMake, string laptopModel, double laptopDisplaySize, decimal laptopPrice, int laptopRam, int laptopSsd)
        {
            this.Make = laptopMake;
            this.Model = laptopModel;
            this.DispaySize = laptopDisplaySize;
            this.Price = laptopPrice;
            this.Ram = laptopRam;
            this.Ssd = laptopSsd;
        }

        public string Make { get; set; }

        public string Model { get; set; }

        public double DispaySize { get; set; }

        public decimal Price { get; set; }

        public int Ram { get; set; }

        public int? Ssd { get; set; }

        public string Fullinfo()
        {
            return $"Make: {this.Make} Model: {this.Model} Price: {this.Price:F2}";
            //string
        }
        //Laptop
        //-Make
        //-Model
        //-DispaySize
        //-Price
        //-RAM
        //-SSD
        //--FullInfo
    }
}
