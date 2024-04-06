using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectFour_Group3
{

    public partial class Stats : Form
    {
        private GameStats gameStats;
        public Stats()
        {
            InitializeComponent();

            gameStats = new GameStats();

            gameStats.loadStats();

            ctrPlayerWins.Text = gameStats.playerWins.ToString();
            ctrAIWins.Text = gameStats.aiWins.ToString();
            ctrPlayerWinPer.Text = gameStats.playerWinP.ToString();
            ctrAIWinPer.Text = gameStats.aiWinP.ToString();

            // adding total games and ties once Tristan adds the labels.
        }
    }
}
