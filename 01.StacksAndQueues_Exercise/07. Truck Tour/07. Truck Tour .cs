namespace _07._Truck_Tour
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Collections;
    class TruckTour
    {
        static void Main(string[] args)
        {
            Queue<int[]> petrolPumps = new Queue<int[]>();
            int count = int.Parse(Console.ReadLine());
            //3
            for (int i = 0; i < count; i++)
            {
                int[] petrolPump = Console.ReadLine()
                                           .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                           .Select(int.Parse)
                                           .ToArray();

                petrolPumps.Enqueue(petrolPump);
            }

            int index = 0;
            

            while (true)
            {
                int totalFuel = 0;
                foreach (var petrolPump in petrolPumps)
                {                    
                    int petrolAmount = petrolPump[0];
                    int distance = petrolPump[1];
                    
                    totalFuel += petrolAmount - distance;
                    //1 5
                    //10 3
                    //3 4

                    if (totalFuel<0)
                    {
                        petrolPumps.Enqueue(petrolPumps.Dequeue());
                        index++;
                        break;
                    }
                }
                if (totalFuel >= 0)
                {
                    break;
                }
            }
            Console.WriteLine(index);
        }
    }
}
