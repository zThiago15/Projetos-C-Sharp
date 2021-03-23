using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apSal
{
    public partial class frmSal : Form
    {
        public frmSal()
        {
            InitializeComponent();
        }

        private void frmSal_Load(object sender, EventArgs e)
        {
            
        }

        private void txtPorcento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSalA_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double dblSal, dblPorcento; //Declarando variveis locais
            dblSal = (float.Parse(txtSalA.Text)); //Transformando String em float
            dblPorcento = float.Parse(txtPorcento.Text);
            dblSal *= (1 + (dblPorcento / 100)); //Efetuando o cálculo
            txtSalC.Text = string.Format("{0:#0.00}", dblSal); //Formatando Moeda
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
