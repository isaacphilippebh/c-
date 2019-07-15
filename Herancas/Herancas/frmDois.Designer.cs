namespace Herancas
{
    partial class frmDois
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
            this.cmdFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdFechar
            // 
            this.cmdFechar.AccessibleDescription = "Ao clicar fecha a janela e retorna ao menu principal";
            this.cmdFechar.Location = new System.Drawing.Point(104, 377);
            this.cmdFechar.Name = "cmdFechar";
            this.cmdFechar.Size = new System.Drawing.Size(219, 61);
            this.cmdFechar.TabIndex = 0;
            this.cmdFechar.Text = "Fechar";
            this.cmdFechar.UseVisualStyleBackColor = true;
            this.cmdFechar.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmDois
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 450);
            this.Controls.Add(this.cmdFechar);
            this.Name = "frmDois";
            this.Text = "frmDois";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdFechar;
    }
}