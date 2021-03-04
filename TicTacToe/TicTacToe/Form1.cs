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
        private GameDriver GD = new GameDriver();
        public Form1()
        {
            InitializeComponent();
            setupGame();
            //this will be determined by who goes first
            //The player will determine who goes first (random, AI, or Player)
            GD.setAICharacter('X');
            GD.displayBoard();

            //while(GD.getGameOver() == false)
            //{

            //}

        }

        public void setupGame()
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
            foreach (var button in this.Controls.OfType<Button>())
            {
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

                newCell = new Cell(row, GD.getColumnLetter(col), button, '-');

                board[row, col] = newCell;
            }

            GD.setGameBoard(board);

        }

        private void buttonClickEvent(object sender, EventArgs e)
        {
            string name;
            char delim = '_';
            int posDelim;
            int col;
            int row;

            Button button = sender as Button;
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
            cell.setValue(characterToPlace);
            cell.getButton().Text = characterToPlace.ToString();
            GD.setCellGameBoard(cell, row, col);

            cell.getButton().Enabled = false;
            GD.checkForWinner();
            //change the symbol for the next persons turn
            GD.setCharacterToPlace();
            //disable the button
            
            GD.displayBoard();
        }
    }
}
