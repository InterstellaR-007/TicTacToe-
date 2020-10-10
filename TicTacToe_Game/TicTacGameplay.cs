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
        int player_Index = 0;
        char computer_Input = ' ';
        char[] LetterIndex = { 'X', 'O' };
        String input_ValidationString =  "[XO]{1}";

        public void UC1_TicTacBoard()
        {
            tictac_board = new char[10];
            for(int i = 0; i < 10; i++)
            {
                tictac_board[i] = ' ';
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

        public void UC3_ShowBoard()
        {
            for(int i =1; i<10;i=i+3)
            {
                Console.WriteLine("  "+ tictac_board[i] +" | "+ tictac_board[i+1] + " | "+ tictac_board[i+2]);
            }
        }
        public void UC4_IndexOfLetter(int player_Index)
        {
            Regex regex = new Regex(@"[1-9]{1}");
            Match match = regex.Match(player_Index.ToString());
            if (match.Success)
            {
                if (tictac_board[player_Index]==' ')
                {
                    this.player_Index = player_Index;
                    Console.WriteLine("Entered Index of Letter is : " + player_Index);
                }
                else
                    Console.WriteLine("Entered Index is not free ");
            }

            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
