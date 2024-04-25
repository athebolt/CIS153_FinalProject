using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectFour_Group3
{
    // next: limit decimal count in static menu
    // next: refine code
    // next: bug test, prob tons of bugz
    
    internal class GameStats
    {
        public int secondPlayerWins;
        public int playerWins;
        public int ties;
        public int totalGames;
        public double playerWinPct;
        public double secondPlayerWinPct;

        public void saveStats()
        {
            calcWinPercentage();

            string stCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string stFile = Path.Combine(stCurrentDirectory, @"..\..\GameData\SaveData.txt");
            string stFilePath = Path.GetFullPath(stFile);
            string newLine = $"{secondPlayerWins},{playerWins},{ties},{totalGames},{playerWinPct:0.00},{secondPlayerWinPct:0.00}";

            // Overwrite the file content with the new line
            File.WriteAllText(stFilePath, newLine);

        }
        public void loadStats()
        {
            string stCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string stFile = Path.Combine(stCurrentDirectory, @"..\..\GameData\SaveData.txt");
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
                            secondPlayerWins = int.Parse(stats[0]);
                            playerWins = int.Parse(stats[1]);
                            ties = int.Parse(stats[2]);
                            totalGames = int.Parse(stats[3]);
                        }
                    }
                    else
                    {
                        initializeStats();                        
                    }
                }
                calcWinPercentage();
            }
            else
            {
                initializeStats();
                
                MessageBox.Show("file not found");
            }
        }
        public void updateStats(int outcome)
        {
            totalGames++; // change so this doesnt update at end?

            //MessageBox.Show($"game outcome : {outcome}"); // Debug line

            switch (outcome)
            {
                // from board class
                case 1:
                    playerWins++;
                    break;
                case -1:
                    secondPlayerWins++;
                    break;
                case 0:
                    ties++;
                    break;
            }
            calcWinPercentage();
            saveStats();
        }
        public void calcWinPercentage()
        {
            totalGames = secondPlayerWins + playerWins + ties;

            if (totalGames > 0)
            {
                secondPlayerWinPct = (double)secondPlayerWins / totalGames * 100;
                playerWinPct = (double)playerWins / totalGames * 100;
            }
            else
            {
                secondPlayerWinPct = 0;
                playerWinPct = 0;
            }
        }
        public void initializeStats()
        {
            secondPlayerWins = 0;
            playerWins = 0;
            ties = 0;
            totalGames = 0;
            playerWinPct = 0;
            secondPlayerWinPct = 0;
        }
    }
}
