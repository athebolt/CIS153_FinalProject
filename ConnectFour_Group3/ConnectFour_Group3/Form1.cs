//=====================================================================
//Names: Alexander Thebolt, Nicolaas Dykk, Tristan Mann, Nathan Gessner
//Date : 04/01/2024
//Desc : Connect Four Game - Group 3
//=====================================================================

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectFour_Group3
{
    public partial class Form1 : Form
    {
        //A reference to the title page for whenever we are ready to close the game
        private TitlePage titlePage;
        //The gamemode that the user picked (0 for AI, 1 for two player)
        private int gamemode;

        private Board connectFourBoard;
        private GameStats gameData;

        private MiniMax aiPlayer = new MiniMax();
        //This is an array of all of the buttons (or whatever object we use to display the board, we can change this)
        private PictureBox[,] grid;

        private bool isPlayer2Turn = false;

        //Used for knowing if the form closing is due to the X button being pressed or not
        private bool closeApp = true;

        private bool inReview = false;
        private GameOver gameOver = null;



        /// <summary>
        /// Starts the game, given the titlePage and the gamemode.
        /// </summary>
        /// <param name="tp"></param>
        /// <param name="gm"></param>
        public Form1(TitlePage tp, int gm)
        {
            InitializeComponent();
            
            titlePage = tp;           
            gamemode = gm;

            setFormLocation();

            fillButtonArray();

            connectFourBoard = new Board();
            gameData = new GameStats();

            gameData.loadStats();

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
            if (!connectFourBoard.isGameOver())
            {

                //Make the player's move
                string tag = (string)((PictureBox)sender).Tag;                

                if (connectFourBoard.makeMove(int.Parse(tag)))
                {
                    if(gamemode == 0)
                        lblTurnDisp.Text = "AI's Turn...      ";

                    connectFourBoard.displayToForm();
                    Update();

                    //check for a win, if the game is over, lock the board
                    checkGameOver(int.Parse(tag));

                    //Make sure the game hasn't ended
                    if (!connectFourBoard.isGameOver() && gamemode == 0)
                    {
                        //Make the AI's move
                        int col = aiPlayer.aiMakeMove(connectFourBoard);
                        connectFourBoard.displayToForm();

                        //check for a win, if the game is over, lock the board
                        checkGameOver(col);
                    }

                    if (gamemode == 1)
                        isPlayer2Turn = !isPlayer2Turn;

                    if (isPlayer2Turn)
                        lblTurnDisp.Text = "Player 2's Turn";
                    else
                        lblTurnDisp.Text = "Player 1's Turn";
                }
            }
        }

        private void checkGameOver(int col)
        {
            if (connectFourBoard.checkWinV2(col) != -2)
            {
                int winner = connectFourBoard.checkWinV2(col);                
                connectFourBoard.highlightWinningSequence();

                if (gamemode == 0)
                    gameData.updateStats(winner);

                connectFourBoard.lockBoard();

                GameOver gm = new GameOver(titlePage, this, winner, gamemode == 0);
                gameOver = gm;
                gm.Show();
                this.Hide();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(closeApp)
                titlePage.Close();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            if (inReview)
            {
                gameOver.Show();
                this.Hide();
            }
            else
            {
                titlePage.Show();
                closeApp = false;
                this.Close();
            }

        }

        /// <summary>
        /// Close the form from an external source without closing the entire program
        /// </summary>
        public void closeForm()
        {
            closeApp = false;
            this.Close();
        }

        /// <summary>
        /// Switches the the button and turn display to suit the review view, and allows the button to lead to the game over screen.
        /// </summary>
        public void switchToReview()
        {
            btn_Back.Text = "Return to Game Over";
            lblTurnDisp.Text = "Game Review";
            inReview = true;
        }

        private void setFormLocation()
        {
            this.StartPosition = FormStartPosition.Manual;

            int screenW = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            int screenH = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;

            this.Top = screenH;
            this.Left = screenW;
        }

        private void btn_MouseHover(object sender, EventArgs e)
        {
            if (!connectFourBoard.isGameOver())
                connectFourBoard.hoverFunctionality(ref grid, (string)((PictureBox)sender).Tag, true);
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            if (!connectFourBoard.isGameOver())
                connectFourBoard.hoverFunctionality(ref grid, (string)((PictureBox)sender).Tag, false);
        }
    }
}
