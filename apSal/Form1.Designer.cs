namespace apSal
{
    partial class frmSal
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
            this.txtSalA = new System.Windows.Forms.TextBox();
            this.txtPorcento = new System.Windows.Forms.TextBox();
            this.txtSalC = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSalA
            // 
            this.txtSalA.Location = new System.Drawing.Point(305, 41);
            this.txtSalA.Name = "txtSalA";
            this.txtSalA.Size = new System.Drawing.Size(100, 23);
            this.txtSalA.TabIndex = 0;
            this.txtSalA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSalA.TextChanged += new System.EventHandler(this.txtSalA_TextChanged);
            // 
            // txtPorcento
            // 
            this.txtPorcento.Location = new System.Drawing.Point(305, 89);
            this.txtPorcento.Name = "txtPorcento";
            this.txtPorcento.Size = new System.Drawing.Size(35, 23);
            this.txtPorcento.TabIndex = 1;
            this.txtPorcento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPorcento.TextChanged += new System.EventHandler(this.txtPorcento_TextChanged);
            // 
            // txtSalC
            // 
            this.txtSalC.Enabled = false;
            this.txtSalC.Location = new System.Drawing.Point(305, 131);
            this.txtSalC.Name = "txtSalC";
            this.txtSalC.Size = new System.Drawing.Size(100, 23);
            this.txtSalC.TabIndex = 2;
            this.txtSalC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(265, 183);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sálario Atual:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Porcentagem:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Salário Corrigido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "%";
            // 
            // frmSal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtSalC);
            this.Controls.Add(this.txtPorcento);
            this.Controls.Add(this.txtSalA);
            this.Name = "frmSal";
            this.Text = "Aumento de Salário";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmSal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSalA;
        private System.Windows.Forms.TextBox txtPorcento;
        private System.Windows.Forms.TextBox txtSalC;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

