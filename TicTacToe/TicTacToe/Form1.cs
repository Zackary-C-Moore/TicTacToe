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
            GD.displayBoard();

        }

        public void setupGame()
        {
            string name;
            char delim = '_';
            int posDelim;
            char col;
            char row;
            Cell newCell;
            Cell[,] board = new Cell[3, 3];
            int r = 0;
            int c = 0;
            //I could just hardcode these but I have asperations to make this work with a larger grid
            //Cycle through all of the buttons on the form.
            foreach(var button in this.Controls.OfType<Button>())
            {
                name = button.Name;
                posDelim = name.IndexOf(delim);
                col = char.Parse(name.Substring(posDelim + 1, 1));
                row = char.Parse(name.Substring(posDelim + 2));

                newCell = new Cell(row, col, button, ' ');

                if(col == 'A')
                {
                    c = 0;
                }
                else if(col == 'B')
                {
                    c = 1;
                }
                else if(col == 'C')
                {
                    c = 2;
                }

                board[r, c] = newCell;

                if(c == 2)
                {
                    r++;
                }
            }

            GD.setGameBoard(board);

        }
    }
}
