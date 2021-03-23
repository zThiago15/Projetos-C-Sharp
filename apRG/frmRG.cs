using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apRG
{
    public partial class frmRG : Form
    {
        public frmRG()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int I, N = 0, DC; //Declarando variáveis
            int[] NUMV; //Declarando vetor
            NUMV = new int[8]; //Construindo o vetor

            for (I = 0; I <= NUMV.Length - 1; I++)
            {
                NUMV[I] = int.Parse(txtRg.Text.Substring(I, 1));
            }

            for (I = 0; I <= NUMV.Length - 1; I++)
            {
                N = N + NUMV[I] * (I + 2);
            }

            DC = (11 - (N % 11));
            if (DC > 9)
                MessageBox.Show("X");
            else
                MessageBox.Show(""+DC);

        /*
         Ajuda:
            NUMV.Length : Retorna o número de elementos do vetor. 
            Não se esqueça: o primeiro  elemento do vetor é o elemento 0.
            
            txtRg.Text.Substring(I, 1): Retorna pedaço da String.
                Substring(Posição inicial, quantidade de caracteres).
                No programa retorna um caractere a partir da posição I.       
        */

        }
    }
}
