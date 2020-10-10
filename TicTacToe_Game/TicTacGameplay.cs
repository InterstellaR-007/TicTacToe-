using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe_Game
{
    public class TicTacGameplay
    {
        char[] tictac_board;
        public void UC1_TicTacBoard()
        {
            tictac_board = new char[10];
            foreach( var i in tictac_board)
            {
                tictac_board[i] =  ' ';
            }
            Console.WriteLine("Tic Tac board initialised !");

        }
    }
}
