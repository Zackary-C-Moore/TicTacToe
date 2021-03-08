using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class AI
    {
        private GameDriver main_GD;
        private List<Cell> possibleMoves;

        public AI(GameDriver gd)
        {
            main_GD = gd;    
        }
        public void findMove()
        {
            getPossibleMoves();
            randomMove();
        }

        public void randomMove()
        {
            int randomIndex;
            Random rand = new Random();
            Cell moveToMake = new Cell();

            randomIndex = rand.Next(0, possibleMoves.Count);
            moveToMake = possibleMoves[randomIndex];

            makeMove(moveToMake);
        }

        public void getPossibleMoves()
        {
            possibleMoves = new List<Cell>();
            Cell cell = new Cell();
            for (int r = 0; r < main_GD.getNumRows(); r++)
            {
                for (int c = 0; c < main_GD.getNumCols(); c++)
                {
                    cell = main_GD.getGameBoard()[r, c];
                    if (cell.getValue() == '-')
                    {
                        possibleMoves.Add(cell);
                    }
                }
            }
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
