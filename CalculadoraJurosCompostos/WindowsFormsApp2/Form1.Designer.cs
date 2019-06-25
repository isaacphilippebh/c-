namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listaFinanciamento = new System.Windows.Forms.ListBox();
            this.recebeInicial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.recebeJuros = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.recebePrazo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Label();
            this.calcular = new System.Windows.Forms.Button();
            this.Limpar = new System.Windows.Forms.Button();
            this.recebeValorPrestacao = new System.Windows.Forms.TextBox();
            this.ValorPrestacao = new System.Windows.Forms.Label();
            this.LimparCampos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaFinanciamento
            // 
            this.listaFinanciamento.FormattingEnabled = true;
            this.listaFinanciamento.Location = new System.Drawing.Point(12, 12);
            this.listaFinanciamento.Name = "listaFinanciamento";
            this.listaFinanciamento.Size = new System.Drawing.Size(232, 420);
            this.listaFinanciamento.TabIndex = 0;
            this.listaFinanciamento.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // recebeInicial
            // 
            this.recebeInicial.Location = new System.Drawing.Point(418, 12);
            this.recebeInicial.Name = "recebeInicial";
            this.recebeInicial.Size = new System.Drawing.Size(182, 20);
            this.recebeInicial.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valor Inicial";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // recebeJuros
            // 
            this.recebeJuros.Location = new System.Drawing.Point(418, 47);
            this.recebeJuros.Name = "recebeJuros";
            this.recebeJuros.Size = new System.Drawing.Size(182, 20);
            this.recebeJuros.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Taxa de juros (%)";
            // 
            // recebePrazo
            // 
            this.recebePrazo.Location = new System.Drawing.Point(418, 87);
            this.recebePrazo.Name = "recebePrazo";
            this.recebePrazo.Size = new System.Drawing.Size(182, 20);
            this.recebePrazo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prazo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Resultado";
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Location = new System.Drawing.Point(418, 176);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(0, 13);
            this.resultado.TabIndex = 8;
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(525, 227);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(75, 23);
            this.calcular.TabIndex = 9;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // Limpar
            // 
            this.Limpar.Location = new System.Drawing.Point(250, 409);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(86, 23);
            this.Limpar.TabIndex = 10;
            this.Limpar.Text = "Limpar lista";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // recebeValorPrestacao
            // 
            this.recebeValorPrestacao.Location = new System.Drawing.Point(418, 126);
            this.recebeValorPrestacao.Name = "recebeValorPrestacao";
            this.recebeValorPrestacao.Size = new System.Drawing.Size(182, 20);
            this.recebeValorPrestacao.TabIndex = 11;
            // 
            // ValorPrestacao
            // 
            this.ValorPrestacao.AutoSize = true;
            this.ValorPrestacao.Location = new System.Drawing.Point(331, 129);
            this.ValorPrestacao.Name = "ValorPrestacao";
            this.ValorPrestacao.Size = new System.Drawing.Size(81, 13);
            this.ValorPrestacao.TabIndex = 12;
            this.ValorPrestacao.Text = "Valor prestação";
            // 
            // LimparCampos
            // 
            this.LimparCampos.Location = new System.Drawing.Point(511, 409);
            this.LimparCampos.Name = "LimparCampos";
            this.LimparCampos.Size = new System.Drawing.Size(108, 23);
            this.LimparCampos.TabIndex = 13;
            this.LimparCampos.Text = "Limpar campos";
            this.LimparCampos.UseVisualStyleBackColor = true;
            this.LimparCampos.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 450);
            this.Controls.Add(this.LimparCampos);
            this.Controls.Add(this.ValorPrestacao);
            this.Controls.Add(this.recebeValorPrestacao);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.recebePrazo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.recebeJuros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recebeInicial);
            this.Controls.Add(this.listaFinanciamento);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox listaFinanciamento;
        private System.Windows.Forms.TextBox recebeInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox recebeJuros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox recebePrazo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.TextBox recebeValorPrestacao;
        private System.Windows.Forms.Label ValorPrestacao;
        private System.Windows.Forms.Button LimparCampos;
    }
}

