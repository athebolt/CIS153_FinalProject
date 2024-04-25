using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

        //if true, no one can play on the board
        private bool isLocked = false;

        //for checkWin
        private bool boardChanged = false;
        private int winner = -2;

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

        //only checks the last placed piece if it makes a win (rather than every cell)
        public int checkWinV2(int col)
        {
            //a fail safe in case if the ai somehow didnt make a move
            if (col == -2)
                return -2;

            if(boardChanged)
            {
                boardChanged = false;

                //what is returned for each outcome
                int player1Win = 1;
                int player2Win = -1;
                int tie = 0;
                int noWin = -2;

                //finding the last placed piece's value and pos
                for (int row = 0; row < board.GetLength(0); row++)
                {
                    if (!board[row, col].isEmpty())
                    {
                        int horizontal = 1;
                        int vertical = 1;
                        int forwardDiag = 1;
                        int backDiag = 1;

                        //determines if we can go in a direction
                        bool left;
                        bool right;
                        bool up;
                        bool down;

                        bool leftUp;
                        bool leftDown;
                        bool rightUp;
                        bool rightDown;

                        //makes sure that all the pieces are touching (idk how else to explain)
                        bool leftRow = true;
                        bool rightRow = true;
                        bool upRow = true;
                        bool downRow = true;

                        bool leftUpRow = true;
                        bool leftDownRow = true;
                        bool rightUpRow = true;
                        bool rightDownRow = true;

                        for (int i = 1; i < 4; i++)
                        {
                            //determines if we can go in a direction
                            left = 0 <= col - i;
                            right = getCols() > col + i;
                            up = 0 <= row - i;
                            down = getRows() > row + i;

                            leftUp = left && up;
                            leftDown = left && down;
                            rightUp = right && up;
                            rightDown = right && down;

                            //Console.WriteLine("leftUp: " + leftUp);
                            //Console.WriteLine("rightUp: " +  rightUp);
                            //Console.WriteLine("leftDown: " + leftDown);
                            //Console.WriteLine("rightDown:" + rightDown);
                            //Console.WriteLine();
                            //Console.WriteLine();

                            //checking in each direction to see if it matches the placed piece
                            if (left && board[row, col].getVal() == board[row, col - i].getVal() && leftRow)
                                horizontal++;
                            else
                                leftRow = false;

                            if (right && board[row, col].getVal() == board[row, col + i].getVal() && rightRow)
                                horizontal++;
                            else
                                rightRow = false;

                            if (down && board[row, col].getVal() == board[row + i, col].getVal() && downRow)
                                vertical++;
                            else
                                downRow = false;

                            if (up && board[row, col].getVal() == board[row - i, col].getVal() && upRow)
                                vertical++;
                            else
                                upRow = false;

                            //diagonal checks
                            if (leftUp && board[row, col].getVal() == board[row - i, col - i].getVal() && leftUpRow)
                                backDiag++;
                            else
                                leftUpRow = false;

                            if (rightUp && board[row, col].getVal() == board[row - i, col + i].getVal() && rightUpRow)
                                forwardDiag++;
                            else
                                rightUpRow = false;

                            if (leftDown && board[row, col].getVal() == board[row + i, col - i].getVal() && leftDownRow)
                                forwardDiag++;
                            else
                                leftDownRow = false;

                            if (rightDown && board[row, col].getVal() == board[row + i, col + i].getVal() && rightDownRow)
                                backDiag++;
                            else
                                rightDownRow = false;
                            
                            if (!left && !right && !up && !down && !leftUp && !leftDown && !rightUp && !rightDown) //if no wins are possible, skip checking
                                break;
                        }

                        //Console.WriteLine("horiz: " + (leftCnt + rightCnt + 1));
                        //Console.WriteLine("vert: " + (upCnt + downCnt + 1));
                        //Console.WriteLine("forward: " + rightUpCnt + " + " + leftDownCnt);
                        //Console.WriteLine("backward: " + leftUpCnt + " + " + rightDownCnt);

                        if (horizontal >= 4 || vertical >= 4 || forwardDiag >= 4 || backDiag >= 4) //if there are any wins, determine winner
                        {
                            winner = !isPlayerMove ? player1Win : player2Win;
                            return !isPlayerMove ? player1Win : player2Win;
                        }

                        if (isFull()) //if the board is full and no one won, then its a tie
                        {
                            winner = tie;
                            return tie;
                        }

                        break;
                    }
                }

                winner = noWin;
                return noWin;
            }

            return winner;
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
                    boardChanged = true;
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
                    boardChanged = true;
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

        public bool isGameOver()
        {
            return isLocked;
        }

        public void lockBoard()
        {
            isLocked = true;
            Console.WriteLine("locked");
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
