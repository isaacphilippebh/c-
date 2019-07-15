namespace Herancas
{
    partial class frmUm
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
            this.cmd_fechar = new System.Windows.Forms.Button();
            this.frmUmApresentar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_fechar
            // 
            this.cmd_fechar.Location = new System.Drawing.Point(50, 224);
            this.cmd_fechar.Name = "cmd_fechar";
            this.cmd_fechar.Size = new System.Drawing.Size(139, 55);
            this.cmd_fechar.TabIndex = 1;
            this.cmd_fechar.Text = "Fechar";
            this.cmd_fechar.UseVisualStyleBackColor = true;
            this.cmd_fechar.Click += new System.EventHandler(this.cmd_fechar_Click);
            // 
            // frmUmApresentar
            // 
            this.frmUmApresentar.AutoSize = true;
            this.frmUmApresentar.Location = new System.Drawing.Point(37, 31);
            this.frmUmApresentar.Name = "frmUmApresentar";
            this.frmUmApresentar.Size = new System.Drawing.Size(35, 13);
            this.frmUmApresentar.TabIndex = 2;
            this.frmUmApresentar.Text = "label1";
            this.frmUmApresentar.Click += new System.EventHandler(this.frmUmApresentar_Click);
            // 
            // frmUm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 291);
            this.Controls.Add(this.frmUmApresentar);
            this.Controls.Add(this.cmd_fechar);
            this.Name = "frmUm";
            this.Text = "frmUm";
            this.Load += new System.EventHandler(this.frmUm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_fechar;
        private System.Windows.Forms.Label frmUmApresentar;
    }
}