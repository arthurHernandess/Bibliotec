namespace Bibliotec
{
    partial class gerenciar_emprestimos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gerenciar_emprestimos));
            this.label12 = new System.Windows.Forms.Label();
            this.tblEmprestimo = new System.Windows.Forms.DataGridView();
            this.cd_livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exemplar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_emprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Previsao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Devolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBusca = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.cmbOcorrencia = new System.Windows.Forms.ComboBox();
            this.pnlDevolucao = new System.Windows.Forms.Panel();
            this.btnDevolucao_ = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTP_emprestimo = new System.Windows.Forms.TextBox();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.btnAluno = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tllblAluno = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmprestimo)).BeginInit();
            this.pnlDevolucao.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(197, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Login / Código do Livro / Nome do livro:";
            // 
            // tblEmprestimo
            // 
            this.tblEmprestimo.AllowUserToAddRows = false;
            this.tblEmprestimo.AllowUserToDeleteRows = false;
            this.tblEmprestimo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblEmprestimo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblEmprestimo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cd_livro,
            this.Login,
            this.Nome,
            this.Exemplar,
            this.Data_emprestimo,
            this.Previsao,
            this.Devolucao,
            this.emprestimo});
            this.tblEmprestimo.Location = new System.Drawing.Point(12, 72);
            this.tblEmprestimo.Name = "tblEmprestimo";
            this.tblEmprestimo.RowHeadersVisible = false;
            this.tblEmprestimo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblEmprestimo.Size = new System.Drawing.Size(776, 150);
            this.tblEmprestimo.TabIndex = 3;
            this.tblEmprestimo.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tblEmprestimo_CellMouseClick);
            // 
            // cd_livro
            // 
            this.cd_livro.HeaderText = "Codigo";
            this.cd_livro.Name = "cd_livro";
            this.cd_livro.Visible = false;
            // 
            // Login
            // 
            this.Login.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Login.HeaderText = "Login";
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            this.Login.Width = 58;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.HeaderText = "Nome do livro";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Exemplar
            // 
            this.Exemplar.HeaderText = "Exemplar";
            this.Exemplar.Name = "Exemplar";
            // 
            // Data_emprestimo
            // 
            this.Data_emprestimo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Data_emprestimo.HeaderText = "Data de empréstimo";
            this.Data_emprestimo.Name = "Data_emprestimo";
            // 
            // Previsao
            // 
            this.Previsao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Previsao.HeaderText = "Previsão de devolução";
            this.Previsao.Name = "Previsao";
            // 
            // Devolucao
            // 
            this.Devolucao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Devolucao.HeaderText = "Devolução";
            this.Devolucao.Name = "Devolucao";
            // 
            // emprestimo
            // 
            this.emprestimo.HeaderText = "Emprestimo?";
            this.emprestimo.Name = "emprestimo";
            this.emprestimo.Visible = false;
            // 
            // btnBusca
            // 
            this.btnBusca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBusca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusca.Location = new System.Drawing.Point(359, 41);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(75, 23);
            this.btnBusca.TabIndex = 1;
            this.btnBusca.Text = "Pesquisa";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(13, 42);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(343, 20);
            this.txtPesquisa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Observação: ";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(2, 20);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(517, 108);
            this.txtObs.TabIndex = 4;
            // 
            // cmbOcorrencia
            // 
            this.cmbOcorrencia.DisplayMember = "a";
            this.cmbOcorrencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOcorrencia.FormattingEnabled = true;
            this.cmbOcorrencia.Location = new System.Drawing.Point(526, 79);
            this.cmbOcorrencia.MaxDropDownItems = 100;
            this.cmbOcorrencia.Name = "cmbOcorrencia";
            this.cmbOcorrencia.Size = new System.Drawing.Size(247, 21);
            this.cmbOcorrencia.TabIndex = 6;
            this.cmbOcorrencia.SelectedIndexChanged += new System.EventHandler(this.cmbOcorrencia_SelectedIndexChanged);
            // 
            // pnlDevolucao
            // 
            this.pnlDevolucao.Controls.Add(this.btnDevolucao_);
            this.pnlDevolucao.Controls.Add(this.label3);
            this.pnlDevolucao.Controls.Add(this.label2);
            this.pnlDevolucao.Controls.Add(this.txtTP_emprestimo);
            this.pnlDevolucao.Controls.Add(this.txtObs);
            this.pnlDevolucao.Controls.Add(this.cmbOcorrencia);
            this.pnlDevolucao.Controls.Add(this.label1);
            this.pnlDevolucao.Location = new System.Drawing.Point(12, 228);
            this.pnlDevolucao.Name = "pnlDevolucao";
            this.pnlDevolucao.Size = new System.Drawing.Size(776, 131);
            this.pnlDevolucao.TabIndex = 40;
            // 
            // btnDevolucao_
            // 
            this.btnDevolucao_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDevolucao_.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevolucao_.Location = new System.Drawing.Point(651, 106);
            this.btnDevolucao_.Name = "btnDevolucao_";
            this.btnDevolucao_.Size = new System.Drawing.Size(122, 23);
            this.btnDevolucao_.TabIndex = 7;
            this.btnDevolucao_.Text = "Registrar devolução";
            this.btnDevolucao_.UseVisualStyleBackColor = true;
            this.btnDevolucao_.Click += new System.EventHandler(this.btnDevolucao__Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(523, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "Tipo da ocorrência: ";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(522, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Tipo do empréstimo: ";
            // 
            // txtTP_emprestimo
            // 
            this.txtTP_emprestimo.Enabled = false;
            this.txtTP_emprestimo.Location = new System.Drawing.Point(525, 38);
            this.txtTP_emprestimo.Name = "txtTP_emprestimo";
            this.txtTP_emprestimo.ReadOnly = true;
            this.txtTP_emprestimo.Size = new System.Drawing.Size(246, 20);
            this.txtTP_emprestimo.TabIndex = 5;
            // 
            // lblCadastro
            // 
            this.lblCadastro.Location = new System.Drawing.Point(624, 45);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(124, 13);
            this.lblCadastro.TabIndex = 42;
            this.lblCadastro.Text = "Aluno não cadastrado";
            this.lblCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAluno
            // 
            this.btnAluno.BackgroundImage = global::Bibliotec.Properties.Resources.icons8_user_skin_type_7_48;
            this.btnAluno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAluno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAluno.Location = new System.Drawing.Point(754, 36);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(34, 31);
            this.btnAluno.TabIndex = 41;
            this.btnAluno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAluno.UseVisualStyleBackColor = true;
            this.btnAluno.Click += new System.EventHandler(this.btnAluno_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tllblAluno,
            this.tssUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 381);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 43;
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
            // tssUsuario
            // 
            this.tssUsuario.Name = "tssUsuario";
            this.tssUsuario.Size = new System.Drawing.Size(0, 17);
            // 
            // gerenciar_emprestimos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 403);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblCadastro);
            this.Controls.Add(this.btnAluno);
            this.Controls.Add(this.pnlDevolucao);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tblEmprestimo);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.txtPesquisa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "gerenciar_emprestimos";
            this.Text = "Empréstimos";
            this.Load += new System.EventHandler(this.gerenciar_emprestimos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblEmprestimo)).EndInit();
            this.pnlDevolucao.ResumeLayout(false);
            this.pnlDevolucao.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView tblEmprestimo;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.ComboBox cmbOcorrencia;
        private System.Windows.Forms.Panel pnlDevolucao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTP_emprestimo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDevolucao_;
        private System.Windows.Forms.DataGridViewTextBoxColumn cd_livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exemplar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_emprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Previsao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Devolucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn emprestimo;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Button btnAluno;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tllblAluno;
        private System.Windows.Forms.ToolStripStatusLabel tssUsuario;
    }
}