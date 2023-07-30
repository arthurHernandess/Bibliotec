namespace Bibliotec
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarLivroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adcionarLivroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnAcervo = new System.Windows.Forms.ToolStripButton();
            this.tsbtnUsuarios = new System.Windows.Forms.ToolStripButton();
            this.tsbtnEmprestimo = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tssUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 551);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(993, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(87, 17);
            this.toolStripStatusLabel1.Text = "Cliente logado:";
            // 
            // tssUsuario
            // 
            this.tssUsuario.Name = "tssUsuario";
            this.tssUsuario.Size = new System.Drawing.Size(36, 17);
            this.tssUsuario.Text = "NULL";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(993, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.livroToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // livroToolStripMenuItem
            // 
            this.livroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarLivroToolStripMenuItem,
            this.adcionarLivroToolStripMenuItem});
            this.livroToolStripMenuItem.Name = "livroToolStripMenuItem";
            this.livroToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.livroToolStripMenuItem.Text = "Livro";
            // 
            // buscarLivroToolStripMenuItem
            // 
            this.buscarLivroToolStripMenuItem.Name = "buscarLivroToolStripMenuItem";
            this.buscarLivroToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.buscarLivroToolStripMenuItem.Text = "Buscar Livro";
            this.buscarLivroToolStripMenuItem.Click += new System.EventHandler(this.buscarLivroToolStripMenuItem_Click);
            // 
            // adcionarLivroToolStripMenuItem
            // 
            this.adcionarLivroToolStripMenuItem.Name = "adcionarLivroToolStripMenuItem";
            this.adcionarLivroToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.adcionarLivroToolStripMenuItem.Text = "Adcionar Livro";
            this.adcionarLivroToolStripMenuItem.Click += new System.EventHandler(this.adcionarLivroToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAcervo,
            this.tsbtnUsuarios,
            this.tsbtnEmprestimo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(993, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnAcervo
            // 
            this.tsbtnAcervo.Image = global::Bibliotec.Properties.Resources.book;
            this.tsbtnAcervo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAcervo.Name = "tsbtnAcervo";
            this.tsbtnAcervo.Size = new System.Drawing.Size(64, 22);
            this.tsbtnAcervo.Text = "Acervo";
            this.tsbtnAcervo.Click += new System.EventHandler(this.tsbtnAcervo_Click);
            // 
            // tsbtnUsuarios
            // 
            this.tsbtnUsuarios.Image = global::Bibliotec.Properties.Resources.account;
            this.tsbtnUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnUsuarios.Name = "tsbtnUsuarios";
            this.tsbtnUsuarios.Size = new System.Drawing.Size(72, 22);
            this.tsbtnUsuarios.Text = "Usuários";
            this.tsbtnUsuarios.Click += new System.EventHandler(this.tsbtnUsuarios_Click);
            // 
            // tsbtnEmprestimo
            // 
            this.tsbtnEmprestimo.Image = global::Bibliotec.Properties.Resources.handshake_FILL0_wght400_GRAD0_opsz48;
            this.tsbtnEmprestimo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEmprestimo.Name = "tsbtnEmprestimo";
            this.tsbtnEmprestimo.Size = new System.Drawing.Size(96, 22);
            this.tsbtnEmprestimo.Text = "Empréstimos";
            this.tsbtnEmprestimo.Click += new System.EventHandler(this.tsbtnEmprestimo_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(993, 573);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
            this.Load += new System.EventHandler(this.main_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarLivroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adcionarLivroToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnAcervo;
        private System.Windows.Forms.ToolStripButton tsbtnUsuarios;
        private System.Windows.Forms.ToolStripButton tsbtnEmprestimo;
        private System.Windows.Forms.ToolStripStatusLabel tssUsuario;
    }
}