namespace _06._Jagged_Array_Modification
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class JaggedArrayModification
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                jaggedArray[i] = numbers;
            }

            string command = string.Empty;
            while ((command = Console.ReadLine())?.ToLower() != "end")
            {
                string[] token = command.Split(' ');
                string operation = token[0].ToLower();
                int row = int.Parse(token[1]);
                int col = int.Parse(token[2]);
                int value = int.Parse(token[3]);

                if (row<0 || row >= rows 
                          || col < 0 
                          || col >= jaggedArray[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }
                switch (operation)
                {
                    case "add":
                        jaggedArray[row][col] += value;
                        break;
                    case "subtract":
                        jaggedArray[row][col] -= value;
                        break;
                    default:
                        break;
                }
            }
            foreach (var item in jaggedArray)
            {
                Console.WriteLine(string.Join(' ',item));
            }
        }
    }
}
