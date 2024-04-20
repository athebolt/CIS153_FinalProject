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
        private bool playAgain;

        public GameOver(TitlePage tp, Form1 f1, int w, bool iop)
        {
            InitializeComponent();

            titlePage = tp;
            form1 = f1;
            winner = w;
            isOnePlayer = iop;
            playAgain = false;

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
            form1 = new Form1(titlePage, isOnePlayer? 0 : 1);
            form1.Show();
            playAgain = true;
            this.Close();
        }

        private void btn_go_review_Click(object sender, EventArgs e)
        {
            form1.Show();
        }

        private void btn_go_exit_Click(object sender, EventArgs e)
        {
            titlePage.Show();
            form1.Close();
            this.Close();
        }

        private void GameOver_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!playAgain)
                titlePage.Show();
        }
    }
}
