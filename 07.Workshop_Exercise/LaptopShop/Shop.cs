namespace LaptopShop
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Shop
    {
        private Dictionary<string, List<Laptop>> laptops;

        public Shop()
        {
            this.laptops = new Dictionary<string, List<Laptop>>();
        }
        public int Count => this.laptops.Count;
        public void AddLaptop(Laptop laptop)
        {
            IfnullThrowExpetion(laptop);

            if (!this.laptops.ContainsKey(laptop.Make))
            {
                this.laptops.Add(laptop.Make, new List<Laptop>());
            }

            this.laptops[laptop.Make].Add(laptop);

        }

        private void IfnullThrowExpetion(Laptop laptop)
        {
            if (laptop == null)
            {
                throw new ArgumentNullException(nameof(laptop), "Object cannot be null!");
            }
        }

        public bool RemoveLaptop(Laptop laptop)
        {
            IfnullThrowExpetion(laptop);

            if (!this.laptops.ContainsKey(laptop.Make))
            {
                return false;
            }

            if (!this.laptops[laptop.Make].Contains(laptop))
            {
                return false;
            }

            bool isRemove = this.laptops[laptop.Make].Remove(laptop);
            if (this.laptops[laptop.Make].Count == 0)
            {
                isRemove = this.laptops.Remove(laptop.Make);
            }
            return isRemove;
        }
        public void PrintAllLaptops(Action<Laptop> action)
        {
            foreach (var (make,dictlaptops) in this.laptops)
            {
                foreach (var laptop in dictlaptops)
                {
                    action(laptop);
                }
            }
        }
        public bool ContainsLaptop(Laptop laptop)
        {
            IfnullThrowExpetion(laptop);
            if (!this.laptops.ContainsKey(laptop.Make))
            {
                return false;
            }

            if (!this.laptops[laptop.Make].Contains(laptop))
            {
                return false;
            }
            return true;
        }



        
        //PrintAllLaptops
    }
}
