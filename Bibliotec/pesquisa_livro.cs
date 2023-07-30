using Bibliotec.Logic;
using Bibliotec.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Bibliotec
{
    public partial class pesquisa_livro : Form
    {
        // TODO: Refatorar código

        // Eu sei que mochila não está em classe, mas tive muita dificuldade em colocar ela em uma por que estava dando muito erro
        // então eu não mudei isso, mas já sei desse erro

        public pesquisa_livro()
        {
            InitializeComponent();
        }
        private void pesquisa_livro_Load(object sender, EventArgs e)
        {
            pnlBolsa.Visible = false;   
            pnlLivro.Visible = false;
            btnCarrinho.Enabled = false;
            btnEmprestimo.Enabled = false;
        }

        string codigo_livro_celula;
        int quantidade_bolsa = 1;
        private Usuario Usuario { get; set; }
        Gerenciar_bolsa ger_bolsa = new Gerenciar_bolsa();

        private void Limpar_dados_livro()
        {
            txtLivro.Clear();
            txtISBN.Clear();
            txtAno.Clear();
            txtCategoria.Clear();
            txtAutores.Clear();
            txtSinopse.Clear();
            txtLocalizacao.Clear();
            lstExemplares.Items.Clear();
            txtDisponibilidade.Clear();
            lblCodigo.Text = "0";
            lblEditora.Text = "";

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            pnlLivro.Visible = false;
            tblLivros.Rows.Clear();
            txtPesquisa.Clear();
            lblBolsa.Text = "0";
            if (ger_bolsa.ItensBolsa != null)
            {
                ger_bolsa.LimparBolsa();
            }
            Limpar_dados_livro();
        }

        Listar_livros listar_livros = new Listar_livros();
        private void lstExemplares_SelectedValueChanged(object sender, EventArgs e)
        {
            #region Selecionar exemplares
            chkBolsa.Checked = false;
            chkBolsa.Enabled = true;
            btnCarrinho.Enabled = true;

            if (lstExemplares.SelectedIndex < 0)
                btnCarrinho.Enabled = false;

            if (lstExemplares.SelectedIndex < 0 || ger_bolsa.tamanho != 1)
                btnEmprestimo.Enabled = true;


            foreach (Exemplar exemplares in listar_livros.Listar_exemplares_disponiveis(int.Parse(codigo_livro_celula)))
            {
                if (lstExemplares.Text == exemplares.Codigo.ToString())
                {
                    txtLocalizacao.Text = exemplares.Localizacao.Nome.ToString();
                    if (exemplares.Fixo == true)
                    {
                        chkBolsa.Checked = true;
                        chkBolsa.Enabled = false;
                    }
                }
            }
            if (ger_bolsa.tamanho >= 3)
            {
                btnCarrinho.Enabled = false;
            }
            #endregion
        }
        public void AddBolsa()
        {
            Exemplar exemplarEscolhido = null;
            Tipo_emprestimo tipo = null;
            Livro livroSelecionado = null;

            if (lstExemplares.SelectedIndex != -1)
            {
                codigo_livro_celula = tblLivros.Rows[tblLivros.CurrentRow.Index].Cells[0].Value.ToString();
                Listar_livros listar_livros = new Listar_livros();
                livroSelecionado = listar_livros.Mostrar_dados_livro(codigo_livro_celula);
            }

            if (chkBolsa.Checked)
            {
                tipo = new Tipo_emprestimo(1, "Consulta");
            }
            else
            {
                tipo = new Tipo_emprestimo(2, "Empréstimo");
            }

            var exemplares = listar_livros.Listar_exemplares_disponiveis(int.Parse(codigo_livro_celula));

            for (int i = 0; i < exemplares.Count; i++)
            {
                if (lstExemplares.Text == exemplares[i].Codigo.ToString())
                {
                    exemplarEscolhido = exemplares[i];
                    break;
                }
            }

            ger_bolsa.AdicionarNaBolsa(exemplarEscolhido, livroSelecionado, tipo);
            lblBolsa.Text = quantidade_bolsa++.ToString();
        }
        private void btnCarrinho_Click(object sender, EventArgs e)
        {
            #region Bolsa
            if (Usuario != null)
            {
                for (int i = 0; i < ger_bolsa.tamanho; i++)
                {
                    if (ger_bolsa.ItensBolsa[i].Livro.Codigo.ToString().Contains(lblCodigo.Text))
                    {
                        MessageBox.Show("Exemplar desse livro já inserido no carrinho", "Bibliotec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (lstExemplares.Text == "")
                {
                    MessageBox.Show("Selecione um exemplar", "Bibliotec", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                AddBolsa();
            }
            else
            {
                if (MessageBox.Show("Usuário não cadastrado, deseja cadastrar?", "Bibliotec", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }

                Form_usuario();
                AddBolsa();
            }
            #endregion
        }
        
        private void btnAluno_Click(object sender, EventArgs e)
        {
            Form_usuario();
        }

        private void Form_usuario()
        {
            gerenciar_usuarios usuarios = new gerenciar_usuarios();
            usuarios.btn_visible = true;
            usuarios.ShowDialog();

            if (usuarios.Usuario != null)
            {
                Usuario = usuarios.Usuario;
                lblCadastro.Text = "Aluno cadastrado";
                tllblAluno.Text = Usuario.Nome;
            }
            else
            {
                if (MessageBox.Show("Usuário não cadastrado, deseja cadastrar?", "Bibliotec", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }
                Form_usuario();
            }

        }

        private void btnEmprestimo_Click(object sender, EventArgs e)
        {
            try
            {
                pnlBolsa.Visible = false;
                int tipo_emprestimo = 2;
                if (chkBolsa.Checked)
                {
                    tipo_emprestimo = 1;
                }

                #region Emprestimo
                if (Usuario == null)
                {
                    if (MessageBox.Show("Usuário não cadastrado, deseja cadastrar?", "Bibliotec", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    {
                        return;
                    }
                    Form_usuario();

                    if (ger_bolsa.tamanho != 0 || lstExemplares.SelectedIndex != -1)
                    if (Usuario.Bloqueado == false)
                        Emprestimo(tipo_emprestimo);
                    else
                    {
                        MessageBox.Show("Usuário Bloqueado!", "Bibliotec", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (lstExemplares.SelectedIndex == -1 && ger_bolsa.tamanho == null)
                    {
                        MessageBox.Show("Selecione o exemplar");
                        return;
                    }
                    if (Usuario.Bloqueado == false)
                        Emprestimo(tipo_emprestimo);
                    else
                    {
                        if (Usuario == null)
                        {
                            if (MessageBox.Show("Usuário não cadastrado, deseja cadastrar?", "Bibliotec", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                            {
                                return;
                            }
                            Form_usuario();
                        }
                        MessageBox.Show("Usuário Bloqueado!", "Bibliotec", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                #endregion
            }
            catch (Exception)
            {
                MessageBox.Show("Oops! Houve um problema ao fazer o empréstimo, tente novamente", "Bibliotec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ger_bolsa.LimparBolsa();
                lblBolsa.Text = "0";
                return;
            }

        }

        private void Emprestimo(int tipo_emprestimo)
        {
            Gerenciar_emprestimo gerenciar_Emprestimo = new Gerenciar_emprestimo();
            var emprestimo = gerenciar_Emprestimo.Emprestimos_devolucao_nula(Usuario.Login);
            if (ger_bolsa.tamanho > 0 && emprestimo.Count == 3 || ger_bolsa.tamanho > 1 && emprestimo.Count == 2 || ger_bolsa.tamanho > 2 && emprestimo.Count == 1)
            {
                MessageBox.Show("Bolsa excede o máximo de livros sem data de devolução!", "Bibliotec", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (emprestimo.Count >= 3)
            {
                MessageBox.Show("Usuário está com o máximo de livros sem data de devolução!", "Bibliotec", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ger_bolsa.tamanho != 0)
            {
                for (int i = 0; i < ger_bolsa.tamanho; i++)
                {
                    var user = Usuario.Login;
                    var cd_exemplar = int.Parse(ger_bolsa.ItensBolsa[i].Exemplar.Codigo.ToString());
                    var cd_livro = int.Parse(ger_bolsa.ItensBolsa[i].Livro.Codigo.ToString());
                    var tipo_emp = int.Parse(ger_bolsa.ItensBolsa[i].Tipo_emprestimo.Codigo.ToString());
                    Gerar_emprestimo Emprestimos_bolsa = new Gerar_emprestimo(user, cd_exemplar, cd_livro, tipo_emp);
                }
                ger_bolsa.LimparBolsa();
                quantidade_bolsa = 1;
                lblBolsa.Text = "0";
                MessageBox.Show("Empréstimo feito com sucesso", "Bibliotec", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Exemplares_Dispnobilidade();
                txtLocalizacao.Clear();
            }
            else
            {
                Gerar_emprestimo gerar_Emprestimo = new Gerar_emprestimo(Usuario.Login, int.Parse(lstExemplares.Text), int.Parse(lblCodigo.Text), tipo_emprestimo);
                MessageBox.Show("Empréstimo feito com sucesso", "Bibliotec", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Exemplares_Dispnobilidade();
                txtLocalizacao.Clear();

            }
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            try
            {
                #region Busca
                string autores_concat = "", categorias_concat = "", pesquisa = (txtPesquisa.Text).ToLower();

                tblLivros.Rows.Clear();
                pnlBolsa.Visible = false;

                if (pesquisa == null || pesquisa == "")
                {
                    MessageBox.Show("Insira dados de pesquisa", "Bibliotec", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                Listar_livros listar_livros = new Listar_livros();
                foreach (Livro lista in listar_livros.Listar(pesquisa))
                {
                    foreach (Autor autores in lista.Autor_list)
                        autores_concat += ", " + autores.Nome;

                    foreach (Categoria categorias in lista.Categoria_list)
                        categorias_concat += ", " + categorias.Nome;

                    autores_concat = autores_concat.Substring(1, autores_concat.Length - 1);
                    categorias_concat = categorias_concat.Substring(1, categorias_concat.Length - 1);
                    tblLivros.Rows.Add(lista.Codigo, lista.ISBN, lista.Titulo, autores_concat, categorias_concat);
                    categorias_concat = "";
                    autores_concat = "";
                }
                #endregion
            }
            catch (Exception)
            {
                MessageBox.Show("Oops! Houve um problema ao pesquisar, tente novamente", "Bibliotec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void verItensDaBolsaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            lstBolsa.Items.Clear();
            string quebra_linha = "";
            pnlBolsa.Visible = true;
            for (int i = 0; i < ger_bolsa.tamanho; i++)
            {
                if (ger_bolsa.ItensBolsa[i].Livro.Titulo.Length >= 15)
                    lstBolsa.Items.Add(ger_bolsa.ItensBolsa[i].Livro.Titulo.Substring(0, 15) + "... " + ger_bolsa.ItensBolsa[i].Exemplar.Codigo.ToString());
                else
                    lstBolsa.Items.Add(ger_bolsa.ItensBolsa[i].Livro.Titulo + " " + ger_bolsa.ItensBolsa[i].Exemplar.Codigo.ToString());
                    
                quebra_linha += $"{ger_bolsa.ItensBolsa[i].Livro.Titulo.ToString()}\n";
                toolTip.SetToolTip((Control)lstBolsa, quebra_linha);
            }
        }

        private void pesquisa_livro_MouseClick(object sender, MouseEventArgs e)
        {
            pnlBolsa.Visible=false;
        }

        private void btn_fechar_lista_Click(object sender, EventArgs e)
        {
            pnlBolsa.Visible=false;
        }

        private void tblLivros_SelectionChanged(object sender, EventArgs e)
        {
            Limpar_dados_livro();

            string autores_concat = "", categorias_concat = "";
            codigo_livro_celula = tblLivros.Rows[tblLivros.CurrentRow.Index].Cells[0].Value.ToString();

            Listar_livros listar_livros = new Listar_livros();
            Livro livro = listar_livros.Mostrar_dados_livro(codigo_livro_celula);

            #region Chamada de autores e livros
            foreach (Autor autores in livro.Autor_list)
                autores_concat += ", " + autores.Nome;

            foreach (Categoria categorias in livro.Categoria_list)
                categorias_concat += ", " + categorias.Nome;
            autores_concat = autores_concat.Substring(1, autores_concat.Length - 1);
            categorias_concat = categorias_concat.Substring(1, categorias_concat.Length - 1);

            #endregion

            #region Foto de Capa
            if (!String.IsNullOrEmpty(livro.Capa))
            {
                byte[] imageBytes = Convert.FromBase64String(livro.Capa);
                using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
                {
                    pcbLivro.BackgroundImage = Image.FromStream(ms, true);
                }
            }
            else
            {
                pcbLivro.BackgroundImage = null;
            }
            #endregion

            #region Inserção dos dados do livro
            txtLivro.Text = livro.Titulo;
            txtAno.Text = livro.AnoEdicao.ToString();
            txtISBN.Text = livro.ISBN;
            txtAutores.Text = autores_concat;
            txtCategoria.Text = categorias_concat;
            txtSinopse.Text = livro.Sinopse;
            lblEditora.Text = livro.Editora.Nome;
            lblCodigo.Text = livro.Codigo.ToString();
            Exemplares_Dispnobilidade();
            #endregion

            categorias_concat = "";
            autores_concat = "";
            pnlLivro.Visible = true;
        }

        private void Exemplares_Dispnobilidade()
        {
            lstExemplares.Items.Clear();
            txtDisponibilidade.Clear();
            Listar_livros listar_livros = new Listar_livros();
            foreach (Exemplar exemplares in listar_livros.Listar_exemplares_disponiveis(int.Parse(codigo_livro_celula)))
            {
                lstExemplares.Items.Add(exemplares.Codigo);
            }
            txtDisponibilidade.Text = lstExemplares.Items.Count + "/" + listar_livros.Listar_exemplares(int.Parse(codigo_livro_celula)).Count;
        }
    }
}
