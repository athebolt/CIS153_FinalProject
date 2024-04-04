using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour_Group3
{
    internal class MiniMax
    {
        //TO USE - just call the miniMaxStart function and give it the board
        //this will make the best move possible on the board

        //constructor
        public MiniMax()
        {

        }

        //function to start the algorithm (makes the best move possible on the board)
        public void miniMaxStart(Board board)
        {
            int bestScore = -999;
            int bestMove = 0;
            
            //copy board
            Board copy = new Board(false);

            for (int r = 0; r <= board.getRows() - 1; r++)
            {
                for (int c = 0; c <= board.getCols(); c++)
                {
                    copy.setCell(r, c, board.getCell(r,c));
                }    
            }

            //cycle through each playable spot on the board
            for (int c = 0; c <= board.getCols() - 1; c++)
            {
                //if you can make a move in this column, make it
                if(copy.makeMove(c))
                {
                    //run algorithm
                    int score = miniMax(copy, 0, false);

                    //keeps track of the best possible place to place a piece
                    if (score > bestScore)
                    {
                        bestScore = score;

                        bestMove = c;
                    }

                    //remove the piece from the board
                    copy.removeCell(c);
                }
            }

            //make the best move
            board.makeMove(bestMove);
        }

        //the actual algorithm
        private int miniMax(Board copy, int depth, bool isMax)
        {
            int bestScore;

            //pseudocode for now (these functions may not exist)
            //check for a win or tie
            //if(AIWon())
            //{
            ////subtracting the depth to make the soonest win the best score
            //return 100 - depth;
            //}
            //else if(PlayerWon())
            //{
            ////adding depth this time because its the inverse (lowest score is the best in this case)
            //return -100 + depth;
            //}
            //else if(Tie())
            //{
                //return 0;
            //}

            //if AI turn
            if (isMax)
            {
                //start with the lowest possible score since we are looking for the highest possible (maximizing)
                bestScore = -999;

                for (int c = 0; c <= copy.getCols() - 1; c++)
                {
                    if(copy.makeMove(c))
                    {
                        int score = miniMax(copy, depth + 1, false);

                        if (score > bestScore)
                            bestScore = score;

                        copy.removeCell(c);
                    }
                }
            }
            //else player turn
            else
            {
                //start with the highest possible score since we are looking for the lowest possible (minimizing)
                bestScore = 999;

                for (int c = 0; c <= copy.getCols() - 1; c++)
                {
                    if(copy.makeMove(c))
                    {
                        int score = miniMax(copy, depth + 1, true);

                        if (score < bestScore)
                            bestScore = score;

                        copy.removeCell(c);
                    }
                }
            }

            return bestScore;
        }
    }
}
