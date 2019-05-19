﻿namespace _06._Auto_Repair_and_Service
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
       public static void Main(string[] args)
        {
            string[] carModels = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Queue<string> queueOfCars = new Queue<string>(carModels);

            Stack<string> servedCars = new Stack<string>();

            string input = Console.ReadLine();

            while (input!="End")
            {
                if (input== "Service" && queueOfCars.Count>0)
                {
                    string currentCar = queueOfCars.Dequeue();
                    servedCars.Push(currentCar);
                    Console.WriteLine($"Vehicle {currentCar} got served.");
                }
                else if (input.Contains("CarInfo"))
                {
                    string carName = input.Split('-')[1];
                    if (queueOfCars.Contains(carName))
                    {
                        Console.WriteLine($"Still waiting for service.");
                    }
                    else
                    {
                        Console.WriteLine("Served.");
                    }
                }
                else if (input == "History")
                {
                    Console.WriteLine(string.Join(", ",servedCars));
                }
                
                input = Console.ReadLine();
            }
            if (queueOfCars.Count>0)
            {
                Console.WriteLine($"Vehicles for service: { string.Join(", ", queueOfCars)}");
            }
            if (servedCars.Count>0)
            {
                Console.WriteLine($"Served vehicles: { string.Join(", ", servedCars)}");
            }
        }
    }
}
