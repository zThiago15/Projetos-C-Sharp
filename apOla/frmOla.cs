using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apOla
{
    public partial class frmOla : Form
    {
        public frmOla()
        {
            InitializeComponent();
        }

        private void btnOla_Click(object sender, EventArgs e)
        {
            lblMens.Text = "Alô Mundo";
        }

        private void lblMens_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCopia_Click(object sender, EventArgs e)
        {
            txtSaida.Text = txtEntrada.Text;
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtEntrada.Text = "";
            txtSaida.Clear();
        }
    }
}
