using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe_Game
{
    public class TicTacGameplay
    {
        char[] tictac_board;
        char player_Input = ' ';
        char computer_Input = ' ';
        char[] LetterIndex = { 'X', 'O' };

        public void UC1_TicTacBoard()
        {
            tictac_board = new char[10];
            foreach( var i in tictac_board)
            {
                tictac_board[i] =  ' ';
            }
            Console.WriteLine("Tic Tac board initialised !");

        }
        public void UC2_LetterAssign(char player_Input)
        {
            this.player_Input = player_Input;
            Random random = new Random();
            int input_CompIndex = random.Next(0, 2);
            computer_Input = LetterIndex[input_CompIndex];

            Console.WriteLine("Player Selected Letter is : " + player_Input);
            Console.WriteLine("Computer Selected Letter is : " + computer_Input);

        }
    }
}
