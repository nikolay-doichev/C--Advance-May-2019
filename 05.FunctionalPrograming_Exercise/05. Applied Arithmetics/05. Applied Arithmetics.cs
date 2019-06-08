namespace _05._Applied_Arithmetics
{
    using System;
    using System.Linq;
    class AppliedArithmetics
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
            //1 2 3 4 5
            string input = Console.ReadLine();
            //add
            //add
            //print
            //end

            Func<int[], int[]> addFunction = numbersForAdd =>
            {
                for (int i = 0; i < numbersForAdd.Length; i++)
                {
                    numbersForAdd[i] ++;
                }
                return numbersForAdd;
            };

            Func<int[], int[]> multiplyFunction = numbersForMultiply =>
            {
                for (int i = 0; i < numbersForMultiply.Length; i++)
                {
                    numbersForMultiply[i]*=2;
                }
                return numbersForMultiply;
            };

            Func<int[], int[]> subtractFunction = numbersForSubtract =>
            {
                for (int i = 0; i < numbersForSubtract.Length; i++)
                {
                    numbersForSubtract[i]--;
                }
                return numbersForSubtract;
            };

            Action<int[]> printNumbers = numbersForPrint =>
            {
                for (int i = 0; i < numbersForPrint.Length; i++)
                {
                    Console.Write($"{numbersForPrint[i]} ");
                }
                Console.WriteLine();
            };

            while (input!="end")
            {
                if (input== "add")
                {
                    addFunction(numbers);
                }
                else if (input == "multiply")
                {
                    multiplyFunction(numbers);
                }
                else if (input == "subtract")
                {
                    subtractFunction(numbers);
                }
                else if (input == "print")
                {
                    printNumbers(numbers);
                    
                }
                input = Console.ReadLine();
            }
        }
    }
}
