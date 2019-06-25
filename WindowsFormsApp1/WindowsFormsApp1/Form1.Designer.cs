namespace WindowsFormsApp1
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
            this.textNu1 = new System.Windows.Forms.TextBox();
            this.textNu2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.textResultado = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.btnDivideZero = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textNu1
            // 
            this.textNu1.Location = new System.Drawing.Point(86, 74);
            this.textNu1.Name = "textNu1";
            this.textNu1.Size = new System.Drawing.Size(156, 20);
            this.textNu1.TabIndex = 0;
            // 
            // textNu2
            // 
            this.textNu2.Location = new System.Drawing.Point(86, 100);
            this.textNu2.Name = "textNu2";
            this.textNu2.Size = new System.Drawing.Size(156, 20);
            this.textNu2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número 2";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(86, 131);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 4;
            this.btn_calcular.Text = "Multiplicar";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // textResultado
            // 
            this.textResultado.AutoSize = true;
            this.textResultado.Location = new System.Drawing.Point(12, 207);
            this.textResultado.Name = "textResultado";
            this.textResultado.Size = new System.Drawing.Size(0, 13);
            this.textResultado.TabIndex = 5;
            // 
            // btnDivideZero
            // 
            this.btnDivideZero.Location = new System.Drawing.Point(167, 131);
            this.btnDivideZero.Name = "btnDivideZero";
            this.btnDivideZero.Size = new System.Drawing.Size(75, 23);
            this.btnDivideZero.TabIndex = 6;
            this.btnDivideZero.Text = "É divisível";
            this.btnDivideZero.UseVisualStyleBackColor = true;
            this.btnDivideZero.Click += new System.EventHandler(this.btnDivideZero_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Resultado:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textTotal
            // 
            this.textTotal.AutoSize = true;
            this.textTotal.Location = new System.Drawing.Point(77, 168);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(0, 13);
            this.textTotal.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 318);
            this.Controls.Add(this.textTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDivideZero);
            this.Controls.Add(this.textResultado);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNu2);
            this.Controls.Add(this.textNu1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNu1;
        private System.Windows.Forms.TextBox textNu2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label textResultado;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button btnDivideZero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label textTotal;
    }
}

