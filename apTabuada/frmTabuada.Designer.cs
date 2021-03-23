namespace apTabuada
{
    partial class frmTabuada
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumTabua = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMostra = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.lstTabuada = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Múltiplos";
            // 
            // txtNumTabua
            // 
            this.txtNumTabua.Location = new System.Drawing.Point(142, 39);
            this.txtNumTabua.Name = "txtNumTabua";
            this.txtNumTabua.Size = new System.Drawing.Size(100, 23);
            this.txtNumTabua.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thiago Dias Barboza";
            // 
            // btnMostra
            // 
            this.btnMostra.Location = new System.Drawing.Point(58, 277);
            this.btnMostra.Name = "btnMostra";
            this.btnMostra.Size = new System.Drawing.Size(101, 36);
            this.btnMostra.TabIndex = 5;
            this.btnMostra.Text = "Mostra";
            this.btnMostra.UseVisualStyleBackColor = true;
            this.btnMostra.Click += new System.EventHandler(this.btnMostra_Click);
            // 
            // btnLimpa
            // 
            this.btnLimpa.Location = new System.Drawing.Point(193, 277);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(103, 36);
            this.btnLimpa.TabIndex = 6;
            this.btnLimpa.Text = "Limpa";
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // lstTabuada
            // 
            this.lstTabuada.FormattingEnabled = true;
            this.lstTabuada.ItemHeight = 15;
            this.lstTabuada.Location = new System.Drawing.Point(58, 88);
            this.lstTabuada.Name = "lstTabuada";
            this.lstTabuada.Size = new System.Drawing.Size(126, 169);
            this.lstTabuada.TabIndex = 7;
            // 
            // frmTabuada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstTabuada);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btnMostra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumTabua);
            this.Controls.Add(this.label1);
            this.Name = "frmTabuada";
            this.Text = "Tabuada";
            this.Load += new System.EventHandler(this.frmTabuada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumTabua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMostra;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.ListBox lstTabuada;
    }
}

