namespace CsharpAdvanceExam_23._06._2019_GoodLuck
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class SpaceshipCrafting
    {
        public static void Main(string[] args)
        {
            //go-for-the-win

            Queue<int> liquids = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            List<int> physicalItems = new List<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            int glass = 0; //25
            int aluminium = 0;  //50
            int lithium = 0;  //75
            int carbonFiber = 0; //100
            bool makedSpaceship = false;

            while (liquids.Count > 0 && physicalItems.Count > 0)
            {
                //1 25 50 50 Liquids
                //50 25 25 24 physical items
                int currentLiquids = liquids.Dequeue();
                int currentItem = physicalItems[physicalItems.Count - 1];

                

                if (currentLiquids + currentItem == 25 ||
                    currentLiquids + currentItem == 50 ||
                    currentLiquids + currentItem == 75 ||
                    currentLiquids + currentItem == 100)
                {
                    int result = currentItem + currentLiquids;
                    switch (result)
                    {
                        case 25:
                            glass++;
                            break;
                        case 50:
                            aluminium++;
                            break;
                        case 75:
                            lithium++;
                            break;
                        case 100:
                            carbonFiber++;
                            break;
                    }
                    physicalItems.RemoveAt(physicalItems.Count - 1);
                }
                else
                {
                    currentItem += 3;
                    physicalItems.RemoveAt(physicalItems.Count - 1);
                    physicalItems.Add(currentItem);

                }
                if (glass > 0 && aluminium > 0 && lithium > 0 && carbonFiber > 0)
                {
                    makedSpaceship = true;
                }
            }
            if (makedSpaceship)
            {
                Console.WriteLine("Wohoo! You succeeded in building the spaceship!");

                if (liquids.Count == 0)
                {
                    Console.WriteLine("Liquids left: none");
                }
                else
                {
                    Console.WriteLine($"Liquids left: {string.Join(", ", liquids)}");
                }
                if (physicalItems.Count==0)
                {
                    Console.WriteLine("Physical items left: none");
                }
                else
                {
                    Console.WriteLine($"Physical items left: {string.Join(", ", physicalItems)}");
                }
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");

                if (liquids.Count == 0)
                {
                    Console.WriteLine("Liquids left: none");
                }
                else
                {
                    Console.WriteLine($"Liquids left: {string.Join(", ", liquids)}");
                }
                if (physicalItems.Count == 0)
                {
                    Console.WriteLine("Physical items left: none");
                }
                else
                {
                    physicalItems.Reverse();
                    Console.WriteLine($"Physical items left: {string.Join(", ", physicalItems)}");
                }
            }           

            Console.WriteLine($"Aluminium: {aluminium}");
            Console.WriteLine($"Carbon fiber: {carbonFiber}");
            Console.WriteLine($"Glass: {glass}");
            Console.WriteLine($"Lithium: {lithium}");
        }
    }
}
