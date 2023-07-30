using Bibliotec.Logic;
using Bibliotec.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliotec
{
    public partial class gerenciar_emprestimos : Form
    {
        public gerenciar_emprestimos()
        {
            InitializeComponent();
        }

        public Usuario Usuario { get; set; }

        string data_devolucao = "";
        private void btnBusca_Click(object sender, EventArgs e)
        {
            #region Busca
            try
            {
                string pesquisa = txtPesquisa.Text;
                Gerenciar_emprestimo emprestimo = new Gerenciar_emprestimo();
                tblEmprestimo.Rows.Clear();

                if (pesquisa == null || pesquisa == "")
                {
                    MessageBox.Show("Insira dados de pesquisa", "Bibliotec", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                foreach (Emprestimo emprestimo1 in emprestimo.Listar_Emprestimo(txtPesquisa.Text))
                {
                    var timestamp = emprestimo1.Data_emprestimo.ToString("yyyy/MM/d") + ":" + emprestimo1.Hora_emprestimo;
                    tblEmprestimo.Rows.Add(
                        emprestimo1.Livro.Codigo,
                        emprestimo1.Usuario.Login,
                        emprestimo1.Livro.Titulo,
                        emprestimo1.Exemplar.Codigo,
                        timestamp,
                        emprestimo1.Devolucao_estimada.ToString("yyyy/MM/d"),
                        emprestimo1.Devolucao?.ToString("yyyy/MM/d") ?? "Não devolvido",
                        emprestimo1
                     );
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Oops! Houve um problema ao pesquisar, tente novamente", "Bibliotec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

        }

        private void gerenciar_emprestimos_Load(object sender, EventArgs e)
        {
            pnlDevolucao.Visible = false;
            cmbOcorrencia.Items.Add("Nenhum");
            cmbOcorrencia.SelectedIndex = 0;
            Gerenciar_ocorrencia gerenciar_ocorrencia = new Gerenciar_ocorrencia();
            cmbOcorrencia.DisplayMember = "Key";
            cmbOcorrencia.ValueMember = "Value";

            foreach (Tipo_ocorrencia Tipo in gerenciar_ocorrencia.tipo_ocorrencia())
            {
                cmbOcorrencia.Items.Add(new KeyValuePair<string, int>(Tipo.Nome, Tipo.Codigo));
            }

        }

        private void tblEmprestimo_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            #region Click Empréstimo
            txtObs.Enabled = false;
            cmbOcorrencia.SelectedIndex = 0;
            cmbOcorrencia.Enabled = true;
            btnDevolucao_.Enabled = true;
            pnlDevolucao.Visible = true;
            txtObs.Clear();
            Gerenciar_emprestimo emprestimo = new Gerenciar_emprestimo();
            Emprestimo Dados_emprestimo = emprestimo.Emprestimo(
                tblEmprestimo.Rows[tblEmprestimo.CurrentRow.Index].Cells[0].Value.ToString(),
                tblEmprestimo.Rows[tblEmprestimo.CurrentRow.Index].Cells[1].Value.ToString(),
                tblEmprestimo.Rows[tblEmprestimo.CurrentRow.Index].Cells[3].Value.ToString());

            txtTP_emprestimo.Text = Dados_emprestimo.Tipo_emprestimo.Tipo;

            data_devolucao = Dados_emprestimo.Devolucao.ToString();
            
            var ocorrencia = emprestimo.Ocorrencia_emprestimo(
                Dados_emprestimo.Livro.Codigo, 
                Dados_emprestimo.Usuario.Login, 
                Dados_emprestimo.Exemplar.Codigo,
                Dados_emprestimo.Data_emprestimo);

            if (ocorrencia != null)
            {
                txtObs.Text = ocorrencia.Observacao;
                cmbOcorrencia.SelectedIndex = ocorrencia.tipo_Ocorrencia.Codigo;
            }

            if (Dados_emprestimo.Devolucao != null)
            {
                btnDevolucao_.Enabled = false;
                cmbOcorrencia.Enabled = false;
            }
            #endregion
        }

        private void btnDevolucao__Click(object sender, EventArgs e)
        {
            #region Devolução
            try
            {
                Devolucao devolucao = new Devolucao();
                Gerenciar_ocorrencia gerenciar_ocorrencia = new Gerenciar_ocorrencia();
                string criar_devolucao = "", criar_ocorrencia = "";


                if (cmbOcorrencia.SelectedIndex <= 0)
                {
                    var emprestimo = (Emprestimo)tblEmprestimo.CurrentRow.Cells["emprestimo"].Value;
                    criar_devolucao = devolucao._Devolucao(emprestimo.Usuario.Login, emprestimo.Livro.Codigo, emprestimo.Exemplar.Codigo, emprestimo.Data_emprestimo);
                    pnlDevolucao.Visible = false;
                    tblEmprestimo.Rows.Clear();
                    MessageBox.Show(criar_devolucao, "Bibliotec", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var emprestimo = (Emprestimo)tblEmprestimo.CurrentRow.Cells["emprestimo"].Value;

                    var tipo_ocorrencia = ((KeyValuePair<string, int>)cmbOcorrencia.SelectedItem).Value;

                    try
                    {
                        criar_devolucao = devolucao._Devolucao(emprestimo.Usuario.Login, emprestimo.Livro.Codigo, emprestimo.Exemplar.Codigo, emprestimo.Data_emprestimo);
                        pnlDevolucao.Visible = false;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(criar_devolucao, "Bibliotec", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    try
                    {
                        criar_ocorrencia = gerenciar_ocorrencia.Ocorrencia(emprestimo.Usuario.Login, emprestimo.Livro.Codigo, emprestimo.Exemplar.Codigo, emprestimo.Data_emprestimo, tipo_ocorrencia, txtObs.Text);
                        pnlDevolucao.Visible = false;

                    }
                    catch (Exception)
                    {
                        MessageBox.Show(criar_ocorrencia, "Bibliotec", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    tblEmprestimo.Rows.Clear();
                    txtObs.Clear();
                    pnlDevolucao.Visible = false;
                    MessageBox.Show(criar_devolucao + " " + criar_ocorrencia, "Bibliotec", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Oops! Houve um problema ao fazer a devolução, tente novamente", "Bibliotec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion
        }

        private void cmbOcorrencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtObs.Enabled = false;
            if (cmbOcorrencia.SelectedIndex >= 1 && data_devolucao == "")
            {
                txtObs.Enabled = true;
            }
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
                tssUsuario.Text = Usuario.Nome;
                #region Busca
                try
                {
                    Gerenciar_emprestimo emprestimo = new Gerenciar_emprestimo();
                    tblEmprestimo.Rows.Clear();

                    if (Usuario.Login == null || Usuario.Login == "")
                    {
                        MessageBox.Show("Erro na pesquisa dos empréstimos do aluno", "Bibliotec", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    foreach (Emprestimo emprestimo1 in emprestimo.Listar_Emprestimo(Usuario.Login))
                    {
                        var timestamp = emprestimo1.Data_emprestimo.ToString("yyyy/MM/d") + ":" + emprestimo1.Hora_emprestimo;
                        tblEmprestimo.Rows.Add(
                            emprestimo1.Livro.Codigo,
                            emprestimo1.Usuario.Login,
                            emprestimo1.Livro.Titulo,
                            emprestimo1.Exemplar.Codigo,
                            timestamp,
                            emprestimo1.Devolucao_estimada.ToString("yyyy/MM/d"),
                            emprestimo1.Devolucao?.ToString("yyyy/MM/d") ?? "Não devolvido",
                            emprestimo1
                         );
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Oops! Houve um problema ao pesquisar, tente novamente", "Bibliotec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                #endregion

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
    }
}
