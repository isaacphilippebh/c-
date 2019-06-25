namespace PrimeiraAplicacao
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
            this.btn_executar = new System.Windows.Forms.Button();
            this.caixa_texto = new System.Windows.Forms.Label();
            this.Close_app = new System.Windows.Forms.Button();
            this.add_100 = new System.Windows.Forms.Button();
            this.add_1000 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_executar
            // 
            this.btn_executar.Location = new System.Drawing.Point(671, 491);
            this.btn_executar.Name = "btn_executar";
            this.btn_executar.Size = new System.Drawing.Size(110, 41);
            this.btn_executar.TabIndex = 0;
            this.btn_executar.Text = "Executar";
            this.btn_executar.UseVisualStyleBackColor = true;
            this.btn_executar.Click += new System.EventHandler(this.btn_executar_Click);
            // 
            // caixa_texto
            // 
            this.caixa_texto.AutoSize = true;
            this.caixa_texto.Location = new System.Drawing.Point(183, 109);
            this.caixa_texto.Name = "caixa_texto";
            this.caixa_texto.Size = new System.Drawing.Size(91, 13);
            this.caixa_texto.TabIndex = 1;
            this.caixa_texto.Text = "Texto de exemplo";
            this.caixa_texto.Click += new System.EventHandler(this.label1_Click);
            // 
            // Close_app
            // 
            this.Close_app.Cursor = System.Windows.Forms.Cursors.Default;
            this.Close_app.Location = new System.Drawing.Point(12, 509);
            this.Close_app.Name = "Close_app";
            this.Close_app.Size = new System.Drawing.Size(75, 23);
            this.Close_app.TabIndex = 2;
            this.Close_app.Text = "Fechar";
            this.Close_app.UseVisualStyleBackColor = true;
            this.Close_app.Click += new System.EventHandler(this.Close_app_Click);
            // 
            // add_100
            // 
            this.add_100.Location = new System.Drawing.Point(671, 98);
            this.add_100.Name = "add_100";
            this.add_100.Size = new System.Drawing.Size(118, 23);
            this.add_100.TabIndex = 3;
            this.add_100.Text = "Adicionar 100 reais";
            this.add_100.UseVisualStyleBackColor = true;
            this.add_100.Click += new System.EventHandler(this.add_100_Click);
            // 
            // add_1000
            // 
            this.add_1000.Location = new System.Drawing.Point(671, 138);
            this.add_1000.Name = "add_1000";
            this.add_1000.Size = new System.Drawing.Size(118, 23);
            this.add_1000.TabIndex = 4;
            this.add_1000.Text = "Adicionar 1000 reais";
            this.add_1000.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(817, 555);
            this.Controls.Add(this.add_1000);
            this.Controls.Add(this.add_100);
            this.Controls.Add(this.Close_app);
            this.Controls.Add(this.caixa_texto);
            this.Controls.Add(this.btn_executar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_executar;
        private System.Windows.Forms.Label caixa_texto;
        private System.Windows.Forms.Button Close_app;
        private System.Windows.Forms.Button add_100;
        private System.Windows.Forms.Button add_1000;
    }
}

