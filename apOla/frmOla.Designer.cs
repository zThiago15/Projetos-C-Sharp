namespace apOla
{
    partial class frmOla
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOla = new System.Windows.Forms.Button();
            this.lblMens = new System.Windows.Forms.Label();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.btnCopia = new System.Windows.Forms.Button();
            this.txtSaida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOla
            // 
            this.btnOla.Location = new System.Drawing.Point(66, 240);
            this.btnOla.Name = "btnOla";
            this.btnOla.Size = new System.Drawing.Size(142, 48);
            this.btnOla.TabIndex = 0;
            this.btnOla.Text = "Olá";
            this.btnOla.UseVisualStyleBackColor = true;
            this.btnOla.Click += new System.EventHandler(this.btnOla_Click);
            // 
            // lblMens
            // 
            this.lblMens.Location = new System.Drawing.Point(397, 197);
            this.lblMens.Name = "lblMens";
            this.lblMens.Size = new System.Drawing.Size(100, 23);
            this.lblMens.TabIndex = 1;
            this.lblMens.Click += new System.EventHandler(this.lblMens_Click);
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(76, 40);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(171, 23);
            this.txtEntrada.TabIndex = 2;
            this.txtEntrada.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnCopia
            // 
            this.btnCopia.Location = new System.Drawing.Point(243, 250);
            this.btnCopia.Name = "btnCopia";
            this.btnCopia.Size = new System.Drawing.Size(152, 27);
            this.btnCopia.TabIndex = 3;
            this.btnCopia.Text = "Copia";
            this.btnCopia.UseVisualStyleBackColor = true;
            this.btnCopia.Click += new System.EventHandler(this.btnCopia_Click);
            // 
            // txtSaida
            // 
            this.txtSaida.Location = new System.Drawing.Point(76, 109);
            this.txtSaida.Name = "txtSaida";
            this.txtSaida.Size = new System.Drawing.Size(171, 23);
            this.txtSaida.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Entrada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Saida";
            // 
            // btnLimpa
            // 
            this.btnLimpa.Location = new System.Drawing.Point(436, 251);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(125, 26);
            this.btnLimpa.TabIndex = 7;
            this.btnLimpa.Text = "Limpa";
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // frmOla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSaida);
            this.Controls.Add(this.btnCopia);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.lblMens);
            this.Controls.Add(this.btnOla);
            this.Name = "frmOla";
            this.Text = "Olá Mundo!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOla;
        private System.Windows.Forms.Label lblMens;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Button btnCopia;
        private System.Windows.Forms.TextBox txtSaida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpa;
    }
}

