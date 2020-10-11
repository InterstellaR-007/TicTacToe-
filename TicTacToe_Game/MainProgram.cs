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

            while (state != 5) {

                switch (state)
                {
                    case 0:
                        ticTac.UC1_TicTacBoard();
                        break;

                    case 1:
                        ticTac.UC2_LetterAssign();
                        break;

                    case 3:
                        ticTac.UC4_IndexOfLetter();
                        break;

                    case 4:
                        ticTac.UC3_ShowBoard();
                        break;

                }
                state++;
            }


        }
    }
}
