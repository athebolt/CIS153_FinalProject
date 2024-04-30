using ConnectFour_Group3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectFour_Group3
{
    public partial class GameOver : Form
    {
        private TitlePage titlePage;
        private Form1 form1;
        private int winner;
        private bool isOnePlayer;
        private bool closeApp;

        public GameOver(TitlePage tp, Form1 f1, int w, bool iop)
        {
            InitializeComponent();

            titlePage = tp;
            form1 = f1;
            winner = w;
            isOnePlayer = iop;
            closeApp = true;

            setFormLocation();

            if (w == 0)
            {
                lbl_go_whoWon.Text = "It's a tie.";
                lbl_go_ties.Font = new Font(lbl_go_ties.Font, FontStyle.Bold);
            }
            else if (w == 1)
            {
                if (isOnePlayer)
                {
                    lbl_go_whoWon.Text = "You Win!";
                }
                else
                {
                    lbl_go_whoWon.Text = "Player 1 Wins!";
                }

                lbl_go_playerWins.Font = new Font(lbl_go_playerWins.Font, FontStyle.Bold);
                lbl_go_playerWins.ForeColor = Color.Green;
                lbl_go_playerWinP.ForeColor = Color.Green;
                lbl_go_AIWinP.ForeColor = Color.Red;
            }
            else
            {
                if (isOnePlayer)
                    lbl_go_whoWon.Text = "AI Player wins";
                else
                    lbl_go_whoWon.Text = "Player 2 Wins!";

                lbl_go_AIWins.Font = new Font(lbl_go_AIWins.Font, FontStyle.Bold);
                lbl_go_AIWins.ForeColor = Color.Green;
                lbl_go_playerWinP.ForeColor = Color.Red;
                lbl_go_AIWinP.ForeColor = Color.Green;
            }

            if(isOnePlayer)
                showStats();
        }

        private void btn_go_playAgain_Click(object sender, EventArgs e)
        {
            form1.closeForm();
            form1 = new Form1(titlePage, isOnePlayer ? 0 : 1);
            form1.Show();
            closeApp = false;
            this.Close();
        }

        private void btn_go_review_Click(object sender, EventArgs e)
        {
            form1.switchToReview();
            form1.Show();
            this.Hide();
        }

        private void btn_go_exit_Click(object sender, EventArgs e)
        {
            titlePage.Show();
            form1.Close();
            closeApp = false;
            this.Close();
        }

        private void GameOver_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (closeApp)
                titlePage.Close();
        }

        private void showStats()
        {
            GameStats stats = new GameStats();

            stats.loadStats();

            lbl_go_playerWins.Visible = true;
            lbl_go_playerWinP.Visible = true;
            lbl_go_AIWins.Visible = true;
            lbl_go_AIWinP.Visible = true;
            lbl_go_totalGames.Visible = true;
            lbl_go_ties.Visible = true;

            lbl_go_playerWins.Text = "Player Wins: " + stats.playerWins.ToString();
            lbl_go_playerWinP.Text = "Player Win %: " + stats.playerWinPct.ToString("0.00")+ "%";
            lbl_go_AIWins.Text = "AI Wins: " + stats.secondPlayerWins.ToString();
            lbl_go_AIWinP.Text = "AI Win %: " + stats.secondPlayerWinPct.ToString("0.00") + "%";
            lbl_go_totalGames.Text = "Total Games: " + stats.totalGames.ToString();
            lbl_go_ties.Text = "Ties: " + stats.ties.ToString();
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
