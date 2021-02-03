
using System;

namespace TicTacToi
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("wellcome to Tic Tac Toi Game");
            Program p = new Program();

            p.Gamecaller();
        }
        public void Gamecaller()
        {
            string menu;

            Console.WriteLine(@"         
                                          1. New Game
                                          2. About authore
                                          3. exite");
            menu = Console.ReadLine();
            switch (menu)
            {
                case "1":
                    GameMechanics game = new GameMechanics();
                    game.startgame();
                    break;
                case "2":
                    Console.WriteLine("Hermela kebede is the 1st year student at WSB university in poznan in 2020");
                    break;
                case "3":

                    Console.WriteLine("you have successfully Quit the game");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("wrong entry try again");
                    break;

            }
            Gamecaller();

        }

    }
}