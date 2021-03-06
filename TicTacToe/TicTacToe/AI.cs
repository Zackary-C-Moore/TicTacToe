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
            //int[,] possibleMoves = new int[main_GD.getNumRows()*main_GD.getNumCols(),2];
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
                        main_GD.makeMove();
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
    }
}
