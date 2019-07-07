﻿namespace ExamPreparetion_16._04._2019_RetakeExam
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class TrojanInvasion
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> platesList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            Stack<int> warriorsStack = new Stack<int>();
            //Queue<int> platesQueue = new Queue<int>(platesList);

            for (int i = 1; i <= n; i++)
            {
                List<int> warriorsList = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                AddWarriors(warriorsStack, warriorsList);

                if (i % 3 == 0)
                {
                    int additionalPlate = int.Parse(Console.ReadLine());
                    platesList.Add(additionalPlate);
                }

                while (warriorsStack.Count>0 && platesList.Count>0)
                {
                    int currentWarrior = warriorsStack.Pop();
                    int currentPlate = platesList[0];

                    if (currentWarrior > currentPlate)
                    {
                        currentWarrior -= currentPlate;
                        warriorsStack.Push(currentWarrior);
                        platesList.RemoveAt(0);
                    }
                    else if (currentWarrior<currentPlate)
                    {
                        currentPlate -= currentWarrior;
                        platesList[0] = currentPlate;
                    }
                    else
                    {
                        platesList.RemoveAt(0);
                    }
                }
                if (platesList.Count==0)
                {
                    break;
                }
            }
            if (platesList.Count == 0 )
            {
                Console.WriteLine("The Trojans successfully destroyed the Spartan defense.");
                Console.WriteLine($"Warriors left: {string.Join(", ",warriorsStack)}");
            }
            else
            {
                Console.WriteLine("The Spartans successfully repulsed the Trojan attack.");
                Console.WriteLine($"Plates left: {string.Join(", ",platesList)}");
            }
        }

        private static void AddWarriors(Stack<int> warriorsStack, List<int> warriorsList)
        {
            foreach (var warrior in warriorsList)
            {
                warriorsStack.Push(warrior);
            }
        }
    }
}
