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
        private TitlePage titlePage;

        public Stats(TitlePage tp)
        {
            InitializeComponent();

            titlePage = tp;

            setFormLocation();

            gameStats = new GameStats();

            gameStats.loadStats();

            ctrPlayerWins.Text = gameStats.playerWins.ToString();
            ctrAIWins.Text = gameStats.secondPlayerWins.ToString();
            ctrPlayerWinPer.Text = gameStats.playerWinPct.ToString();
            ctrAIWinPer.Text = gameStats.secondPlayerWinPct.ToString();
            ctrTotalGames.Text = gameStats.totalGames.ToString();
            ctrTies.Text = gameStats.ties.ToString();
        }

        private void Stats_FormClosed(object sender, FormClosedEventArgs e)
        {
            titlePage.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            titlePage.Show();
            this.Close();
        }
        private void setFormLocation()
        {
            this.StartPosition = FormStartPosition.Manual;

            int screenW = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            int screenH = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;

            this.Top = screenH;
            this.Left = screenW;
        }
    }
}
