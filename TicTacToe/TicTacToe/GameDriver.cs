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
        bool playerWinner = false;
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
        public bool getPlayeWinner()
        {
            return playerWinner;
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

        public void setPlayerWinner(bool w)
        {
            playerWinner = w;
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
            if(!gameOver)
            {
                gameOver = horizontalWinCheck();
            }

            if(!gameOver)
            {
                gameOver = verticalWinCheck();
            }

            if (!gameOver)
            {
                gameOver = bottomUpDiagonalWinCheck();
            }

            if (!gameOver)
            {
                gameOver = topDownDiagonalWinCheck();
            }


            if (gameOver)
            {
                determineWinner();
            }
        }

        public bool horizontalWinCheck()
        {
            int cnt = 0;
            //Horizontal check
            for (int r = 0; r < numRows; r++)
            {
                cnt = 0;
                for (int c = 0; c < numCols - 1; c++)
                {
                    if (gameBoard[r, c].getValue() != '-' && gameBoard[r, c].getValue() == gameBoard[r, c + 1].getValue())
                    {
                        cnt++;
                    }
                    else
                    {
                        cnt = 0;
                    }

                    if (cnt == 2)
                    {
                        Console.WriteLine("Game Over");
                        return true;
                    }
                }
            }

            return false;
        }

        public bool verticalWinCheck()
        {
            int cnt;
            //Vertical Check
            for (int c = 0; c < numCols; c++)
            {
                cnt = 0;
                for (int r = 0; r < numRows - 1; r++)
                {
                    if (gameBoard[r, c].getValue() != '-' && gameBoard[r, c].getValue() == gameBoard[r + 1, c].getValue())
                    {
                        cnt++;
                    }
                    else
                    {
                        cnt = 0;
                    }

                    if (cnt == 2)
                    {
                        Console.WriteLine("Game Over");
                        return true;
                    }
                }
            }

            return false;
        }

        public bool bottomUpDiagonalWinCheck()
        {
            //Diagonal Check - lower left to upper right.
            int row = numRows - 1;
            int col = 0;
            int cnt = 0;
            while (row > 0)
            {
                if (gameBoard[row, col].getValue() != '-' && gameBoard[row, col].getValue() == gameBoard[row - 1, col + 1].getValue())
                {
                    cnt++;
                }
                else
                {
                    break;
                }

                col++;
                row--;
            }
            if (cnt == 2)
            {
                Console.WriteLine("Game Over");
                return true;
            }

            return false;
        }

        public bool topDownDiagonalWinCheck()
        {
            //Diagonal Check - top left to lower right.
            int row = 0;
            int col = 0;
            int cnt = 0;
            while (row < numRows - 1)
            {
                if (gameBoard[row, col].getValue() != '-' && gameBoard[row, col].getValue() == gameBoard[row + 1, col + 1].getValue())
                {
                    cnt++;
                }
                else
                {
                    break;
                }

                col++;
                row++;
            }
            if (cnt == 2)
            {
                Console.WriteLine("Game Over");
                return true;
            }

            return false;
        }

        public void determineWinner()
        {
            //Console.WriteLine(characterToPlace);
            if(AIChar != characterToPlace)
            {
                Console.WriteLine("Player Wins");
                playerWinner = true;
            }
            else
            {
                Console.WriteLine("AI Wins");
                playerWinner = false;
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
