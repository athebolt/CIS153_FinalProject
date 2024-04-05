using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        private bool playerStarts;

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
            this.playerStarts = isPlayerMove;
        }

        #endregion

        #region Functions

        /// <summary>
        /// Fills the board with cells that know their location and have a value of ' '
        /// </summary>
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

        /// <summary>
        /// Finds out whether the current board has a four in a row
        /// </summary>
        /// <returns>1 for player2 win/AI win<br></br>0 for tie<br></br>-1 for player1 win<br></br>-2 for no win</returns>
        public int checkWin()
        {
            bool boardFull = true;
            //First we check for horiontal wins
            for (int i = 0; i < board.GetLength(0); i++)
            {
                int x = 0;
                int o = 0;
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i,j].getVal() == ' ')
                    {
                        x = 0;
                        o = 0;
                        //Since this passes across the full board, we only check this in the horizontal check
                        boardFull = false;
                    }
                    if (board[i,j].getVal() == 'X')
                    {
                        x++;
                        o = 0;
                    }
                    if (board[i,j].getVal() == 'O')
                    {
                        x = 0;
                        o++;
                    }
                    if (x >= 4)
                    {
                        return (playerStarts ? 1 : -1);
                    }
                    if (o >= 4)
                    {
                        return (playerStarts ? -1 : 1);
                    }
                }
            }
            //Next we check for vertical wins
            for (int j = 0; j < board.GetLength(1); j++)
            {
                int x = 0;
                int o = 0;
                for (int i = 0; i < board.GetLength(0); i++)
                {
                    if (board[i, j].getVal() == ' ')
                    {
                        x = 0;
                        o = 0;
                    }
                    if (board[i, j].getVal() == 'X')
                    {
                        x++;
                        o = 0;
                    }
                    if (board[i, j].getVal() == 'O')
                    {
                        x = 0;
                        o++;
                    }
                    if (x >= 4)
                    {
                        return (playerStarts ? 1 : -1);
                    }
                    if (o >= 4)
                    {
                        return (playerStarts ? -1 : 1);
                    }
                }
            }
            //Diagonal checks are weird but oh well
            for (int i = 0; i < board.GetLength(0) - 3; i++)
            {
                for (int j = 0; j < board.GetLength(1) - 3; j++)
                {
                    if (board[i,j].getVal() == 'X' && board[i + 1,j + 1].getVal() == 'X' && board[i + 2, j + 2].getVal() == 'X' && board[i + 3, j + 3].getVal() == 'X')
                    {
                        return (playerStarts ? 1 : -1);
                    }
                    if (board[i, j].getVal() == 'O' && board[i + 1, j + 1].getVal() == 'O' && board[i + 2, j + 2].getVal() == 'O' && board[i + 3, j + 3].getVal() == 'O')
                    {
                        return (playerStarts ? -1 : 1);
                    }
                }
            }
            for (int i = 3; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1) - 3; j++)
                {
                    if (board[i, j].getVal() == 'X' && board[i - 1, j + 1].getVal() == 'X' && board[i - 2, j + 2].getVal() == 'X' && board[i - 3, j + 3].getVal() == 'X')
                    {
                        return (playerStarts ? 1 : -1);
                    }
                    if (board[i, j].getVal() == 'O' && board[i - 1, j + 1].getVal() == 'O' && board[i - 2, j + 2].getVal() == 'O' && board[i - 3, j + 3].getVal() == 'O')
                    {
                        return (playerStarts ? -1 : 1);
                    }
                }
            }
            //If we've gotten here, there is no wins. If the board is full, return 0. If not, return -2
            if (boardFull)
            {
                return 0;
            }
            else
            {
                return -2;
            }
        }

        /// <summary>
        /// Makes a move in the given column (0-6), returning true if the move is possible and false if it is not
        /// </summary>
        /// <param name="col"></param>
        /// <returns>True if move succeeds<br></br>False if move is impossible</returns>
        public bool makeMove(int col)
        {
            bool moveComplete = false;
            for (int i = board.GetLength(0) - 1; i >= 0; i--)
            {
                if (board[i, col].isEmpty())
                {
                    moveComplete = true;
                    board[i, col].setVal(!(isPlayerMove ^ playerStarts) ? 'X' : 'O');
                    isPlayerMove = !isPlayerMove;
                    break;
                }
            }
            return moveComplete;
        }

        /// <summary>
        /// When provided with an array of every PictureBox, fills the buttons with the proper colors
        /// </summary>
        /// <param name="grid"></param>
        public void displayToForm(ref PictureBox[,] grid)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i,j].getVal() == ' ')
                    {
                        grid[i, j].Image = Properties.Resources.gray;
                        continue;
                    }
                    if (board[i, j].getVal() == 'X')
                    {
                        grid[i, j].Image = Properties.Resources.red;
                        continue;
                    }
                    if (board[i, j].getVal() == 'O')
                    {
                        grid[i, j].Image = Properties.Resources.blue;
                        continue;
                    }
                }
            }
        }

        /// <summary>
        /// Displays the current board to the console
        /// </summary>
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

        public void setCell(int r, int c, Cell val)
        {
            board[r, c] = val;
        }

        public void removeCell(int col)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                if (!board[i, col].isEmpty())
                {
                    isPlayerMove = !isPlayerMove;
                    board[i, col].setVal(' ');
                    break;
                }
            }
        }

        #endregion

        #region Getters

        public Cell[,] getBoard()
        {
            return board;
        }

        public Cell getCell(int r, int c)
        {
            return board[r, c];
        }

        public int getRows()
        {
            return board.GetLength(0);
        }

        public int getCols()
        {
            return board.GetLength(1);
        }

        #endregion
    }
}
