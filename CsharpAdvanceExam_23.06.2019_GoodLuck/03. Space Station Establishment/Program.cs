using System;

namespace _03._Space_Station_Establishment
{
    class Program
    {
        static int StephanRow;
        static int StephanCol;

        static int SecondBlackHoleRow;
        static int SecondBlackHoleCol;
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());

            char[][] field = new char[numberOfRows][];
            InitializeMatrix(field);
            FindStephanPosition(field);
            bool isInVoid = false;
            int stars = 0;

            while (stars<50)
            {
                string direction = Console.ReadLine();

                field[StephanRow][StephanCol] = '-';

                if (direction == "up")
                {
                    if (StephanRow-1 >= 0)
                    {
                        StephanRow--;
                    }
                    else
                    {
                        isInVoid = true;
                        break;
                    }
                }
                else if (direction == "down")
                {
                    if (StephanRow+1 < field.Length)
                    {
                        StephanRow++;
                    }
                    else
                    {
                        isInVoid = true;
                        break;
                    }
                }
                else if (direction == "left")
                {
                    if (StephanCol - 1 >= 0)
                    {
                        StephanCol--;
                    }
                    else
                    {
                        isInVoid = true;
                        break;
                    }
                }
                else if (direction == "right")
                {
                    if (StephanCol + 1 < field.Length)
                    {
                        StephanCol++;
                    }
                    else
                    {
                        isInVoid = true;
                        break;
                    }
                }
                
                char symbolOnNextStep = field[StephanRow][StephanCol];

                if (symbolOnNextStep == 'O')
                {
                    BlackHole(field, SecondBlackHoleRow, SecondBlackHoleCol);
                    field[StephanRow][StephanCol] = '-';
                    StephanRow = SecondBlackHoleRow;
                    StephanCol = SecondBlackHoleCol;
                    field[StephanRow][StephanCol] = 'S';
                }
                else if (char.IsDigit(symbolOnNextStep))
                {
                    int startForCollect = (int)char.GetNumericValue(symbolOnNextStep);
                    stars += startForCollect;
                    field[StephanRow][StephanCol] = 'S';
                }
            }
            PrintOutPut(field, isInVoid, stars);
        }
        private static void PrintOutPut(char[][] field, bool isInVoid, int stars)
        {
            if (isInVoid)
            {
                Console.WriteLine("Bad news, the spaceship went to the void.");
                Console.WriteLine($"Star power collected: {stars}");
            }
            else
            {
                Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
                Console.WriteLine($"Star power collected: {stars}");
            }

            PrintMatrix(field);
        }
        private static void PrintMatrix(char[][] field)
        {
            for (int row = 0; row < field.Length; row++)
            {
                char[] currentRow = field[row];
                Console.WriteLine(string.Join("", currentRow));
            }
        }
        private static void BlackHole(char[][] field, int secondBlackHoleRow, int secondBlackHoleCol)
        {
            bool found = false;
            for (int row = StephanRow; row < field.Length; row++)
            {                
                for (int col = StephanCol; col < field[row].Length; col++)
                {
                    char symbol = field[row][col];

                    if (symbol == 'O')
                    {
                        SecondBlackHoleRow = row;
                        SecondBlackHoleCol = col;
                        found = true;
                        break;
                    }                   
                }
                if (found) break;
            }
        }
        private static void InitializeMatrix(char[][] field)
        {
            for (int row = 0; row < field.Length; row++)
            {
                char[] currentRow = Console.ReadLine().ToCharArray();

                field[row] = currentRow;
            }
        }
        private static void FindStephanPosition(char[][] field)
        {
            bool found = false;
            for (int row = 0; row < field.Length; row++)
            {
                for (int col = 0; col < field[row].Length; col++)
                {
                    char symbol = field[row][col];

                    if (symbol == 'S')
                    {
                        StephanRow = row;
                        StephanCol = col;
                        found = true;
                        break;
                    }
                }
                if (found) break;
            }
        }
    }
}
