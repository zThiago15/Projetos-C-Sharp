namespace apEscolha
{
    partial class frmInstr
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
            this.cboInstr = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboInstr
            // 
            this.cboInstr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInstr.FormattingEnabled = true;
            this.cboInstr.Items.AddRange(new object[] {
            "Selecione...",
            "Fundamental",
            "Médio Incompleto",
            "Médio",
            "Superior Incompleto",
            "Superior",
            "Mestrado",
            "Doutorado"});
            this.cboInstr.Location = new System.Drawing.Point(307, 87);
            this.cboInstr.Name = "cboInstr";
            this.cboInstr.Size = new System.Drawing.Size(151, 23);
            this.cboInstr.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Grau de instrução";
            // 
            // btnMostra
            // 
            this.btnMostra.Location = new System.Drawing.Point(332, 206);
            this.btnMostra.Name = "btnMostra";
            this.btnMostra.Size = new System.Drawing.Size(75, 23);
            this.btnMostra.TabIndex = 3;
            this.btnMostra.Text = "Mostra";
            this.btnMostra.UseVisualStyleBackColor = true;
            this.btnMostra.Click += new System.EventHandler(this.btnMostra_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(514, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thiago Dias Barboza";
            // 
            // frmInstr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 333);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMostra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboInstr);
            this.Name = "frmInstr";
            this.Text = "Grau de instrução";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboInstr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostra;
        private System.Windows.Forms.Label label2;
    }
}

