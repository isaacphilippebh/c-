namespace arrays
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
            this.executar = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.ListBox();
            this.cxtxt = new System.Windows.Forms.Label();
            this.recebeValor1 = new System.Windows.Forms.TextBox();
            this.recebeValor2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // executar
            // 
            this.executar.Location = new System.Drawing.Point(697, 190);
            this.executar.Name = "executar";
            this.executar.Size = new System.Drawing.Size(75, 23);
            this.executar.TabIndex = 0;
            this.executar.Text = "Executar";
            this.executar.UseVisualStyleBackColor = true;
            this.executar.Click += new System.EventHandler(this.executar_Click);
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(12, 12);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(273, 407);
            this.lista.TabIndex = 1;
            // 
            // cxtxt
            // 
            this.cxtxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cxtxt.Location = new System.Drawing.Point(310, 12);
            this.cxtxt.Name = "cxtxt";
            this.cxtxt.Size = new System.Drawing.Size(462, 149);
            this.cxtxt.TabIndex = 2;
            this.cxtxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recebeValor1
            // 
            this.recebeValor1.Location = new System.Drawing.Point(328, 190);
            this.recebeValor1.Name = "recebeValor1";
            this.recebeValor1.Size = new System.Drawing.Size(100, 20);
            this.recebeValor1.TabIndex = 3;
            // 
            // recebeValor2
            // 
            this.recebeValor2.Location = new System.Drawing.Point(328, 216);
            this.recebeValor2.Name = "recebeValor2";
            this.recebeValor2.Size = new System.Drawing.Size(100, 20);
            this.recebeValor2.TabIndex = 4;
            this.recebeValor2.TextChanged += new System.EventHandler(this.valor2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.recebeValor2);
            this.Controls.Add(this.recebeValor1);
            this.Controls.Add(this.cxtxt);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.executar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button executar;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Label cxtxt;
        private System.Windows.Forms.TextBox recebeValor1;
        private System.Windows.Forms.TextBox recebeValor2;
    }
}

