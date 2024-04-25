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
    public partial class SelectGamemode : Form
    {
        private TitlePage titlePage;
        private bool openedGame = false;

        public SelectGamemode(TitlePage tp)
        {
            InitializeComponent();

            setFormLocation();

            titlePage = tp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(titlePage, 0);
            form1.Show();
            openedGame = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(titlePage, 1);
            form1.Show();
            openedGame = true;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            titlePage.Show();
            this.Close();
        }

        private void SelectGamemode_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!openedGame)
                titlePage.Show();
        }
        private void setFormLocation()
        {
            this.StartPosition = FormStartPosition.Manual;

            this.Top = 500;
            this.Left = 1100;
        }
    }
}
