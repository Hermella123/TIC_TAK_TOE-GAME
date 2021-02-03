
using System;

namespace TicTacToi
{
    class GameBoard : GameMechanics
    {
        public static void displayBoard()
        {
            for (int i = 0; i < 9; i++)
            {
                if ((i == 1) || (i == 4) || (i == 7))
                {
                    Console.Write(" ");
                }
                Console.Write(arr[i] + " ");
                if (arr[i] == null)
                {
                    Console.Write(" ");
                }
                if ((i == 2) || (i == 5) || (i == 8))
                {
                    Console.WriteLine();
                }
                if ((i == 2) || (i == 5))
                {
                    Console.WriteLine("_ + _ + _");
                }
                if ((i == 0) || (i == 1) || (i == 3) || (i == 4) || (i == 6) || (i == 7))
                {
                    Console.Write("|");
                }
            }
        }
    }
}