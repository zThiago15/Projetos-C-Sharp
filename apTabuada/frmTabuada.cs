using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apTabuada
{
    public partial class frmTabuada : Form
    {
        public frmTabuada()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void frmTabuada_Load(object sender, EventArgs e)
        {

        }

        private void btnMostra_Click(object sender, EventArgs e)
        {
            int num, i, resultado; //Declarando variáveis

            num = int.Parse(txtNumTabua.Text); //Transformando string em int para cálculo

            for (i = 0; i <= 10; i++) //Criando um laço com 10 repetições para cada número da tabuada
            {
                resultado = num * i; //Calculando
                lstTabuada.Items.Add(i + " X " + num + " = " + resultado); //Imprimindo os valores
            }
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            lstTabuada.Text = ""; //Limpando a caixa de listagem
        }
    }
}
