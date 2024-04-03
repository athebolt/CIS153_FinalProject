using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectFour_Group3
{
    public partial class Form1 : Form
    {
        public Board connectFourBoard = new Board();
        //This is an array of all of the buttons (or whatever object we use to display the board, we can change this)
        public Button[,] buttons;

        public Form1()
        {
            InitializeComponent();
        }

        public void fillButtonArray()
        {
            //Fill the array manually with the name of every cell on the form, this will allow us to use a function on Board.cs to update the board on the form.
            //I think Nathan said he was gonna work on this, so if u have questions about this Nathan, lmk. -Nick
            buttons = new Button[,] {   { /*buttonA1, buttonB1, buttonC1, etc. */ },
                                        { /*buttonA2, buttonB2, buttonC2, etc. */ },
                                        { },
                                        { },
                                        { },
                                        { },
                                        { } };
        }
    }
}
