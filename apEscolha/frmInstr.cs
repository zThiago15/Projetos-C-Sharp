using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apEscolha
{
    public partial class frmInstr : Form
    {
        public frmInstr()
        {
            InitializeComponent();
        }

        private void btnMostra_Click(object sender, EventArgs e)
        {
            if (cboInstr.SelectedIndex != 0)
            {
                MessageBox.Show((string)cboInstr.SelectedItem);
                cboInstr.SelectedIndex = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboInstr.SelectedIndex = 0;
        }
    }
}
