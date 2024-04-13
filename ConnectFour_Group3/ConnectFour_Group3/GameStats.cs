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
        public int aiWins;
        public int playerWins;
        public int ties;
        public int totalGames;
        public double playerWinP;
        public double aiWinP;

        public void saveStats()
        {
            calcWinPercentage();

            string stCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string stFile = Path.Combine(stCurrentDirectory, @"..\..\GameData\SaveData.txt");
            string stFilePath = Path.GetFullPath(stFile);
            string newLine = $"{aiWins},{playerWins},{ties},{totalGames},{playerWinP:0.00},{aiWinP:0.00}";

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
                            aiWins = int.Parse(stats[0]);
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

            MessageBox.Show($"game outcome : {outcome}"); // Debug line

            switch (outcome)
            {
                // from board class
                case 1:
                    playerWins++;
                    break;
                case -1:
                    aiWins++;
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
            totalGames = aiWins + playerWins + ties;

            if (totalGames > 0)
            {
                aiWinP = (double)aiWins / totalGames * 100;
                playerWinP = (double)playerWins / totalGames * 100;
            }
            else
            {
                aiWinP = 0;
                playerWinP = 0;
            }
        }
        public void initializeStats()
        {
            aiWins = 0;
            playerWins = 0;
            ties = 0;
            totalGames = 0;
            playerWinP = 0;
            aiWinP = 0;
        }
    }
}
