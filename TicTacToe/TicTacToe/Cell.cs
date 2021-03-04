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
        //a b or c
        char col;
        public Button btn;
        //x or o
        char value;

        public Cell()
        {

        }

        public Cell(int row, char col, Button btn, char value)
        {
            this.row = row;
            this.col = col;
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

        public char getCol()
        {
            return col;
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
