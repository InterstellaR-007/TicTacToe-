using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TicTacToe_Game
{
    public class TicTacGameplay
    {
        char[] tictac_board;
        char player_Input = ' ';
        char computer_Input = ' ';
        char[] LetterIndex = { 'X', 'O' };
        String input_ValidationString =  "[XO]{1}";

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
            
            Regex regex = new Regex(input_ValidationString);
            Match match = regex.Match(player_Input.ToString());

            if(match.Success) 
            {
                this.player_Input = player_Input;
                Random random = new Random();
                int input_CompIndex = random.Next(0, 2);
                computer_Input = LetterIndex[input_CompIndex];

                Console.WriteLine("Player Selected Letter is : " + player_Input);
                Console.WriteLine("Computer Selected Letter is : " + computer_Input);
            }
            else
            {
                Console.WriteLine("Invalid Player Input");
            }

         
        }
    }
}
