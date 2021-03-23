namespace apPerfil
{
    partial class frmPerfil
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbFem = new System.Windows.Forms.RadioButton();
            this.rdbMasc = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbOutro = new System.Windows.Forms.RadioButton();
            this.rdbViuvo = new System.Windows.Forms.RadioButton();
            this.rdbSolteiro = new System.Windows.Forms.RadioButton();
            this.rdbCasado = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cboReligiao = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkArte = new System.Windows.Forms.CheckBox();
            this.chkBarco = new System.Windows.Forms.CheckBox();
            this.chkCarro = new System.Windows.Forms.CheckBox();
            this.chkImovel = new System.Windows.Forms.CheckBox();
            this.btnProcessa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(33, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(126, 23);
            this.txtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbFem);
            this.groupBox1.Controls.Add(this.rdbMasc);
            this.groupBox1.Location = new System.Drawing.Point(33, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // rdbFem
            // 
            this.rdbFem.AutoSize = true;
            this.rdbFem.Location = new System.Drawing.Point(7, 70);
            this.rdbFem.Name = "rdbFem";
            this.rdbFem.Size = new System.Drawing.Size(75, 19);
            this.rdbFem.TabIndex = 1;
            this.rdbFem.TabStop = true;
            this.rdbFem.Text = "Feminino";
            this.rdbFem.UseVisualStyleBackColor = true;
            // 
            // rdbMasc
            // 
            this.rdbMasc.AutoSize = true;
            this.rdbMasc.Location = new System.Drawing.Point(7, 23);
            this.rdbMasc.Name = "rdbMasc";
            this.rdbMasc.Size = new System.Drawing.Size(80, 19);
            this.rdbMasc.TabIndex = 0;
            this.rdbMasc.TabStop = true;
            this.rdbMasc.Text = "Masculino";
            this.rdbMasc.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbOutro);
            this.groupBox2.Controls.Add(this.rdbViuvo);
            this.groupBox2.Controls.Add(this.rdbSolteiro);
            this.groupBox2.Controls.Add(this.rdbCasado);
            this.groupBox2.Location = new System.Drawing.Point(221, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 138);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado Civil";
            // 
            // rdbOutro
            // 
            this.rdbOutro.AutoSize = true;
            this.rdbOutro.Location = new System.Drawing.Point(7, 100);
            this.rdbOutro.Name = "rdbOutro";
            this.rdbOutro.Size = new System.Drawing.Size(56, 19);
            this.rdbOutro.TabIndex = 3;
            this.rdbOutro.TabStop = true;
            this.rdbOutro.Text = "Outro";
            this.rdbOutro.UseVisualStyleBackColor = true;
            // 
            // rdbViuvo
            // 
            this.rdbViuvo.AutoSize = true;
            this.rdbViuvo.Location = new System.Drawing.Point(7, 75);
            this.rdbViuvo.Name = "rdbViuvo";
            this.rdbViuvo.Size = new System.Drawing.Size(55, 19);
            this.rdbViuvo.TabIndex = 2;
            this.rdbViuvo.TabStop = true;
            this.rdbViuvo.Text = "Viúvo";
            this.rdbViuvo.UseVisualStyleBackColor = true;
            // 
            // rdbSolteiro
            // 
            this.rdbSolteiro.AutoSize = true;
            this.rdbSolteiro.Location = new System.Drawing.Point(7, 49);
            this.rdbSolteiro.Name = "rdbSolteiro";
            this.rdbSolteiro.Size = new System.Drawing.Size(65, 19);
            this.rdbSolteiro.TabIndex = 1;
            this.rdbSolteiro.TabStop = true;
            this.rdbSolteiro.Text = "Solteiro";
            this.rdbSolteiro.UseVisualStyleBackColor = true;
            // 
            // rdbCasado
            // 
            this.rdbCasado.AutoSize = true;
            this.rdbCasado.Location = new System.Drawing.Point(7, 23);
            this.rdbCasado.Name = "rdbCasado";
            this.rdbCasado.Size = new System.Drawing.Size(64, 19);
            this.rdbCasado.TabIndex = 0;
            this.rdbCasado.TabStop = true;
            this.rdbCasado.Text = "Casado";
            this.rdbCasado.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(527, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Religião";
            // 
            // cboReligiao
            // 
            this.cboReligiao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReligiao.FormattingEnabled = true;
            this.cboReligiao.Items.AddRange(new object[] {
            "Católico",
            "Protestante",
            "Judeu",
            "Muçulmano",
            "Espírita",
            "Budista",
            "Ateu",
            "Agnóstico",
            "Outra"});
            this.cboReligiao.Location = new System.Drawing.Point(527, 107);
            this.cboReligiao.Name = "cboReligiao";
            this.cboReligiao.Size = new System.Drawing.Size(121, 23);
            this.cboReligiao.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkArte);
            this.groupBox3.Controls.Add(this.chkBarco);
            this.groupBox3.Controls.Add(this.chkCarro);
            this.groupBox3.Controls.Add(this.chkImovel);
            this.groupBox3.Location = new System.Drawing.Point(40, 266);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(495, 77);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bens";
            // 
            // chkArte
            // 
            this.chkArte.AutoSize = true;
            this.chkArte.Location = new System.Drawing.Point(342, 38);
            this.chkArte.Name = "chkArte";
            this.chkArte.Size = new System.Drawing.Size(91, 19);
            this.chkArte.TabIndex = 10;
            this.chkArte.Text = "Obra de arte";
            this.chkArte.UseVisualStyleBackColor = true;
            // 
            // chkBarco
            // 
            this.chkBarco.AutoSize = true;
            this.chkBarco.Location = new System.Drawing.Point(233, 38);
            this.chkBarco.Name = "chkBarco";
            this.chkBarco.Size = new System.Drawing.Size(56, 19);
            this.chkBarco.TabIndex = 9;
            this.chkBarco.Text = "Barco";
            this.chkBarco.UseVisualStyleBackColor = true;
            // 
            // chkCarro
            // 
            this.chkCarro.AutoSize = true;
            this.chkCarro.Location = new System.Drawing.Point(125, 38);
            this.chkCarro.Name = "chkCarro";
            this.chkCarro.Size = new System.Drawing.Size(55, 19);
            this.chkCarro.TabIndex = 8;
            this.chkCarro.Text = "Carro";
            this.chkCarro.UseVisualStyleBackColor = true;
            // 
            // chkImovel
            // 
            this.chkImovel.AutoSize = true;
            this.chkImovel.Location = new System.Drawing.Point(18, 38);
            this.chkImovel.Name = "chkImovel";
            this.chkImovel.Size = new System.Drawing.Size(62, 19);
            this.chkImovel.TabIndex = 7;
            this.chkImovel.Text = "Imóvel";
            this.chkImovel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkImovel.UseVisualStyleBackColor = true;
            // 
            // btnProcessa
            // 
            this.btnProcessa.Location = new System.Drawing.Point(217, 386);
            this.btnProcessa.Name = "btnProcessa";
            this.btnProcessa.Size = new System.Drawing.Size(75, 23);
            this.btnProcessa.TabIndex = 7;
            this.btnProcessa.Text = "Processa";
            this.btnProcessa.UseVisualStyleBackColor = true;
            this.btnProcessa.Click += new System.EventHandler(this.btnProcessa_Click);
            // 
            // frmPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProcessa);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cboReligiao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Name = "frmPerfil";
            this.Text = "Perfil";
            this.Load += new System.EventHandler(this.frmPerfil_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbFem;
        private System.Windows.Forms.RadioButton rdbMasc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbOutro;
        private System.Windows.Forms.RadioButton rdbViuvo;
        private System.Windows.Forms.RadioButton rdbSolteiro;
        private System.Windows.Forms.RadioButton rdbCasado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboReligiao;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkArte;
        private System.Windows.Forms.CheckBox chkBarco;
        private System.Windows.Forms.CheckBox chkCarro;
        private System.Windows.Forms.CheckBox chkImovel;
        private System.Windows.Forms.Button btnProcessa;
    }
}

