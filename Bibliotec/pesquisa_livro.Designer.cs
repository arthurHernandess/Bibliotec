namespace Bibliotec
{
    partial class pesquisa_livro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pesquisa_livro));
            this.cMSPadrao = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ttPadrao = new System.Windows.Forms.ToolTip(this.components);
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnBusca = new System.Windows.Forms.Button();
            this.btnCarrinho = new System.Windows.Forms.Button();
            this.cMSBolsa = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verItensDaBolsaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAluno = new System.Windows.Forms.Button();
            this.lblTeste = new System.Windows.Forms.Label();
            this.pnlLivro = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txtLocalizacao = new System.Windows.Forms.TextBox();
            this.btnEmprestimo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDisponibilidade = new System.Windows.Forms.TextBox();
            this.lstExemplares = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSinopse = new System.Windows.Forms.TextBox();
            this.lblEditora = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAutores = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtLivro = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.pcbLivro = new System.Windows.Forms.PictureBox();
            this.tblLivros = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblBolsa = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tllblAluno = new System.Windows.Forms.ToolStripStatusLabel();
            this.chkBolsa = new System.Windows.Forms.CheckBox();
            this.pnlBolsa = new System.Windows.Forms.Panel();
            this.btn_fechar_lista = new System.Windows.Forms.Button();
            this.lstBolsa = new System.Windows.Forms.ListBox();
            this.cMSPadrao.SuspendLayout();
            this.cMSBolsa.SuspendLayout();
            this.pnlLivro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLivro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLivros)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.pnlBolsa.SuspendLayout();
            this.SuspendLayout();
            // 
            // cMSPadrao
            // 
            this.cMSPadrao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.cMSPadrao.Name = "cMSPadrao";
            this.cMSPadrao.Size = new System.Drawing.Size(94, 26);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(12, 49);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(480, 20);
            this.txtPesquisa.TabIndex = 1;
            this.ttPadrao.SetToolTip(this.txtPesquisa, "Pesquise por Código, Nome ou ISBN");
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(579, 49);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.ttPadrao.SetToolTip(this.btnLimpar, "Limpar");
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnBusca
            // 
            this.btnBusca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBusca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusca.Location = new System.Drawing.Point(498, 49);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(75, 23);
            this.btnBusca.TabIndex = 2;
            this.btnBusca.Text = "Pesquisa";
            this.ttPadrao.SetToolTip(this.btnBusca, "Pesquisa");
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // btnCarrinho
            // 
            this.btnCarrinho.BackgroundImage = global::Bibliotec.Properties.Resources.icons8_rucksack_48;
            this.btnCarrinho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCarrinho.ContextMenuStrip = this.cMSBolsa;
            this.btnCarrinho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarrinho.Location = new System.Drawing.Point(914, 45);
            this.btnCarrinho.Name = "btnCarrinho";
            this.btnCarrinho.Size = new System.Drawing.Size(34, 31);
            this.btnCarrinho.TabIndex = 6;
            this.btnCarrinho.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ttPadrao.SetToolTip(this.btnCarrinho, "Pesquisa");
            this.btnCarrinho.UseVisualStyleBackColor = true;
            this.btnCarrinho.Click += new System.EventHandler(this.btnCarrinho_Click);
            // 
            // cMSBolsa
            // 
            this.cMSBolsa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verItensDaBolsaToolStripMenuItem});
            this.cMSBolsa.Name = "cMSBolsa";
            this.cMSBolsa.Size = new System.Drawing.Size(166, 26);
            // 
            // verItensDaBolsaToolStripMenuItem
            // 
            this.verItensDaBolsaToolStripMenuItem.Name = "verItensDaBolsaToolStripMenuItem";
            this.verItensDaBolsaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.verItensDaBolsaToolStripMenuItem.Text = "Ver Itens da bolsa";
            this.verItensDaBolsaToolStripMenuItem.Click += new System.EventHandler(this.verItensDaBolsaToolStripMenuItem_Click);
            // 
            // btnAluno
            // 
            this.btnAluno.BackgroundImage = global::Bibliotec.Properties.Resources.icons8_user_skin_type_7_48;
            this.btnAluno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAluno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAluno.Location = new System.Drawing.Point(874, 45);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(34, 31);
            this.btnAluno.TabIndex = 5;
            this.btnAluno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ttPadrao.SetToolTip(this.btnAluno, "Pesquisa");
            this.btnAluno.UseVisualStyleBackColor = true;
            this.btnAluno.Click += new System.EventHandler(this.btnAluno_Click);
            // 
            // lblTeste
            // 
            this.lblTeste.AutoSize = true;
            this.lblTeste.Location = new System.Drawing.Point(42, 110);
            this.lblTeste.Name = "lblTeste";
            this.lblTeste.Size = new System.Drawing.Size(0, 13);
            this.lblTeste.TabIndex = 1;
            // 
            // pnlLivro
            // 
            this.pnlLivro.Controls.Add(this.label13);
            this.pnlLivro.Controls.Add(this.txtLocalizacao);
            this.pnlLivro.Controls.Add(this.btnEmprestimo);
            this.pnlLivro.Controls.Add(this.label7);
            this.pnlLivro.Controls.Add(this.txtDisponibilidade);
            this.pnlLivro.Controls.Add(this.lstExemplares);
            this.pnlLivro.Controls.Add(this.label4);
            this.pnlLivro.Controls.Add(this.label10);
            this.pnlLivro.Controls.Add(this.txtSinopse);
            this.pnlLivro.Controls.Add(this.lblEditora);
            this.pnlLivro.Controls.Add(this.label8);
            this.pnlLivro.Controls.Add(this.lblCodigo);
            this.pnlLivro.Controls.Add(this.label6);
            this.pnlLivro.Controls.Add(this.label5);
            this.pnlLivro.Controls.Add(this.lblAno);
            this.pnlLivro.Controls.Add(this.label3);
            this.pnlLivro.Controls.Add(this.label2);
            this.pnlLivro.Controls.Add(this.label1);
            this.pnlLivro.Controls.Add(this.txtAutores);
            this.pnlLivro.Controls.Add(this.txtCategoria);
            this.pnlLivro.Controls.Add(this.txtAno);
            this.pnlLivro.Controls.Add(this.txtLivro);
            this.pnlLivro.Controls.Add(this.txtISBN);
            this.pnlLivro.Controls.Add(this.pcbLivro);
            this.pnlLivro.Location = new System.Drawing.Point(12, 260);
            this.pnlLivro.Name = "pnlLivro";
            this.pnlLivro.Size = new System.Drawing.Size(965, 353);
            this.pnlLivro.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(169, 274);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Localização:";
            // 
            // txtLocalizacao
            // 
            this.txtLocalizacao.Enabled = false;
            this.txtLocalizacao.Location = new System.Drawing.Point(169, 291);
            this.txtLocalizacao.Name = "txtLocalizacao";
            this.txtLocalizacao.Size = new System.Drawing.Size(642, 20);
            this.txtLocalizacao.TabIndex = 28;
            // 
            // btnEmprestimo
            // 
            this.btnEmprestimo.Location = new System.Drawing.Point(817, 288);
            this.btnEmprestimo.Name = "btnEmprestimo";
            this.btnEmprestimo.Size = new System.Drawing.Size(145, 23);
            this.btnEmprestimo.TabIndex = 9;
            this.btnEmprestimo.Text = "Emprestimo";
            this.btnEmprestimo.UseVisualStyleBackColor = true;
            this.btnEmprestimo.Click += new System.EventHandler(this.btnEmprestimo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(645, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Disponibilidade:";
            // 
            // txtDisponibilidade
            // 
            this.txtDisponibilidade.Enabled = false;
            this.txtDisponibilidade.Location = new System.Drawing.Point(648, 59);
            this.txtDisponibilidade.Name = "txtDisponibilidade";
            this.txtDisponibilidade.Size = new System.Drawing.Size(163, 20);
            this.txtDisponibilidade.TabIndex = 24;
            // 
            // lstExemplares
            // 
            this.lstExemplares.FormattingEnabled = true;
            this.lstExemplares.Location = new System.Drawing.Point(817, 18);
            this.lstExemplares.Name = "lstExemplares";
            this.lstExemplares.Size = new System.Drawing.Size(145, 251);
            this.lstExemplares.TabIndex = 8;
            this.lstExemplares.SelectedValueChanged += new System.EventHandler(this.lstExemplares_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(814, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Exemplares:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(169, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Sinopse:";
            // 
            // txtSinopse
            // 
            this.txtSinopse.Enabled = false;
            this.txtSinopse.Location = new System.Drawing.Point(169, 186);
            this.txtSinopse.Multiline = true;
            this.txtSinopse.Name = "txtSinopse";
            this.txtSinopse.Size = new System.Drawing.Size(642, 83);
            this.txtSinopse.TabIndex = 20;
            // 
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.Location = new System.Drawing.Point(46, 256);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(0, 13);
            this.lblEditora.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-3, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Editora:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(46, 237);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(0, 13);
            this.lblCodigo.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(169, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Autor(es):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Categoria(s):";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(508, 42);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(79, 13);
            this.lblAno.TabIndex = 14;
            this.lblAno.Text = "Ano de edição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "ISBN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Titulo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Código:";
            // 
            // txtAutores
            // 
            this.txtAutores.Enabled = false;
            this.txtAutores.Location = new System.Drawing.Point(169, 142);
            this.txtAutores.Name = "txtAutores";
            this.txtAutores.Size = new System.Drawing.Size(642, 20);
            this.txtAutores.TabIndex = 10;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Enabled = false;
            this.txtCategoria.Location = new System.Drawing.Point(169, 99);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(642, 20);
            this.txtCategoria.TabIndex = 9;
            // 
            // txtAno
            // 
            this.txtAno.Enabled = false;
            this.txtAno.Location = new System.Drawing.Point(511, 59);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(131, 20);
            this.txtAno.TabIndex = 8;
            // 
            // txtLivro
            // 
            this.txtLivro.Enabled = false;
            this.txtLivro.Location = new System.Drawing.Point(169, 19);
            this.txtLivro.Name = "txtLivro";
            this.txtLivro.Size = new System.Drawing.Size(642, 20);
            this.txtLivro.TabIndex = 8;
            // 
            // txtISBN
            // 
            this.txtISBN.Enabled = false;
            this.txtISBN.Location = new System.Drawing.Point(169, 59);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(336, 20);
            this.txtISBN.TabIndex = 6;
            // 
            // pcbLivro
            // 
            this.pcbLivro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbLivro.ErrorImage = null;
            this.pcbLivro.Location = new System.Drawing.Point(-1, 0);
            this.pcbLivro.Name = "pcbLivro";
            this.pcbLivro.Size = new System.Drawing.Size(160, 230);
            this.pcbLivro.TabIndex = 5;
            this.pcbLivro.TabStop = false;
            // 
            // tblLivros
            // 
            this.tblLivros.AllowUserToAddRows = false;
            this.tblLivros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.ISBN,
            this.Titulo,
            this.Autor,
            this.Categoria});
            this.tblLivros.Location = new System.Drawing.Point(11, 92);
            this.tblLivros.Name = "tblLivros";
            this.tblLivros.ReadOnly = true;
            this.tblLivros.RowHeadersVisible = false;
            this.tblLivros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblLivros.Size = new System.Drawing.Size(966, 150);
            this.tblLivros.TabIndex = 7;
            this.tblLivros.SelectionChanged += new System.EventHandler(this.tblLivros_SelectionChanged);
            // 
            // Código
            // 
            this.Código.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            this.Código.Width = 65;
            // 
            // ISBN
            // 
            this.ISBN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            this.ISBN.Width = 57;
            // 
            // Titulo
            // 
            this.Titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // Autor
            // 
            this.Autor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            this.Autor.Width = 57;
            // 
            // Categoria
            // 
            this.Categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 77;
            // 
            // lblCadastro
            // 
            this.lblCadastro.Location = new System.Drawing.Point(744, 54);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(124, 13);
            this.lblCadastro.TabIndex = 26;
            this.lblCadastro.Text = "Aluno não cadastrado";
            this.lblCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Código / ISBN / Titulo:";
            // 
            // lblBolsa
            // 
            this.lblBolsa.AutoSize = true;
            this.lblBolsa.Location = new System.Drawing.Point(960, 54);
            this.lblBolsa.Name = "lblBolsa";
            this.lblBolsa.Size = new System.Drawing.Size(13, 13);
            this.lblBolsa.TabIndex = 27;
            this.lblBolsa.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(950, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "x";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tllblAluno});
            this.statusStrip1.Location = new System.Drawing.Point(0, 609);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(989, 22);
            this.statusStrip1.TabIndex = 32;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(103, 17);
            this.toolStripStatusLabel1.Text = "Aluno cadastrado:";
            // 
            // tllblAluno
            // 
            this.tllblAluno.Name = "tllblAluno";
            this.tllblAluno.Size = new System.Drawing.Size(0, 17);
            // 
            // chkBolsa
            // 
            this.chkBolsa.AutoSize = true;
            this.chkBolsa.Location = new System.Drawing.Point(671, 53);
            this.chkBolsa.Name = "chkBolsa";
            this.chkBolsa.Size = new System.Drawing.Size(67, 17);
            this.chkBolsa.TabIndex = 4;
            this.chkBolsa.Text = "Consulta";
            this.chkBolsa.UseVisualStyleBackColor = true;
            // 
            // pnlBolsa
            // 
            this.pnlBolsa.BackColor = System.Drawing.Color.Transparent;
            this.pnlBolsa.Controls.Add(this.btn_fechar_lista);
            this.pnlBolsa.Controls.Add(this.lstBolsa);
            this.pnlBolsa.Location = new System.Drawing.Point(842, 75);
            this.pnlBolsa.Name = "pnlBolsa";
            this.pnlBolsa.Size = new System.Drawing.Size(106, 136);
            this.pnlBolsa.TabIndex = 34;
            // 
            // btn_fechar_lista
            // 
            this.btn_fechar_lista.Location = new System.Drawing.Point(0, 111);
            this.btn_fechar_lista.Name = "btn_fechar_lista";
            this.btn_fechar_lista.Size = new System.Drawing.Size(106, 24);
            this.btn_fechar_lista.TabIndex = 1;
            this.btn_fechar_lista.Text = "Fechar Lista";
            this.btn_fechar_lista.UseVisualStyleBackColor = true;
            this.btn_fechar_lista.Click += new System.EventHandler(this.btn_fechar_lista_Click);
            // 
            // lstBolsa
            // 
            this.lstBolsa.FormattingEnabled = true;
            this.lstBolsa.Items.AddRange(new object[] {
            ""});
            this.lstBolsa.Location = new System.Drawing.Point(0, 2);
            this.lstBolsa.MultiColumn = true;
            this.lstBolsa.Name = "lstBolsa";
            this.lstBolsa.Size = new System.Drawing.Size(106, 108);
            this.lstBolsa.TabIndex = 0;
            // 
            // pesquisa_livro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 631);
            this.ContextMenuStrip = this.cMSPadrao;
            this.Controls.Add(this.pnlBolsa);
            this.Controls.Add(this.chkBolsa);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblBolsa);
            this.Controls.Add(this.lblCadastro);
            this.Controls.Add(this.btnCarrinho);
            this.Controls.Add(this.btnAluno);
            this.Controls.Add(this.pnlLivro);
            this.Controls.Add(this.tblLivros);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.lblTeste);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "pesquisa_livro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca";
            this.Load += new System.EventHandler(this.pesquisa_livro_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pesquisa_livro_MouseClick);
            this.cMSPadrao.ResumeLayout(false);
            this.cMSBolsa.ResumeLayout(false);
            this.pnlLivro.ResumeLayout(false);
            this.pnlLivro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLivro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLivros)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlBolsa.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cMSPadrao;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolTip ttPadrao;
        private System.Windows.Forms.Label lblTeste;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.PictureBox pcbLivro;
        private System.Windows.Forms.Panel pnlLivro;
        private System.Windows.Forms.DataGridView tblLivros;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSinopse;
        private System.Windows.Forms.Label lblEditora;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAutores;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtLivro;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.ListBox lstExemplares;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDisponibilidade;
        private System.Windows.Forms.Button btnAluno;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnEmprestimo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtLocalizacao;
        private System.Windows.Forms.Label lblBolsa;
        private System.Windows.Forms.Button btnCarrinho;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tllblAluno;
        private System.Windows.Forms.CheckBox chkBolsa;
        private System.Windows.Forms.ContextMenuStrip cMSBolsa;
        private System.Windows.Forms.ToolStripMenuItem verItensDaBolsaToolStripMenuItem;
        private System.Windows.Forms.Panel pnlBolsa;
        private System.Windows.Forms.Button btn_fechar_lista;
        private System.Windows.Forms.ListBox lstBolsa;
    }
}

