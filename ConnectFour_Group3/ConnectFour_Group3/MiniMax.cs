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

        //This variable here controls how many moves the AI can see into the future, I kept it at 5 because at any # higher, it starts to take a while.
        //=======================
        private int depth = 6;
        //=======================

        //constructor
        public MiniMax()
        {

        }

        //function to start the algorithm (makes the best move possible on the board)
        public void aiMakeMove(Board board)
        {
            int bestScore = -1;
            int bestMove = 0;
            int score;
            Board copy = board;

            //cycle through each playable spot on the board
            for (int c = 0; c < board.getCols(); c++)
            {
                //if you can make a move in this column, make it
                if (copy.makeMove(c))
                {
                    score = miniMax(copy, depth, false); //run algorithm

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

            Console.WriteLine(bestScore);

            //make the best move
            board.makeMove(bestMove);
        }

        //the actual algorithm, very difficult to debug because it is a recursive function
        private int miniMax(Board copy, int depth, bool isMax)
        {
            //check for a win or tie
            int whoWon = copy.checkWinV2();

            //return if there is a win or tie
            if(whoWon == -1)
                return depth;
            else if(whoWon == 1) 
                return -depth;
            else if(whoWon == 0 || depth <= 0)
                return 0;

            int bestScore = isMax ? -1 : 1;
            int score;

            for (int c = 0; c < copy.getCols(); c++)
            {
                if (copy.makeMove(c)) //make a move
                {
                    score = miniMax(copy, depth - 1, !isMax); //run alg to go deeper one move, pass board, subtract one move, flip player
                    bestScore = isMax ? Math.Max(bestScore, score) : Math.Min(bestScore, score); //new best score? store it
                    copy.removeCell(c); //remove said move
                }
            }

            return bestScore;
        }
    }
}
