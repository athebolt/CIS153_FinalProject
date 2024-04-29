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
        private bool closeApp = true;

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
            closeApp = false;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(titlePage, 1);
            form1.Show();
            closeApp = false;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            titlePage.Show();
            closeApp = false;
            this.Close();
        }

        private void SelectGamemode_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (closeApp)
            {
                titlePage.Close();
            }
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
