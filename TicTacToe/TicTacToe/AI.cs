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

        public AI(GameDriver gd)
        {
            main_GD = gd;    
        }
        public void findMove()
        {
            randomMove();
        }

        public void randomMove()
        {
            List<Cell> possibleMoves = new List<Cell>();
            main_GB = main_GD.getGameBoard();
            Cell cell = new Cell();
            int randomIndex;
            Random rand = new Random();
            Cell moveToMake = new Cell();

            for (int r = 0; r < main_GD.getNumRows(); r++)
            {
                for (int c = 0; c < main_GD.getNumCols(); c++)
                {
                    cell = main_GB[r, c];
                    if (main_GB[r, c].getValue() == '-')
                    {
                        possibleMoves.Add(cell);
                    }
                }
            }

            
            randomIndex = rand.Next(0, possibleMoves.Count);
            moveToMake = possibleMoves[randomIndex];

            makeMove(moveToMake);

        }

        public void makeMove(Cell moveToMake)
        {
            moveToMake.setValue(main_GD.getCharacterToPlace());
            moveToMake.getButton().Text = main_GD.getCharacterToPlace().ToString();
            moveToMake.getButton().Enabled = false;
            main_GD.setCellGameBoard(moveToMake, moveToMake.getRow(), moveToMake.getCol());
            main_GD.performMoveActionsOnBoard();
        }
    }
}
