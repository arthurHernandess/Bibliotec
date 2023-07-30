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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        public Usuario usuario { get; set; }
        private void main_Load(object sender, EventArgs e)
        {
            tssUsuario.Text = usuario.Nome;
        }

        private void buscarLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acervo();
        }

        private void Acervo()
        {
            pesquisa_livro livro = new pesquisa_livro();
            livro.MdiParent = this;
            livro.Show();
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Bibliotec", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gerenciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios();
        }

        private void Usuarios()
        {
            gerenciar_usuarios gerenciar_Usuarios;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(gerenciar_usuarios))
                {
                    childForm.Focus();
                    return;
                }
            }
            gerenciar_Usuarios = new gerenciar_usuarios();
            gerenciar_Usuarios.MdiParent = this;
            gerenciar_Usuarios.Show();
        }

        private void adcionarLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void tsbtnAcervo_Click(object sender, EventArgs e)
        {
            Acervo();
        }

        private void tsbtnUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios();
        }

        private void tsbtnEmprestimo_Click(object sender, EventArgs e)
        {
            gerenciar_emprestimos livro = new gerenciar_emprestimos();
            livro.MdiParent = this;
            livro.Show();
        }
    }
}
