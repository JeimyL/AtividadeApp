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
    public partial class frmTab : Form
    {
        public frmTab()
        {
            InitializeComponent();
        }

        private void frmTab_Load(object sender, EventArgs e)
        {

        }

        private void btnCalwtab_Click(object sender, EventArgs e)
        {
            int num, produto = 0, i = 1;
            string tabuada = "";
            num = Convert.ToInt32(txtNum.Text);
            {
                while (i <= 10)
                {
                    produto += num;
                    tabuada += num.ToString() + " X " + i.ToString() + " = " + produto.ToString() + Environment.NewLine;
                    i++;
                }
                txtTab.Text = tabuada;
            }
        }

        private void btnCalfwtab_Click(object sender, EventArgs e)
        {
            int num, produto = 0, i = 1;
            string tabuada = "";
            num = Convert.ToInt32(txtNum.Text);
                do
                {
                    produto += num;
                    tabuada += num.ToString() + " X " + i.ToString() + " = " + produto.ToString() + Environment.NewLine;
                    i++;
                } while (i <= 10);
                txtTab.Text = tabuada; 
        }

        private void btnCalftab_Click(object sender, EventArgs e)
        {
            int num, produto = 0;
            string tabuada = "";
            num = Convert.ToInt32(txtNum.Text);
            for (int i = 1; i <= 10; i++)
            {
                produto += num;
                tabuada += num.ToString() + " X " + i.ToString() + " = " + produto.ToString() + Environment.NewLine;
            }
            txtTab.Text = tabuada;
        }

        private void btnLimpartab_Click(object sender, EventArgs e)
        {
            txtNum.Clear();
            txtTab.Clear();
            txtNum.Focus();
        }

        private void btnVoltartab_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            Hide();
            menu.Show();
        }
    }
}
