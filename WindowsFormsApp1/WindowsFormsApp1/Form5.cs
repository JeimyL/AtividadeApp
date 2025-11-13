using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace WindowsFormsApp1
{
    public partial class frmArea : Form
    {
        public frmArea()
        {
            InitializeComponent();
        }
        double areatotal = 0.0, larg = 0.0, comp = 0.0, areacmd = 0.0;

        private void btnLimpararea_Click(object sender, EventArgs e)
        {
            txtLargcom.Clear();
            txtCompcom.Clear();
            txtQtdcom.Focus();
            txtAcom.Clear();
            txtAres.Clear();
        }

        private void btnVoltararea_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            Hide();
            menu.Show();
        }

        DialogResult resultado = DialogResult.Yes;
        private void btncalcular_Click(object sender, EventArgs e)
        {
            larg = Convert.ToDouble(txtLargcom.Text);
            comp = Convert.ToDouble(txtCompcom.Text);
            areacmd = larg * comp;
            areatotal += areacmd;
            txtAcom.Text = areacmd.ToString();

            resultado = MessageBox.Show("Deseja adicionar outro cômodo?", "Continuar", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                txtAres.Clear();
                txtCompcom.Clear();
                txtLargcom.Clear();
                txtLargcom.Focus();

            }
            else if (resultado == DialogResult.No)
            {

                txtAres.Text = areatotal.ToString();
                {
                }
            }
        }
    }
}
