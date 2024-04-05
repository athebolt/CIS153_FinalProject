using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour_Group3
{
    public class MiniMax
    {
        //TO USE - just call the aiMakeMove function and give it the connect 4 board
        //this will make the best move possible on the board (depending on maxDepth)

        //This variable here controls how many moves the AI can see into the future, I kept it at 5 because at any # higher, it starts to take a while. maxDepth * 7 * 
        //=======================
        private int maxDepth = 5;
        //=======================

        //constructor
        public MiniMax()
        {

        }

        //function to start the algorithm (makes the best move possible on the board)
        public void aiMakeMove(Board board)
        {
            int bestScore = -999;
            int bestMove = 0;
            int score;

            //copy board
            Board copy = new Board(false);

            for (int r = 0; r < board.getRows(); r++)
            {
                for (int c = 0; c < board.getCols(); c++)
                {
                    copy.setCell(r, c, board.getCell(r,c));
                }    
            }

            Console.WriteLine("Algorithm Started");

            //cycle through each playable spot on the board
            for (int c = 0; c < board.getCols(); c++)
            {
                

                //if you can make a move in this column, make it
                if(copy.makeMove(c))
                {

                    //run algorithm
                    score = miniMax(copy, 0, false);

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

            Console.WriteLine("Algorithm Finished");

            Console.WriteLine(bestScore);

            //make the best move
            board.makeMove(bestMove);
        }

        //the actual algorithm, very difficult to decode because it is a recursive function
        private int miniMax(Board copy, int depth, bool isMax)
        {
            int bestScore;
            int whoWon = copy.checkWin();

            if(whoWon == -1)
            {
                return 1;
            }
            else if(whoWon == 1) 
            {
                return -1;
            }
            else if(whoWon == 0 || depth >= maxDepth)
            {
                return 0;
            }

            //if AI turn
            if (isMax)
            {
                //start with the lowest possible score since we are looking for the highest possible (maximizing)
                bestScore = -999;

                for (int c = 0; c < copy.getCols(); c++)
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

                for (int c = 0; c < copy.getCols(); c++)
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
