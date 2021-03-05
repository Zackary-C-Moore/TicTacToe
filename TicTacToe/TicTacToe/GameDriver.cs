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
        bool playerTurn;
        bool gameOver = false;
        //0 = computer 1 = player
        int winner;
        //board
        Cell[,] gameBoard = new Cell[3, 3];
        //x always first
        char characterToPlace;
        char[] columnLookupTable = { 'A', 'B', 'C' };
        char AIChar;

        int numRows = 3;
        int numCols = 3;

        public GameDriver()
        {
            characterToPlace = 'X';
        }


        //Getters
        public bool getPlayerTurn()
        {
            return playerTurn;
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

        public char getAIChactacter()
        {
            return AIChar;
        }

        public int getNumRows()
        {
            return numRows;
        }

        public int getNumCols()
        {
            return numCols;
        }

        //Setters
        public void setPlayerTurn(bool x)
        {
            playerTurn = x;
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
            if(getCharacterToPlace() == 'X')
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

        public void setAICharacter(char c)
        {
            AIChar = c;
        }

        //Game Funcitons
        public void checkForWinner()
        {
            int numInRow = 0;
            //Horizontal check
            for (int r = 0; r < numRows; r++)
            {
                numInRow = 0;
                for (int c = 0; c < numCols - 1; c++)
                {
                    if(gameBoard[r,c].getValue() != '-' && gameBoard[r,c].getValue() == gameBoard[r,c+1].getValue())
                    {
                        numInRow++;
                    }
                    else
                    {
                        numInRow = 0;
                    }

                    if(numInRow == 2)
                    {
                        gameOver = true;
                        Console.WriteLine("Game Over");
                        break;
                    }
                }
                if(gameOver)
                {
                    break;
                }

            }

            //Vertical Check
            for (int c = 0; c < numCols; c++)
            {
                numInRow = 0;
                for (int r = 0; r < numRows - 1; r++)
                {
                    if (gameBoard[r, c].getValue() != '-' && gameBoard[r, c].getValue() == gameBoard[r + 1, c].getValue())
                    {
                        numInRow++;
                    }
                    else
                    {
                        numInRow = 0;
                    }

                    if (numInRow == 2)
                    {
                        gameOver = true;
                        Console.WriteLine("Game Over");
                        break;
                    }
                }
                if(gameOver)
                {
                    break;
                }
            }

            //Diagonal Check - lower left to upper right.
            int row_1 = numRows - 1;
            int col_1 = 0;
            int cnt = 0;
            while(row_1 > 0)
            {
                if(gameBoard[row_1, col_1].getValue() != '-' && gameBoard[row_1, col_1].getValue() == gameBoard[row_1 - 1, col_1 + 1].getValue())
                {
                    cnt++;
                }
                else
                {
                    break;
                }

                col_1++;
                row_1--;
            }
            if(cnt == 2)
            {
                gameOver = true;
                Console.WriteLine("Game Over");
            }

            //Diagonal Check - lower left to upper right.
            int row_2 = 0;
            int col_2 = 0;
            int cnt2 = 0;
            while (row_2 < numRows - 1)
            {
                if (gameBoard[row_2, col_2].getValue() != '-' && gameBoard[row_2, col_2].getValue() == gameBoard[row_2 + 1, col_2 + 1].getValue())
                {
                    cnt2++;
                }
                else
                {
                    break;
                }

                col_2++;
                row_2++;
            }
            if (cnt2 == 2)
            {
                gameOver = true;
                Console.WriteLine("Game Over");
            }

            if(gameOver)
            {
                determineWinner();
            }
        }

        public void determineWinner()
        {
            if(AIChar == characterToPlace)
            {
                Console.WriteLine("AI wins");
            }
            else
            {
                Console.WriteLine("Player Wins");
            }
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
