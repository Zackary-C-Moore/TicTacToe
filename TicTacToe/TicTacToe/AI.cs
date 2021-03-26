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
        private List<Cell> possibleMoves = new List<Cell>();
        private int[] scoringSystem = new int[] { 1, -1, 0 };
        char lastCharacterPlaced = 'X';
        

        public AI(GameDriver gd)
        {
            main_GD = gd;
        }
        public void findMove()
        {
            char[,] minimaxBoard = new char[main_GD.getNumRows(), main_GD.getNumCols()];
            getPossibleMoves();
            //randomMove();
            copyArray(minimaxBoard);
            int bestScore = Int32.MinValue;
            Cell bestMove = new Cell();
            

            //cycle through all possible moves that AI could make
            for (int r = 0; r < main_GD.getNumRows(); r++)
            {
                for (int c = 0; c < main_GD.getNumCols(); c++)
                {
                    if (minimaxBoard[r,c] == '-')
                    {
                        minimaxBoard[r, c] = main_GD.getAICharacter();
                        lastCharacterPlaced = main_GD.getAICharacter();
                        dispBoardCopy(minimaxBoard);
                        int score = miniMaxAlgorithm(minimaxBoard, 0, false);
                        minimaxBoard[r, c] = '-';
                        if (score > bestScore)
                        {
                            //Console.WriteLine("HERE");
                            bestScore = score;
                            bestMove = main_GD.getGameBoard()[r, c];
                            Console.WriteLine(r + ", " + c);
                        }

                        // break;
                    }
                }
            }
            Console.WriteLine(bestScore);
            makeMove(bestMove);
        }



        public void getPossibleMoves()
        {
            possibleMoves.Clear();
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

        public void randomMove()
        {
            int randomIndex;
            Random rand = new Random();
            Cell moveToMake = new Cell();

            randomIndex = rand.Next(0, possibleMoves.Count);
            moveToMake = possibleMoves[randomIndex];

            makeMove(moveToMake);
        }

        public int miniMaxAlgorithm(char[,] minimaxBoard, int depth, bool maximizing)
        {
            int winner = checkForWinner(minimaxBoard);
            if (winner != -999)
            {
                //Console.WriteLine(scoringSystem[winner]);
                return scoringSystem[winner];
            }

            //AI hypothetical turn
            if(maximizing)
            {
                int bestScore = Int32.MinValue;
                for (int r = 0; r < main_GD.getNumRows(); r++)
                {
                    for (int c = 0; c < main_GD.getNumCols(); c++)
                    {
                        if (minimaxBoard[r,c] == '-')
                        {
                            minimaxBoard[r, c] = main_GD.getAICharacter();
                            lastCharacterPlaced = main_GD.getAICharacter();
                            dispBoardCopy(minimaxBoard);
                            int score = miniMaxAlgorithm(minimaxBoard, depth + 1, false);

                            minimaxBoard[r, c] = '-';
                            if (score > bestScore)
                            {
                                bestScore = score;
                            }
                            //break;
                        }
                    }
                }

                return bestScore;
            }
            //User hypothetical turn
            else
            {
                int bestScore = Int32.MaxValue;
                for (int r = 0; r < main_GD.getNumRows(); r++)
                {
                    for (int c = 0; c < main_GD.getNumCols(); c++)
                    {
                        if (minimaxBoard[r,c] == '-')
                        {
                            minimaxBoard[r, c] = main_GD.getPlayerCharacter();
                            lastCharacterPlaced = main_GD.getPlayerCharacter();
                            dispBoardCopy(minimaxBoard);
                            int score = miniMaxAlgorithm(minimaxBoard, depth + 1, true);
                            minimaxBoard[r, c] = '-';
                            if (score < bestScore)
                            {
                                bestScore = score;
                            }
                            //break;
                        }
                    }
                }

                return bestScore;
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

        public void dispBoardCopy(char[,] minimaxBoard)
        {
           //Console.WriteLine("@@@@@@@@@@@@@@@");
           //for(int r = 0; r < 3; r++)
           //{
           //     for(int c = 0; c < 3; c++)
           //     {
           //         Console.Write(minimaxBoard[r, c]);
           //     }
           //     Console.WriteLine();
           //}
           //Console.WriteLine("@@@@@@@@@@@@@@@");
        }

        public void copyArray(char[,] minimaxBoard)
        {
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    minimaxBoard[r, c] = main_GD.getGameBoard()[r, c].getValue();
                }
            }
        }

        public int checkForWinner(char[,] gameBoard)
        {
            bool gameOver = false;
            int winner = -999;
            if (!gameOver)
            {
                gameOver = horizontalWinCheck(gameBoard);
            }

            if (!gameOver)
            {
                gameOver = verticalWinCheck(gameBoard);
            }

            if (!gameOver)
            {
                gameOver = bottomUpDiagonalWinCheck(gameBoard);
            }

            if (!gameOver)
            {
                gameOver = topDownDiagonalWinCheck(gameBoard);
            }

            if (!gameOver)
            {
                if(drawCheck(gameBoard))
                {
                    winner = 2;
                }
            }
            //if the game is over and it is not a draw I need to see who won
            //if the game is over and it is a draw I set the value in drawCheck()
            if (gameOver && winner != 2)
            {
                winner = determineWinner();
            }

            return winner;
        }

        public bool horizontalWinCheck(char[,] gameBoard)
        {
            int cnt = 0;
            //Horizontal check
            for (int r = 0; r < main_GD.getNumRows(); r++)
            {
                cnt = 0;
                for (int c = 0; c < main_GD.getNumCols() - 1; c++)
                {
                    if (gameBoard[r, c] != '-' && gameBoard[r, c] == gameBoard[r, c + 1])
                    {
                        cnt++;
                    }
                    else
                    {
                        cnt = 0;
                    }

                    if (cnt == 2)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool verticalWinCheck(char[,] gameBoard)
        {
            int cnt;
            //Vertical Check
            for (int c = 0; c < main_GD.getNumCols(); c++)
            {
                cnt = 0;
                for (int r = 0; r < main_GD.getNumRows() - 1; r++)
                {
                    if (gameBoard[r, c] != '-' && gameBoard[r, c] == gameBoard[r + 1, c])
                    {
                        cnt++;
                    }
                    else
                    {
                        cnt = 0;
                    }

                    if (cnt == 2)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool bottomUpDiagonalWinCheck(char[,] gameBoard)
        {
            //Diagonal Check - lower left to upper right.
            int row = main_GD.getNumRows() - 1;
            int col = 0;
            int cnt = 0;
            while (row > 0)
            {
                if (gameBoard[row, col] != '-' && gameBoard[row, col] == gameBoard[row - 1, col + 1])
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
                return true;
            }

            return false;
        }

        public bool topDownDiagonalWinCheck(char[,] gameBoard)
        {
            //Diagonal Check - top left to lower right.
            int row = 0;
            int col = 0;
            int cnt = 0;
            while (row < main_GD.getNumRows() - 1)
            {
                if (gameBoard[row, col] != '-' && gameBoard[row, col] == gameBoard[row + 1, col + 1])
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
                return true;
            }

            return false;
        }

        public bool drawCheck(char[,] gameBoard)
        {
            for (int r = 0; r < main_GD.getNumRows(); r++)
            {
                for (int c = 0; c < main_GD.getNumCols(); c++)
                {
                    if (gameBoard[r, c] == '-')
                    {
                        return false;
                    }
                }
            }
            
            //set the winner so I do not call the determineWinner() function from the checkForWinner() function
            
            return true;
        }

        public int determineWinner()
        {
            //Console.WriteLine(characterToPlace);
            if (main_GD.getAICharacter() != lastCharacterPlaced)
            {
                //Console.WriteLine("Player Wins");
                return 1;
            }
            else
            {
                //Console.WriteLine("AI Wins");
                return 0;

            }
        }
    }
}
