using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class AI
    {
        private Cell[,] main_GB;
        private GameDriver main_GD;
        private Form1 main_form;

        public AI(GameDriver gd, Form1 frm)
        {
            main_GD = gd;
            main_form = frm;

            //Console.WriteLine("=================AI================");
            //for (int r = 0; r < main_GD.getNumRows(); r++)
            //{
            //    for(int c = 0; c < main_GD.getNumCols(); c++)
            //    {
            //        Console.Write(main_GB[r, c].getValue());
            //    }

            //    Console.WriteLine();
            //}
            
        }
        public void makeMove()
        {
            main_GB = main_GD.getGameBoard();
            Cell cell = new Cell();
            bool moveMade = false;

            for (int r = 0; r < main_GD.getNumRows(); r++)
            {
                for (int c = 0; c < main_GD.getNumCols(); c++)
                {
                    cell = main_GB[r, c];
                    if(main_GB[r,c].getValue() == '-')
                    {
                        cell.setValue(main_GD.getCharacterToPlace());
                        cell.getButton().Text = main_GD.getCharacterToPlace().ToString();
                        main_GD.setCellGameBoard(cell, r, c);
                        moveMade = true;
                        //afterMoveSteps();
                        break;
                    }
                }
                if(moveMade)
                {
                    break;
                }
            }
        }

        //public void afterMoveSteps()
        //{
        //    //show board in console.
        //    main_GD.displayBoard();
        //    //see if the game was won
        //    main_GD.checkForWinner();
        //    if (main_GD.getGameOver() == false)
        //    {
        //        //change the symbol for the next persons turn
        //        main_GD.setCharacterToPlace();
        //        //change to AI turn
        //        main_GD.setPlayerTurn(true);
        //    }
        //}
    }
}
