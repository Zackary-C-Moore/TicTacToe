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
        //0 = computer 1 = player 2 = draw -999 = game not over
        int winner = -999;
        string[] winnerLookupTable = { "AI Wins!", "Player Wins!", "It's A Draw!" };
        int numRows = 3;
        int numCols = 3;
        //board
        Cell[,] gameBoard;
        //x always first
        char characterToPlace;
        char[] columnLookupTable = { 'A', 'B', 'C' };
        char AIChar;

        

        public GameDriver()
        {
            gameBoard = new Cell[numRows, numCols];
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

        public string getWinnerString(int i)
        {
            return winnerLookupTable[i];
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

        public void setWinner(int i)
        {
            winner = i;
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
        //I think that this needs to change so when I  introduce the AI functionality I can use this function to evaluate a board
        //0 for AI win - set in determineWinner()
        //1 for player win - set in determineWinner()
        //2 for draw - set in drawCheck()
        //I do not think that this function needs to return a value becuase in AI class it will make a new board to see who wins 
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

            if(!gameOver)
            {
                gameOver = drawCheck();
            }
            //if the game is over and it is not a draw I need to see who won
            //if the game is over and it is a draw I set the value in drawCheck()
            if (gameOver && winner != 2)
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

        public bool drawCheck()
        {
            for (int r = 0; r < numRows; r++)
            {
                for (int c = 0; c < numCols; c++)
                {
                    if (gameBoard[r, c].getValue() == '-')
                    {
                        return false;
                    }
                }
            }
            gameOver = true;
            //set the winner so I do not call the determineWinner() function from the checkForWinner() function
            winner = 2;
            return true;
        }

        public void determineWinner()
        {
            //Console.WriteLine(characterToPlace);
            if(AIChar != characterToPlace)
            {
                Console.WriteLine("Player Wins");
                winner = 1;
            }
            else
            {
                Console.WriteLine("AI Wins");
                winner = 0;

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

        public void performMoveActionsOnBoard()
        {
            //show board in console.
            displayBoard();
            //see if the game was won
            checkForWinner();
            if (getGameOver() == false)
            {
                //change the symbol for the next persons turn
                setCharacterToPlace();
                //change to the oposite of whose turn it is now
                setPlayerTurn(!getPlayerTurn());
            }
        }

    }
}
