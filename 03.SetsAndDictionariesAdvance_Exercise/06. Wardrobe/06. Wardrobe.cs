namespace _06._Wardrobe
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Wardrobe
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string,int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            

            for (int index = 0; index < n; index++)
            {
                //Blue -> dress,jeans,hat
                var input = Console.ReadLine().Split(" -> ",StringSplitOptions.RemoveEmptyEntries);
                string colour = input[0];
                var clothes = input[1].Split(",", StringSplitOptions.RemoveEmptyEntries);

                if (!wardrobe.ContainsKey(colour))
                {
                    wardrobe[colour] = new Dictionary<string, int>();
                }

                for (int indexForClothes = 0; indexForClothes < clothes.Length; indexForClothes++)
                {
                    string currentClothe = clothes[indexForClothes];
                    if (!wardrobe[colour].ContainsKey(clothes[indexForClothes]))
                    {
                        wardrobe[colour].Add(currentClothe, 1);
                    }
                    else
                    {
                        wardrobe[colour][currentClothe]++;
                    }

                }

            }

            //Blue dress
            var searchedClothes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var searchedColour = searchedClothes[0];
            var searcheClothe = searchedClothes[1];

            foreach (var item in wardrobe)
            {
                Console.WriteLine($"{item.Key} clothes: ");

                foreach (var clothe in item.Value)
                {
                    if (item.Key==searchedColour && clothe.Key==searcheClothe)
                    {
                        Console.WriteLine($"* {clothe.Key} - {clothe.Value} (found!)");
                        continue;
                    }
                    Console.WriteLine($"* {clothe.Key} - {clothe.Value}");
                }
            }
        }
    }
}
