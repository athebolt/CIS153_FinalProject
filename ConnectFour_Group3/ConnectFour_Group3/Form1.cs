﻿using System;
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
        public Board connectFourBoard;
        public MiniMax aiPlayer = new MiniMax();
        //This is an array of all of the buttons (or whatever object we use to display the board, we can change this)
        public PictureBox[,] grid;

        public Form1()
        {
            InitializeComponent();
            
            fillButtonArray();

            connectFourBoard = new Board();

            //connectFourBoard.makeMove(0);

            //whenever the AI needs to make a move, just use this format!
            //aiPlayer.aiMakeMove(connectFourBoard);

            //connectFourBoard.displayBoardToConsole();

            connectFourBoard.displayToForm(ref grid);
        }

        public void fillButtonArray()
        {
            //Fill the array manually with the name of every cell on the form, this will allow us to use a function on Board.cs to update the board on the form.
            //I think Nathan said he was gonna work on this, so if u have questions about this Nathan, lmk. -Nick
            grid = new PictureBox[,] {  { box11, box12, box13, box14, box15, box16, box17 },
                                        { box21, box22, box23, box24, box25, box26, box27 },
                                        { box31, box32, box33, box34, box35, box36, box37 },
                                        { box41, box42, box43, box44, box45, box46, box47 },
                                        { box51, box52, box53, box54, box55, box56, box57 },
                                        { box61, box62, box63, box64, box65, box66, box67 }};
        }
        
        private void playPiece(object sender, EventArgs e)
        {
            //Make sure the game hasn't ended
            if (connectFourBoard.checkWin() == -2)
            {
                //Make the player's move
                string tag = (string)((Button)sender).Tag;

                if (connectFourBoard.makeMove(int.Parse(tag)))
                {
                    connectFourBoard.displayToForm();

                    //Make sure the game hasn't ended
                    if (connectFourBoard.checkWin() == -2)
                    {
                        //Make the AI's move
                        aiPlayer.aiMakeMove(connectFourBoard);
                        connectFourBoard.displayToForm();
                    }
                }
            }

        }
    }
}
