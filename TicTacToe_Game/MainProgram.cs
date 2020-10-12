using System;

namespace TicTacToe_Game
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic tac toe game");
            TicTacGameplay ticTac = new TicTacGameplay();

            int state = 0;
            Boolean is_Winner = false;
            String current_Chance = "";

            while ( is_Winner!=true) {

                switch (state)
                {
                    case 0:
                        ticTac.UC6_Toss();
                        state = 1;
                        break;

                    case 1:
                        ticTac.UC1_TicTacBoard();
                        state = 2;
                        break;

                    case 2:
                        ticTac.UC2_LetterAssign();
                        state = 3;
                        break;

                    case 3:
                        
                        if(ticTac.UC4_IndexOfLetter())
                            current_Chance = "Player";
                        state = 4;
                        break;

                    case 4:
                        ticTac.UC3_ShowBoard();
                        state = 5;
                        break;

                    case 5:
                        
                        if(ticTac.UC8_ComputerMove())
                            current_Chance = "Computer";
                        state = 6;
                        break;

                    case 6:
                        ticTac.UC3_ShowBoard();
                        state = 7;
                        break;

                    case 7:
                        if (ticTac.UC7_IS_WINNING())
                        {
                            is_Winner = true;
                            Console.WriteLine(current_Chance+" has won");
                        }
                        state = 2;
                        break;

                }
                
            }


        }
    }
}
