using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apCodBar
{
    public partial class frmCodBar : Form
    {
        public frmCodBar()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Declarando variáveis
            int I, numVerificacao, Soma = 0;
            int[] numBar; //Declarando vetor pra todos os números
            int[] pais; //Declarando vetor para pegar só os 3 números  pra descobrir o país

            //Construindo vetores
            numBar = new int[13];
            pais = new int[3];

            //Recebendo os valores
            for (I = 0; I <= numBar.Length - 1; I++)
            {
                numBar[I] = int.Parse(txtCod.Text.Substring(I, 1));

            }

            //Descobrindo o país
            for (I = 0; I <= 0; I++)
            {
                //Recebe os 3 primeiros dígitos a partir da posição 0
                pais[I] = int.Parse(txtCod.Text.Substring(I, 3));

                //789 ou 790 - Brasil 
                if (pais[I] == 789 || pais[I] == 790)
                {
                    txtPais.Text = string.Format("Brasil");
                }

                //066 - Estados Unidos
                else if (pais[I] == 066)
                {
                    txtPais.Text = string.Format("EUA");
                }

                //Outro país
                else
                {
                    txtPais.Text = string.Format("Outro país");
                }
            }

            //Multiplicando e somando

            for (I = 0; I <= 11; I++)
            {
                if (I % 2 != 0)
                {
                    Soma += numBar[I] * 3;
                }
                else
                {
                    Soma += numBar[I];
                }
            }

            //Calculando o dígito de verificação
            numVerificacao = 10 - (Soma % 10);

            if (Soma % 10 == 0)
            {
                numVerificacao = 0;
            }

            //Mostrando o número de verificação
            txtVerif.Text = string.Format("" + numVerificacao);

            //Verificando se foi digitado corretamente
            if (numVerificacao != numBar[numBar.Length - 1])
            {
                MessageBox.Show("Número inválido! Por favor, digite novamente.");
            }
            else
            {
                MessageBox.Show("Foi digitado corretamente!");
            }

        
            /* 
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
             */









            //for (I = 0; I <= numV.Length - 1; I++)
            //{
            //    if(numV[I] % 2 != 0)
            //    {
            //        Mult3 = numV[I] * 3;
            //        Soma += Mult3;
            //    }

            //    else
            //    {
            //        Soma += numV[I]; 
            //    }                  
            //}

            //if (Soma % 10 == 0)
            //    numVerificacao = 0;
            //else
            //    numVerificacao = 10 - (Soma % 10);

            // MessageBox.Show(""+numVerificacao);

            /*
            Ajuda:
            NUMV.Length : Retorna o número de elementos do vetor. 
            Não se esqueça: o primeiro elemento do vetor é o elemento 0.

            txtRg.Text.Substring(I, 1): Retorna pedaço da String.
                Substring(Posição inicial, quantidade de caracteres).
                No programa retorna um caractere a partir da posição I.       
            */

        }
    }
}
