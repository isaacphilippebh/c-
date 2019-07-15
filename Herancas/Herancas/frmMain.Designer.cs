namespace Herancas
{
    partial class frmMain
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
            this.frm1 = new System.Windows.Forms.Button();
            this.frm2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nomeUsuario = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusApp = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmbTexto = new System.Windows.Forms.ToolStripComboBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // frm1
            // 
            this.frm1.Location = new System.Drawing.Point(40, 39);
            this.frm1.Name = "frm1";
            this.frm1.Size = new System.Drawing.Size(139, 55);
            this.frm1.TabIndex = 0;
            this.frm1.Text = "Formulario 1";
            this.frm1.UseVisualStyleBackColor = true;
            this.frm1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // frm2
            // 
            this.frm2.Location = new System.Drawing.Point(217, 39);
            this.frm2.Name = "frm2";
            this.frm2.Size = new System.Drawing.Size(139, 55);
            this.frm2.TabIndex = 1;
            this.frm2.Text = "Formulario 2 ";
            this.frm2.UseVisualStyleBackColor = true;
            this.frm2.Click += new System.EventHandler(this.Frm2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // nomeUsuario
            // 
            this.nomeUsuario.Location = new System.Drawing.Point(40, 209);
            this.nomeUsuario.Name = "nomeUsuario";
            this.nomeUsuario.Size = new System.Drawing.Size(316, 20);
            this.nomeUsuario.TabIndex = 3;
            this.nomeUsuario.TextChanged += new System.EventHandler(this.nomeUsuario_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusApp});
            this.statusStrip1.Location = new System.Drawing.Point(0, 333);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(394, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.ferramentaToolStripMenuItem,
            this.cmbTexto});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(394, 27);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusApp
            // 
            this.statusApp.Name = "statusApp";
            this.statusApp.Size = new System.Drawing.Size(35, 17);
            this.statusApp.Text = "Ativo";
            this.statusApp.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.toolStripSeparator1,
            this.fecharToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(61, 23);
            this.toolStripMenuItem1.Text = "Arquivo";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ferramentaToolStripMenuItem
            // 
            this.ferramentaToolStripMenuItem.Name = "ferramentaToolStripMenuItem";
            this.ferramentaToolStripMenuItem.Size = new System.Drawing.Size(79, 23);
            this.ferramentaToolStripMenuItem.Text = "Ferramenta";
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // cmbTexto
            // 
            this.cmbTexto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.cmbTexto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTexto.Items.AddRange(new object[] {
            "Banho",
            "Cama",
            "Carro",
            "Comida",
            "Mesa"});
            this.cmbTexto.Name = "cmbTexto";
            this.cmbTexto.Size = new System.Drawing.Size(121, 23);
            this.cmbTexto.Sorted = true;
            this.cmbTexto.SelectedIndexChanged += new System.EventHandler(this.cmbTexto_SelectedIndexChanged);
            this.cmbTexto.Click += new System.EventHandler(this.cmbTexto_Click);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(40, 243);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(0, 13);
            this.labelNome.TabIndex = 6;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 355);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.nomeUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.frm2);
            this.Controls.Add(this.frm1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Programa";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button frm1;
        private System.Windows.Forms.Button frm2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomeUsuario;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusApp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ferramentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox cmbTexto;
        private System.Windows.Forms.Label labelNome;
    }
}

