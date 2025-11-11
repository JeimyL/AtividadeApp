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
    public partial class frmGraus : Form
    {
        public frmGraus()
        {
            InitializeComponent();
        }

        private void btnCalwgraus_Click(object sender, EventArgs e)
        {
            int i = 10;
            double F;
            while (i <= 100)
            {
                F = (i * 1.8) + 32;
                txtGrausc.Text += String.Format("\n" + i.ToString());
                txtGrausf.Text += String.Format("\n" + F.ToString());
                i += 10;
            }
        }

        private void btnCalfwgraus_Click(object sender, EventArgs e)
        {
            int i = 10;
            double F;
            do
            {
                F = (i * 1.8) + 32;
                txtGrausc.Text += String.Format("\n" + i.ToString());
                txtGrausf.Text += String.Format("\n" + F.ToString());
                i += 10;
            } while (i <= 100);
        }

        private void btnCalfgraus_Click(object sender, EventArgs e)
        {
            double F;
            for (int i = 10; i <= 100; i += 10)
            {
                F = (i * 1.8) + 32;
                txtGrausc.Text += String.Format("\n" + i.ToString());
                txtGrausf.Text += String.Format("\n" + F.ToString());
            }
        }

        private void btnLimpargraus_Click(object sender, EventArgs e)
        {
            txtGrausc.Clear();
            txtGrausf.Clear();
        }

        private void btnVoltargraus_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            Hide();
            menu.Show();
        }
    }
}

