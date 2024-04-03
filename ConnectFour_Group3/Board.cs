using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectFour_Group3
{
    public class Board
    {
        private Cell[,] board = new Cell[6, 7];
        //True when player 1 move, false when player 2 move (OR AI MOVE)
        private bool isPlayerMove;

        #region Constructors

        //Upon creating a board, we set it up to fill every slot with a cell that knows
        //it's location and its value (which, by default, is ' ')
        public Board()
        {
            fillBoard();
            isPlayerMove = true;
        }

        public Board(bool isPlayerMove)
        {
            fillBoard();
            this.isPlayerMove = isPlayerMove;
        }

        #endregion

        #region Functions

        //Fills the board with cells that know their location and have a value of ' '
        private void fillBoard()
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = new Cell(i, j, ' ');
                }
            }
        }

        //Makes a move in the given column (0-6), returning true if the move is possible and
        //false if it is not
        public bool makeMove(int col)
        {
            bool moveComplete = false;
            for (int i = board.GetLength(0) - 1; i >= 0; i--)
            {
                if (board[i, col].getVal() == ' ')
                {
                    moveComplete = true;
                    board[i, col].setVal(isPlayerMove ? 'X' : 'O');
                    isPlayerMove = !isPlayerMove;
                    break;
                }
            }
            return moveComplete;
        }

        //When provided with an array of every button, fills the buttons with the proper colors
        public void fillBoardOnForm(ref Button[,] buttons)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    //Here we will set a quality of the buttons to turn them the correct color or image or however we're gonna do it
                    //This is psuedocode, .setColor() probably does not exist. Also we may need to change this if we do not use buttons for everything.
                    //if (board[i,j].value == ' ')
                    //{
                    //    buttons[i,j].setColor(WHITE);
                    //}
                    //else if (board[i,j].value == 'X')
                    //{
                    //    buttons[i,j].setColor(RED);
                    //}
                    //else if (board[i,j].value == 'O')
                    //{
                    //    buttons[i,j].setColor(BLUE);
                    //}
                }
            }
        }

        //Displays the current board to the console
        public void displayBoardToConsole()
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                Console.Write("|");
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i, j].getVal() + "|");
                    
                }
                Console.WriteLine();
            }
        }

        #endregion

        #region Getters

        public Cell[,] getBoard()
        {
            return board;
        }

        public Cell getCell(int x, int y)
        {
            return board[y, x];
        }

        #endregion
    }
}
