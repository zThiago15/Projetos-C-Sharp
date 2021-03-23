using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apMult3
{
    public partial class frmMult3 : Form
    {
        public frmMult3()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int n; //Declarando variável do tipo inteiro
            lstMult.Items.Clear(); //Limpando a caixa de listagem
            for (n = 0; n <= 9; n++)
                lstMult.Items.Add(n * 3); //Adicionando items na caixa de listagem
        }
    }
}
