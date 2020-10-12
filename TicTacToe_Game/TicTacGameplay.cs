using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

namespace TicTacToe_Game
{
    public class TicTacGameplay
    {
        public const int CHANCE_VALUE_PLAYER = 0;
        public const int CHANCE_VALUE_COMPUTER = 1;
        public int last_Chance;
        
        public int winner;
        public String[] toss_Choices = { "Player", "Computer" };
        public int first_Chance;
        char[] tictac_board;

        char player_Input = ' ';
        char computer_Input = ' ';
        int player_Index = 0;
        int computer_Index = 0;

        char[] LetterIndex = { 'X', 'O' };
        String input_ValidationString =  "[XO]{1}";

        public Boolean UC1_TicTacBoard()
        {
            tictac_board = new char[10];
            for(int i = 0; i < 10; i++)
            {
                tictac_board[i] = ' ';
            }
            Console.WriteLine("Tic Tac board initialised !");
            return true;

        }
        public Boolean UC2_LetterAssign()
        {
            Console.WriteLine("Enter the Letter 'X' or 'O' :");
            char player_Input_Console = char.Parse(Console.ReadLine());

            Regex regex = new Regex(input_ValidationString);
            Match match = regex.Match(player_Input_Console.ToString());

            if(match.Success) 
            {

                player_Input = player_Input_Console;
                Random random = new Random();
                int input_CompIndex = random.Next(0, 2);
                computer_Input = LetterIndex[input_CompIndex];

                Console.WriteLine("Player Selected Letter is : " + player_Input);
                Console.WriteLine("Computer Selected Letter is : " + computer_Input);
                return true;
            } 
            else
            {
                Console.WriteLine("Invalid Player Input");
                return UC2_LetterAssign();
            }

         
        }

        public void UC3_ShowBoard()
        {
            for(int i =1; i<10;i=i+3)
            {
                Console.WriteLine("  "+ tictac_board[i] +" | "+ tictac_board[i+1] + " | "+ tictac_board[i+2]);
            }
        }

        public void UC8_ComputerMove()
        {
            if (ComputerWinningMove() != 0)
            {
                tictac_board[ComputerWinningMove()] = computer_Input;
            }

        }
        public int ComputerWinningMove()
        {
            
            for(int index = 1; index <= 9; index ++)
            {
                
                if (tictac_board[index] == ' ')
                {
                    tictac_board[index] = LetterIndex[0];
                    if (UC7_IS_WINNING())
                    {
                        tictac_board[index] = ' ';
                        computer_Input = LetterIndex[0];
                        return index;
                    }
                    tictac_board[index] = LetterIndex[1];
                    if (UC7_IS_WINNING())
                    {
                        tictac_board[index] = ' ';
                        computer_Input = LetterIndex[1];
                        return index;
                    }



                }
                tictac_board[index] = ' ';

            }
            
            return 0;
        }
        public Boolean UC6_Toss()
        {
            
            Random random = new Random();
            int toss_Value=random.Next(0, 2);
            first_Chance = toss_Value;
            Console.WriteLine(toss_Choices[first_Chance] + " has won the toss and will start first");
            return true;

        }

        public Boolean UC7_IS_WINNING()
        {
            for(int i =0; i<2;i++)
            {
                if (tictac_board[1].Equals(LetterIndex[i]) && tictac_board[2].Equals(LetterIndex[i]) && tictac_board[3].Equals(LetterIndex[i]))
                    return true;
                if (tictac_board[3].Equals(LetterIndex[i]) && tictac_board[6].Equals(LetterIndex[i]) && tictac_board[9].Equals(LetterIndex[i]))
                    return true;
                if (tictac_board[7].Equals(LetterIndex[i]) && tictac_board[8].Equals(LetterIndex[i]) && tictac_board[9].Equals(LetterIndex[i]))
                    return true;
                if (tictac_board[1].Equals(LetterIndex[i]) && tictac_board[4].Equals(LetterIndex[i]) && tictac_board[7].Equals(LetterIndex[i]))
                    return true;
                if (tictac_board[1].Equals(LetterIndex[i]) && tictac_board[5].Equals(LetterIndex[i]) && tictac_board[9].Equals(LetterIndex[i]))
                    return true;
                if (tictac_board[3].Equals(LetterIndex[i]) && tictac_board[5].Equals(LetterIndex[i]) && tictac_board[7].Equals(LetterIndex[i]))
                    return true;
            }
            return false;
            
        }
        public Boolean UC4_IndexOfLetter()
        {
            Console.WriteLine("Enter the Letter Index from 1-9: ");
            String player_Index_Console = Console.ReadLine();
            Regex regex = new Regex(@"[1-9]{1}");
            Match match = regex.Match(player_Index_Console);
            if (match.Success)
            {

                if (tictac_board[int.Parse(player_Index_Console)] == ' ')
                {
                    player_Index = int.Parse(player_Index_Console);
                    tictac_board[player_Index] = player_Input;
                    Console.WriteLine("Entered Index of Letter is : " + player_Index);
                    last_Chance = 1;
                    return true;
                }
                else 
                {
                    Console.WriteLine("Entered Index is not free ");
                    return UC4_IndexOfLetter();
                }

            }

            else
            {
                Console.WriteLine("Invalid Input");
                return UC4_IndexOfLetter();
               
            }
        }
    }
}
