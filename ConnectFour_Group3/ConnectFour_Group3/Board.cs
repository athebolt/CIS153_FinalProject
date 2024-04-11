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
        private PictureBox[,] grid = new PictureBox[6, 7];
        //True when player 1 move, false when player 2 move (OR AI MOVE)
        private bool isPlayerMove;
        private bool playerStarts;

        #region Constructors

        /// <summary>
        /// Creates a new empty board, with the player being the one that starts
        /// </summary>
        public Board()
        {
            fillBoard();
            this.isPlayerMove = true;
            this.playerStarts = true;
        }

        /// <summary>
        /// Creates a new empty board, with isPlayerMove deciding whether or not the player starts
        /// </summary>
        /// <param name="isPlayerMove">If true, the player starts; if false, the AI/second player starts</param>
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

        //this version will check for wins in all directions at the same time
        public int checkWinV2()
        {
            for (int r = 0; r < getRows(); r++)
            {
                for (int c = 0; c < getCols(); c++)
                {
                    if (board[r, c].isEmpty())
                        continue; //if this cell is empty, skip this iteration

                    bool horizontal = c + 3 < getCols(); //is it possible to get a horizontal win
                    bool vertical = r + 3 < getRows(); //is it possible to get a vertical win

                    if (!horizontal && !vertical)
                        continue; //if neither are possible, skip this iteration

                    bool forwardDiag = horizontal && vertical; //if both a horizontal and vertical win are possible, then a forward diagonal is possible
                    bool backwardDiag = c - 3 >= 0 && vertical; //if we can go backwards 3 cells and go up 3, then a backwards win is possible

                    for (int i = 1; i < 4; i++) //checks the next 3 spots in each direction to see the value in the original space is equal to the value of the next 3 spaces (4 in a row)
                    {
                        horizontal = horizontal && board[r, c].getVal() == board[r, c + i].getVal();
                        vertical = vertical && board[r, c].getVal() == board[r + i, c].getVal();
                        forwardDiag = forwardDiag && board[r, c].getVal() == board[r + i, c + i].getVal();
                        backwardDiag = backwardDiag && board[r, c].getVal() == board[r + i, c - i].getVal();
                        if (!horizontal && !vertical && !forwardDiag && !backwardDiag)
                            break; //the second that a win is not possible in any direction, move to the next cell
                    }

                    if (horizontal || vertical || forwardDiag || backwardDiag) //if there 4 in a row in any direction, that player is the winner
                        return isPlayerMove? -1 : 1; //win for either player
                }
            }

            if(isFull())
                return 0; //tie

            return -2; //no win
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
            this.grid = grid;
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
        /// Fills the buttons with the proper colors (MUST CALL THE OVERLOADED VERSION FIRST)
        /// </summary>
        public void displayToForm()
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j].getVal() == ' ')
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

        public bool isFull()
        {
            for (int c = 0; c < getCols(); c++) //checking to see if the board is full (if all the top columns are taken)
            {
                if (board[0, c].isEmpty())
                    return false; // there is at least one open space
            }

            return true; //full board
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
