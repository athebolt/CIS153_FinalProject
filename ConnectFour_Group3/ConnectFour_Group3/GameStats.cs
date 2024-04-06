using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectFour_Group3
{
    // next:
    // • Accurate tracking and display of game status (ties, total games, etc)
    // • dynamic win percentage (changes based on pulled data)
    // • saving stats function (it will do this on successful game conclusion)
    internal class GameStats
    {
        public int aiWins;
        public int playerWins;
        public int ties;
        public int totalGames;
        public double playerWinP;
        public double aiWinP;

        public void saveStats()
        {
            // logic 
        }
        public void loadStats()
        {
            // get basedirectory of the app where its running
            string stCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            // combine base dir with relative path to the text file, and go up two directories to reach the correct folder
            string stFile = Path.Combine(stCurrentDirectory, @"..\..\GameData\SaveData.txt");
            // turn relative path to absolute path
            string stFilePath = Path.GetFullPath(stFile);

            // check if file path actually exists prior
            if (File.Exists(stFilePath))
            {
                using (StreamReader file = new StreamReader(stFilePath))
                {
                    string line = file.ReadLine();
                    if (line != null)
                    {
                        string[] stats = line.Split(',');
                        if (stats.Length == 6)
                        {
                            aiWins = int.Parse(stats[0]);
                            playerWins = int.Parse(stats[1]);
                            ties = int.Parse(stats[2]);
                            aiWinP = double.Parse(stats[3]);
                            playerWinP = double.Parse(stats[4]);
                            totalGames = int.Parse(stats[5]);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("file not found");
            }
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
                playerWinP = (double)wins / totalGames * 100;
            }
            else
            {
                playerWinP = 0;
            }

            return playerWinP;
        }
    }
}
