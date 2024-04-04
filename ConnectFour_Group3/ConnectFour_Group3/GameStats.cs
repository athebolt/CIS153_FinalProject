using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour_Group3
{
    // plan on adding more soon
    internal class GameStats
    {
        public int aiWins;
        public int playerWins;
        public int ties;
        public double winPercentage;

        public void saveStats()
        {
            // logic 
        }
        public void loadStats()
        {
            // logic
        }
        public void updateStats()
        {
            // logic
        }        
        public double calcWinPercentage(int wins)
        {
            int totalGames = aiWins + playerWins + ties;

            if (totalGames > 0) 
            {
                winPercentage = (double)wins / totalGames * 100;
            }
            else
            {
                winPercentage = 0;
            }

            return winPercentage;
        }
    }
}
