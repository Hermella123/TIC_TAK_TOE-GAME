
using System;

namespace TicTacToi
{
    class GameMechanics
    {

        public static string player = "x";
        public static string[] arr = new string[9];
        public static int counter = 0;
        public static string winner = "";
        public static bool win = false;
        public void startgame()
        {
            while (counter < 9 && win == false)
            {

                GameMoves();

                GameBoard.displayBoard();
                Wincheacker();
                if (win)
                {

                    break;
                }
                changeplayer();
                counter++;
            }
            Gameover();

            counter = 0;
            winner = "";
         win = false;
            for (int j=0; j<9; j++)
            {
                arr[j] = null;
            }

            return;
        }
        public void changeplayer()
        {
            if (!win)
            {
                if (player == "x")
                {
                    player = "o";
                }
                else if (player == "o")
                {
                    player = "x";
                }
            }

        }
        public void Gameover()
        {
            if (!win)
                Console.WriteLine("no winner");
            else
                Console.WriteLine(winner + " winns");
            Console.WriteLine("Game over!!!!");
        }
        public void GameMoves()
        {

            int num;

            Console.WriteLine("\n\n" + player + "'s move");
            while (!(int.TryParse(Console.ReadLine(), out num) && num <= 10 && num >= 1 && arr[num - 1] == null))
            {
                Console.WriteLine("wrong entry try again.");
            }

            if (player == "x")
            {
                arr[num - 1] = "x";
            }
            else if (player == "o")
            {
                arr[num - 1] = "o";
            }

        }
        public void Wincheacker()
        {
            if ((arr[0] == player && arr[1] == player && arr[2] == player) || (arr[1] == player && arr[4] == player && arr[7] == player))
            {
                win = true;
                winner = player;
            }
            else if ((arr[0] == player && arr[3] == player && arr[6] == player) || (arr[3] == player && arr[4] == player && arr[5] == player))
            {
                win = true;
                winner = player;
            }
            else if ((arr[2] == player && arr[5] == player && arr[8] == player) || (arr[6] == player && arr[7] == player && arr[8] == player))
            {
                win = true;
                winner = player;

            }
            else if ((arr[0] == player && arr[4] == player && arr[8] == player) || (arr[2] == player && arr[4] == player && arr[6] == player))
            {
                win = true;
                winner = player;
            }


        }

    }
}