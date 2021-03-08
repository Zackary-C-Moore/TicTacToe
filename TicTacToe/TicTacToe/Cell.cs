using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    class Cell
    {
        //1 2 or 3
        int row;
        //This seems redundant but it will ensure that I do not have to put a bunch of if statements everywhere
        //col is for the computer colLetter is the for user.
        int col;
        //a b or c
        char colLetter;
        public Button btn;
        //x or o
        char value;

        public Cell()
        {

        }

        public Cell(int row, int col, char colLetter, Button btn, char value)
        {
            this.row = row;
            this.col = col;
            this.colLetter = colLetter;
            this.btn = btn;
            this.value = value;
        }

        //setters
        public void setValue(char v)
        {
            value = v;
        }

        //getters
        public int getRow()
        {
            return row;
        }

        public int getCol()
        {
            return col;
        }

        public char getColLetter()
        {
            return colLetter;
        }

        public Button getButton()
        {
            return btn;
        }

        public char getValue()
        {
            return value;
        }
    }
}
