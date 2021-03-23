using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apCalcSalLiq
{
    public partial class frmCalcSalLiq : Form
    {
        public frmCalcSalLiq()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double salBruto, inss, irrf, salLiq; //Declarando variáveis locais

            salBruto = (float.Parse(txtSalBruto.Text)); //Transformando string em float para cálculo

            //1° - Cálculo de INSS
            if (salBruto <= 1556.94) 
                inss = salBruto * 8 / 100;
            
            else if (salBruto <= 2594.92)
                inss = salBruto * 9 / 100;
            
            else if (salBruto <= 5189.82)
                inss = salBruto * 11 / 100;
            
            else
                inss = 570.88;

         
            //2° - Cálculo de IRFF
            irrf = salBruto - inss;

            //Isento
            if (irrf <= 1903.98)
                irrf = 0;

            //1° faixa
            else if (irrf <= 2826.65)
                irrf = (irrf * 7.5 / 100) - 142.80;

            //2° faixa
            else if (irrf <= 3751.05)
                irrf = (irrf * 15 / 100) - 354.80;

            //3° faixa
            else if (irrf <= 4664.68)
                irrf = (irrf * 22.5 / 100) - 636.13;

            //4° faixa
            else
                irrf = (irrf * 27.5 / 100) - 869.36;


            // Salário líquido
            salLiq = salBruto - irrf - inss; 
           
            // Impressão dos valores
            txtInss.Text = string.Format("R${0:#0.00}", inss);
            txtIrrf.Text = string.Format("R${0:#0.00}", irrf);
            txtSalLiq.Text = string.Format("R${0:#0.00}", salLiq); 
            

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
