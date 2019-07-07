namespace _02._Helen_s_Abduction
{
    using System;
    using System.Collections.Generic;
    using System.Linq;    
    public class HelensAbduction
    {
        static int parisRow;
        static int parisCol;
        public static void Main(string[] args)
        {
            //Read the input
            //  --Energy, fuiledRows,field
            //Initialize matrix
            //While Parissive alive
            //  -Process Turn
            //    -- Spawn Spartans
            //    --Move Paris
            //    --Chek next Possition
            //    #S -> Decrease energy
            //    #H -> Win the game
            //Print Output

            int energy = int.Parse(Console.ReadLine());
            int rowsCount = int.Parse(Console.ReadLine());

            char[][] field = new char[rowsCount][];
            InitializeMatrix(field);
            FindParisPosition(field);

            bool won = false;

            while (energy>0)
            {
                string[] turn = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string moveDiretion = turn[0];
                int spawnRow = int.Parse(turn[1]);
                int spawnCol = int.Parse(turn[2]);

                SpawnSpartans(field, spawnRow, spawnCol);

                field[parisRow][parisCol] = '-';

                MoveInDertion(field, moveDiretion);
                energy--;

                char symbolOnNextStep = field[parisRow][parisCol];

                if (symbolOnNextStep == 'S')
                {
                    energy -= 2;
                    field[parisRow][parisCol] = 'P';
                }
                else if (symbolOnNextStep == 'H')
                {
                    won = true;
                    field[parisRow][parisCol] = '-';
                    break;
                }
                else if (symbolOnNextStep == '-')
                {
                    field[parisRow][parisCol] = 'P';
                }

                if (energy <= 0)
                {
                    field[parisRow][parisCol] = 'X';
                    break;
                }
            }

            PrintOutPut(field, won, energy);
        }

        private static void PrintOutPut(char[][] field, bool won, int energy)
        {
            if (won)
            {
                Console.WriteLine($"Paris has successfully abducted Helen! Energy left: {energy}");
            }
            else
            {
                Console.WriteLine($"Paris died at {parisRow};{parisCol}.");
            }

            PrintMatrix(field);
        }

        private static void PrintMatrix(char[][] field)
        {
            for (int row = 0; row < field.Length; row++)
            {
                char[] currentRow = field[row];
                Console.WriteLine(string.Join("",currentRow));
            }
        }

        private static void MoveInDertion(char[][] field, string moveDiretion)
        {
            if (moveDiretion == "up")
            {
                if (parisRow-1 >= 0)
                {
                    parisRow--;
                }
            }
            else if (moveDiretion == "down")
            {
                if (parisRow + 1 <field.Length)
                {
                    parisRow++;
                }
            }
            else if (moveDiretion == "left")
            {
                if (parisCol - 1 >= 0)
                {
                    parisCol--;
                }
            }
            else if (moveDiretion == "right")
            {
                if (parisCol + 1 < field[parisRow].Length)
                {
                    parisCol++;
                }
            }
        }

        private static void SpawnSpartans(char[][] field, int spawnRow, int spawnCol)
        {
            field[spawnRow][spawnCol] = 'S';
        }

        private static void FindParisPosition(char[][] field)
        {
            bool found = false;
            for (int row = 0; row < field.Length; row++)
            {
                for (int col = 0; col < field[row].Length; col++)
                {
                    char symbol = field[row][col];

                    if (symbol == 'P')
                    {
                        parisRow = row;
                        parisCol = col;
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
    }
}
