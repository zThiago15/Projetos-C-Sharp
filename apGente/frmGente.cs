using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apGente
{
    public partial class frmGente : Form
    {
        public frmGente()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            String strTexto; //Declaração variável tipo string
            if (rdbMasculino.Checked) //Se opção for masculina
                strTexto = "Masculino"; //Atribuição conteúdo a strTexto
            else
                strTexto = "Feminino";

            if (rdbCasado.Checked)
                strTexto = strTexto + " " + "Casado"; //Concatenando string
            else if (rdbSolteiro.Checked)
                strTexto = strTexto + " " + "Solteiro";
            else if (rdbViuvo.Checked)
                strTexto = strTexto + " " + "Viúvo";
            else
                strTexto = strTexto + " " + "Outros";
            MessageBox.Show(strTexto);
        }
    }
}
