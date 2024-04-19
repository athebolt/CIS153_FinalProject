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

                    Console.WriteLine(score);

                    copy.displayBoardToConsole();

                    Console.WriteLine();

                    copy.removeCell(c); //remove the move

                    //keeps track of the best possible place to place a piece
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

            int col;

            if(bestMoves.Count > 0) //make move on the actual board
                col = bestMoves[random.Next(0, bestMoves.Count)];
            else
                col = random.Next(0, board.getCols());

            board.makeMove(col);

            Console.WriteLine("===============================");

            return col;
        }

        private int miniMax(Board copy, int depth, bool isMax, int col)
        {
            int whoWon = copy.checkWinV2(col);

            if (whoWon == -1)
                return depth;

            else if (whoWon == 1)
                return -depth;

            else if (whoWon == 0 || depth <= 0)
                return 0;

            int bestScore = isMax ? -1 : 1;
            int score;

            for (int c = 0; c < copy.getCols(); c++)
            {
                if (copy.makeMove(c)) //make a move
                {
                    score = miniMax(copy, depth - 1, !isMax, c); //run alg to go deeper one move, pass board, subtract one move, flip player

                    bestScore = isMax ? Math.Max(bestScore, score) : Math.Min(bestScore, score); //new best score? store it

                    copy.removeCell(c); //remove said move
                }
            }

            return bestScore;
        }
    }
}
