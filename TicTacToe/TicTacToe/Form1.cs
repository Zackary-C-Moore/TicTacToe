using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private GameDriver GD;
        private AI ai;
        public Form1()
        {
            InitializeComponent();
            setupGame();

        }

        public void setupGame()
        {
            GD = new GameDriver();
            ai = new AI(GD);
            //cannot have a new game until one is started
            //enable this button on the start game button press
            btn_newGame.Enabled = false;
            setupBoard();
            disableAllButtons();
            GD.displayBoard();
        }

        public void setupBoard()
        {
            string name;
            char delim = '_';
            int posDelim;
            int col;
            int row;
            Cell newCell;
            Cell[,] board = new Cell[3, 3];


            //I could just hardcode these but I have asperations to make this work with a larger grid
            //Cycle through all of the buttons on the form.
            foreach (var button in this.panel_gameBoard.Controls.OfType<Button>())
            {
                //set all of the button values to nothing used for restarting the game
                button.Text = null;
                //parse the name of the button to get the row and col information
                //names for the cells follow a specific naming standard (row by column eg. btn_0_0).
                //I will convert the columns to be letters in the GameDriver class.
                name = button.Name;
                posDelim = name.IndexOf(delim);
                row = Int32.Parse(name.Substring(posDelim + 1, 1));
                name = name.Substring(posDelim + 2);
                posDelim = name.IndexOf(delim);
                col = Int32.Parse(name.Substring(posDelim + 1));

                //Console.WriteLine(row + "  " + col);

                newCell = new Cell(row, col, GD.getColumnLetter(col), button, '-');

                board[row, col] = newCell;
            }

            GD.setGameBoard(board);

        }

        private void buttonClickEvent(object sender, EventArgs e)
        {
            //comment this out to keep testing
            if (GD.getPlayerTurn() == true)
            {
                Button button = sender as Button;
                //Figures out what button was pressed and how to make the move
                //after the player clicks their button the ai can make their turn
                //If the ai needs to go first that functionality is handled on the start button press.
                playerMove(button);
                //handles gui and making the move.
                //afterMoveSteps();
                if (GD.getGameOver() == false)
                {
                    //After the user makes their move the ai can make its move.
                    AIDetermineMove();
                    ////handles gui and making the move
                    //afterMoveSteps();
                }
                
            }
                
        }

        public void playerMove(Button button)
        {
            string name;
            char delim = '_';
            int posDelim;
            int col;
            int row;
            //used to store the information about the cell (button) that I pressed.
            Cell cell = new Cell();
            char characterToPlace = GD.getCharacterToPlace();

            //parse the name
            //find the row
            //find the column
            //write if statements for row
            //write code below once.

            name = button.Name;
            posDelim = name.IndexOf(delim);
            row = Int32.Parse(name.Substring(posDelim + 1, 1));
            name = name.Substring(posDelim + 2);
            posDelim = name.IndexOf(delim);
            col = Int32.Parse(name.Substring(posDelim + 1));
            cell = GD.getGameBoardCell(row, col);

            //Make the move
            cell.setValue(characterToPlace);
            cell.getButton().Text = characterToPlace.ToString();
            GD.setCellGameBoard(cell, row, col);

            //disable the button that the user pressed
            cell.getButton().Enabled = false;

            //make the move on the board array and determine what to do after the specified move.
            GD.performMoveActionsOnBoard();

            if (GD.getGameOver() == true)
            {
                disableAllButtons();
                //display who won
                displayWinner();
            }
        }


        private void radioButtonClickEvent(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            determinePlayerOrder(rb);      
        }

        public void determinePlayerOrder(RadioButton rb)
        {
            lbl_errorMsg.Visible = false;

            lbl_xText.Text = null;
            lbl_Otxt.Text = null;

            if (rb.Name == "rb_AI")
            {
                //this will be determined by who goes first
                //The player will determine who goes first (random, AI, or Player)
                GD.setAICharacter('X');
                GD.setPlayerCharacter('O');
                GD.setPlayerTurn(false);

                lbl_Otxt.Text = "O: Player";
                lbl_xText.Text += "X: AI";
            }
            else if (rb.Name == "rb_player")
            {
                GD.setAICharacter('O');
                GD.setPlayerCharacter('X');
                GD.setPlayerTurn(true);

                lbl_Otxt.Text += "O: AI";
                lbl_xText.Text += "X: Player";
            }
            else if (rb.Name.Equals("rb_random"))
            {
                Random rand = new Random();
                int num = rand.Next(0, 2);

                if (num == 0)
                {
                    GD.setAICharacter('X');
                    GD.setPlayerCharacter('O');
                    GD.setPlayerTurn(false);

                    lbl_Otxt.Text += "O: Player";
                    lbl_xText.Text += "X: AI";
                }
                else
                {
                    GD.setAICharacter('O');
                    GD.setPlayerCharacter('X');
                    GD.setPlayerTurn(true);

                    lbl_Otxt.Text += "O: AI";
                    lbl_xText.Text += "X: Player";
                }
            }
        }

        public void enableAllButtons()
        {
            for (int r = 0; r < GD.getNumRows(); r++)
            {
                for (int c = 0; c < GD.getNumCols(); c++)
                {
                    if (GD.getGameBoardCell(r, c).getValue() == '-')
                    {
                        GD.getGameBoardCell(r, c).getButton().Enabled = true;
                    }

                }
            }
        }

        public void disableAllButtons()
        {
            for (int r = 0; r < GD.getNumRows(); r++)
            {
                for (int c = 0; c < GD.getNumCols(); c++)
                {
                    if (GD.getGameBoardCell(r, c).getValue() == '-')
                    {
                        GD.getGameBoardCell(r, c).getButton().Enabled = false;
                    }

                }
            }
        }

        public void enableAllRadioButtons()
        {
            rb_AI.Enabled = true;
            rb_player.Enabled = true;
            rb_random.Enabled = true;
        }

        public void disableAllRadioButtons()
        {
            rb_AI.Enabled = false;
            rb_player.Enabled = false;
            rb_random.Enabled = false;
        }

        public void disableStartButton()
        {
            btn_startGame.Enabled = false;
        }

        public void enableStartButton()
        {
            btn_startGame.Enabled = true;
        }

        
        //used to start the game.
        private void btn_startGame_Click(object sender, EventArgs e)
        {
            
            if(rb_AI.Checked || rb_player.Checked || rb_random.Checked)
            {
                btn_newGame.Enabled = true;
                //Start Game
                if (GD.getPlayerTurn() == true)
                {
                    enableAllButtons();
                    disableAllRadioButtons();
                    disableStartButton();
                }
                else
                {
                    disableAllButtons();
                    disableAllRadioButtons();
                    disableStartButton();

                    //used when the ai needs to go first
                    AIDetermineMove();
                }
            }
            else
            {
                //error message
                //must choose an option.
                lbl_errorMsg.Visible = true;
            }
        }

        private void btn_newGame_Click(object sender, EventArgs e)
        {
            enableStartButton();
            enableAllRadioButtons();

            rb_AI.Checked = false;
            rb_player.Checked = false;
            rb_random.Checked = false;

            lbl_winner.Text = null;
            lbl_Otxt.Text = null;
            lbl_xText.Text = null;

            setupGame();

        }

        private void btn_exitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void AIDetermineMove()
        {
            ai.findMove();
            
            if(GD.getGameOver() == true)
            {
                disableAllButtons();
                //display who won
                displayWinner();
            }

            //allow the player to make their next move
            enableAllButtons();
        }

        public void displayWinner()
        {
            lbl_winner.Text = GD.getWinnerString(GD.getWinner());
        }
    }
}
