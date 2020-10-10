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

            Console.WriteLine("Enter the Letter 'X' or 'O' :");
            char player_Input = char.Parse(Console.ReadLine());

            ticTac.UC2_LetterAssign(player_Input);

            ticTac.UC3_ShowBoard();
        }
    }
}
