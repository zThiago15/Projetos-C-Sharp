namespace apCalcSalLiq
{
    partial class frmCalcSalLiq
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
            this.txtIrrf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtSalBruto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInss = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSalLiq = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIrrf
            // 
            this.txtIrrf.ForeColor = System.Drawing.Color.Black;
            this.txtIrrf.Location = new System.Drawing.Point(160, 136);
            this.txtIrrf.Name = "txtIrrf";
            this.txtIrrf.Size = new System.Drawing.Size(100, 23);
            this.txtIrrf.TabIndex = 7;
            this.txtIrrf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-164, -34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ola";
            // 
            // btnCalcular
            // 
            this.btnCalcular.AllowDrop = true;
            this.btnCalcular.Location = new System.Drawing.Point(141, 242);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtSalBruto
            // 
            this.txtSalBruto.Location = new System.Drawing.Point(160, 42);
            this.txtSalBruto.Name = "txtSalBruto";
            this.txtSalBruto.Size = new System.Drawing.Size(100, 23);
            this.txtSalBruto.TabIndex = 3;
            this.txtSalBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "INSS:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtInss
            // 
            this.txtInss.Location = new System.Drawing.Point(160, 88);
            this.txtInss.Name = "txtInss";
            this.txtInss.Size = new System.Drawing.Size(100, 23);
            this.txtInss.TabIndex = 5;
            this.txtInss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "IRRF:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Salário Líquido:";
            // 
            // txtSalLiq
            // 
            this.txtSalLiq.Location = new System.Drawing.Point(160, 182);
            this.txtSalLiq.Name = "txtSalLiq";
            this.txtSalLiq.Size = new System.Drawing.Size(100, 23);
            this.txtSalLiq.TabIndex = 9;
            this.txtSalLiq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Salário Bruto(R$):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(702, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Thiago Dias";
            // 
            // frmCalcSalLiq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSalLiq);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIrrf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtInss);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSalBruto);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label1);
            this.Name = "frmCalcSalLiq";
            this.Text = "Salário Líquido";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtSalBruto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInss;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIrrf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSalLiq;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

