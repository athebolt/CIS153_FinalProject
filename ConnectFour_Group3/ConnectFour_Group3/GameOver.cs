using ConnectFour_Group3;
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
    public partial class GameOver : Form
    {
        private TitlePage titlePage;
        private Form1 form1;
        private int winner;

        public GameOver(TitlePage tp, Form1 f1, int w, bool isOnePlayer)
        {
            InitializeComponent();

            titlePage = tp;
            form1 = f1;
            winner = w;

            if(w == 0)
            {
                lbl_go_whoWon.Text = "It's a tie.";
            }
            else if(w == 1)
            {
                lbl_go_whoWon.Text = "Player 1 wins!";

                lbl_go_whoWon.ForeColor = Color.Red;
            }
            else
            {
                if (isOnePlayer)
                    lbl_go_whoWon.Text = "AI wins.";
                else
                    lbl_go_whoWon.Text = "Player 2 wins!";

                lbl_go_whoWon.ForeColor = Color.Blue;
            }
        }

        private void btn_go_playAgain_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Close();
        }

        private void btn_go_review_Click(object sender, EventArgs e)
        {
            form1.Show();
        }

        private void btn_go_exit_Click(object sender, EventArgs e)
        {
            titlePage.Show();
            this.Close();
        }

        private void GameOver_FormClosed(object sender, FormClosedEventArgs e)
        {
            titlePage.Show();
        }
    }
}
