using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void tsmiTab_Click(object sender, EventArgs e)
        {
            frmTab tab = new frmTab();
            Hide();
            tab.Show();
        }

        private void tsmiSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmiGraus_Click(object sender, EventArgs e)
        {
            frmGraus graus = new frmGraus();
            Hide();
            graus.Show();
        }

        private void tsmiArea_Click(object sender, EventArgs e)
        {
            frmArea area = new frmArea();
            Hide();
            area.Show();
        }
    }
}
