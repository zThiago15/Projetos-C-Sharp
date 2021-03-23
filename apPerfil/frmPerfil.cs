using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apPerfil
{
    public partial class frmPerfil : Form
    {
        public frmPerfil()
        {
            InitializeComponent();
        }

        private void frmPerfil_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnProcessa_Click(object sender, EventArgs e)
        {
            String strMensagem, strSexo, strEstCivil, strReligiao, strBens;

            if (rdbMasc.Checked)
                strSexo = rdbMasc.Text;
            else
                strSexo = rdbFem.Text;
            if (rdbCasado.Checked)
                strEstCivil = rdbCasado.Text;
            else if (rdbSolteiro.Checked)
                strEstCivil = rdbSolteiro.Text;
            else
                strEstCivil = rdbViuvo.Text;

            strReligiao = (string)cboReligiao.SelectedItem;

            strBens = "";
            if (chkImovel.Checked)
                strBens = "imóvel";
            if (chkCarro.Checked)
                if (strBens == "")
                    strBens = "carro";
                else
                    strBens = strBens + ", carro";

            if (chkBarco.Checked)
                if (strBens.Length == 0)
                    strBens = "barco";
                else
                    strBens = strBens + ", barco";

            if (chkArte.Checked)
                if (strBens.Length == 0)
                    strBens = "obra de arte";
                else
                    strBens = strBens + ", obra de arte";

            strMensagem = "Meu nome é "+ txtNome.Text + " sou do sexo " + strSexo + ", " 
            + strEstCivil + ", " + strReligiao + " e tenho: " + strBens;

            MessageBox.Show(strMensagem);
        }
    }
}
