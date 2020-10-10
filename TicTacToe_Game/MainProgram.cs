using System;

namespace TicTacToe_Game
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic tac toe game");
            TicTacGameplay ticTac = new TicTacGameplay();
            ticTac.UC1_TicTacBoard();
        }
    }
}
