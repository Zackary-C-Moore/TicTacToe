using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class GameDriver
    {
        //0 = computer 1 = player
        int turn;
        bool gameOver = false;
        //0 = computer 1 = player
        int winner;
        //board
        Cell[,] gameBoard = new Cell[3, 3];
        //x always first
        char characterToPlace;
        char[] columnLookupTable = { 'A', 'B', 'C' };

        int numRows = 3;
        int numCols = 3;

        public GameDriver()
        {
            characterToPlace = 'X';
        }


        //Getters
        public int getTurn()
        {
            return turn;
        }
        public bool getGameOver()
        {
            return gameOver;
        }
        public int getWinner()
        {
            return winner;
        }
        public char getCharacterToPlace()
        {
            return characterToPlace;
        }
        public Cell[,] getGameBoard()
        {
            return gameBoard;
        }
        //Not sure if i need this yet
        public Cell getGameBoardCell(int r, int c)
        {
            return gameBoard[r, c];
        }

        public char getColumnLetter(int n)
        {
            return columnLookupTable[n];
        }

        //Setters
        public void setTurn()
        {
            if(turn == 0)
            {
                turn = 1;
            }
            else
            {
                turn = 0;
            }
        }

        public void setGameOver()
        {
            gameOver = true;
        }

        public void setWinner(int w)
        {
            winner = w;
        }

        public void setCharacterToPlace()
        {
            if(getTurn() == 'X')
            {
                characterToPlace = 'O';
            }
            else
            {
                characterToPlace = 'X';
            }
        }

        public void setGameBoard(Cell[,] b)
        {
            gameBoard = b;
        }
        //not sure if I will need this yet
        public void setCellGameBoard(Cell c, int row, int col)
        {
            gameBoard[row, col] = c;
        }

        //Game Funcitons
        public void checkForWinner()
        {

        }

        public void displayBoard()
        {
            for(int r = 0; r < numRows; r++)
            {
                for(int c = 0; c<numCols; c++)
                {
                    //Console.Write(gameBoard[r, c].getCol() + "" + gameBoard[r,c].getRow() + " ");
                    Console.Write(gameBoard[r, c].getValue());
                }
                Console.WriteLine();
            }
            Console.WriteLine("===========================================");
        }

    }
}
