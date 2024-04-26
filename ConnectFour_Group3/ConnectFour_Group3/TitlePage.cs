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
    public partial class TitlePage : Form
    {
        public TitlePage()
        {
            InitializeComponent();
            setFormLocation();
        }

        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            SelectGamemode sc = new SelectGamemode(this);
            sc.Show();
            this.Hide();
        }

        private void btnViewStats_Click(object sender, EventArgs e)
        {
            Stats stats = new Stats(this);
            stats.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
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
