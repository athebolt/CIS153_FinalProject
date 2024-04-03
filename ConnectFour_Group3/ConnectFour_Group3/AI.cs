using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConnectFour_Group3
{
    internal class AI
    {
        //the idea for the AI is to use a minimax algorithm
        //for now, this is going to be a basic outline
        //for how I want to make the AI

        //constructor
        public AI()
        {

        }


        //======================================================================

        //function to start the algorithm (will return best placement)

        //copy the board

        //cycle through each playable spot on the baord
        //{
            //place a piece on the board
            
            //int score = minimax(copy, 0 (depth), false);
            
            //if score > bestScore
                //this is the best spot to place a piece
                
            //erase cell from board
                
        //}

        //return best spot to place piece (or place it on the board)

        //======================================================================



        //======================================================================

        //int minimax function - params(board, depth, isMax)

        //check for a win or tie (will prob call gameDriver to check for win states)

        //int to hold bestScore

        //if isMax
        //{

            //bestScore = -999;

            //cycle through all the spots on the board that can be played.
            //{
                //place a piece on the board

                //int score = call minimax (board, depth + 1, false);

                //if score > bestScore
                    //bestScore = score;

                //remove board piece
            //}
        //}

        //else
        //{
            //bestScore = 999;

            //cycle through all the spots on the board that can be played.
            //{
                //place a piece on the board

                //int score = call minimax (board, depth + 1, false);

                //if score < bestScore
                    //bestScore = score;

                //remove board piece
            //}
        //}

        //return bestScore

        //====================================================================
    }
}
