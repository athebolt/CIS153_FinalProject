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
        //TO USE - just call the aiMakeMove function and give it the connect 4 

        //This variable here controls how many moves the AI can see into the future, I kept it at 6 because at any # higher, it starts to take a while.
        //=======================
        private int depth = 6;
        //=======================

        public MiniMax() {}

        //function to start the algorithm (makes the best move possible on the board)
        public int aiMakeMove(Board board)
        {
            Random random = new Random();
            int bestScore = -1;
            List<int> bestMoves = new List<int>();
            int score;
            Board copy = board;

            //cycle through each playable spot on the board
            for (int c = 0; c < board.getCols(); c++)
            {
                if (copy.makeMove(c)) //if you can make a move in this column, make it
                {
                    score = miniMax(copy, depth, false, c); //run algorithm

                    copy.removeCell(c); //remove the move

                    //keeps track of the best possible place to place a piece. instead of keeping the first best move, i keep all the scores with the highest score (that way i can randomly pick one).
                    if (score == bestScore)
                    {
                        bestMoves.Add(c);
                        continue;
                    }
                    if (score > bestScore)
                    {
                        bestMoves.Clear();
                        bestMoves.Add(c);
                        bestScore = score;
                        continue;
                    }
                }
            }

            //make one of the best moves, if not the best move, on the board (best can vary based on its depth scope)
            if (bestMoves.Count > 0)
            {
                int col = bestMoves[random.Next(0, bestMoves.Count)];
                board.makeMove(col);
                return col;
            }
            else //this will be called if the AI will lose no matter where it places a piece
            {
                for (int i = 0; i < board.getCols(); i++)
                    if (board.makeMove(i))
                        return i;
            }

            //this is if the AI cannot make a move on the board and it is called for some reason (should never happen)
            return -2;
        }

        private int miniMax(Board copy, int depth, bool isMax, int col)
        {
            int whoWon = copy.checkWinV2(col);

            //if there is a win, then we return the score of that win (using the depth). The sooner the move, the higher the depth.
            if (whoWon == -1)
                return depth;

            else if (whoWon == 1)
                return -depth;

            //if we run out of depth or there is a tie, then return a tie.
            else if (whoWon == 0 || depth <= 0)
                return 0;
            
            //start with a best score that is the lowest possible (if were maximizing for example, the lowest score we can get is a tie which is 0, so i set the starting value as -1)
            int bestScore = isMax ? -1 : 1;
            int score;

            for (int c = 0; c < copy.getCols(); c++)
            {
                if (copy.makeMove(c)) //make a move
                {
                    score = miniMax(copy, depth - 1, !isMax, c); //run alg to go deeper one move, pass board, flip player, and pass the column placed (for check win)

                    bestScore = isMax ? Math.Max(bestScore, score) : Math.Min(bestScore, score); //using Math to determine which value is higher (or lower for Min), isMax determines which one we use.

                    copy.removeCell(c); //remove the move
                }
            }

            //return the best score (or worst if minimizing)
            return bestScore;
        }
    }
}
