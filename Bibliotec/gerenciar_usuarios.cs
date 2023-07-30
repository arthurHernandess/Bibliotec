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
    public partial class gerenciar_usuarios : Form
    {
        public Usuario Usuario { get; set; }

        public bool btn_visible { get; set; }

        public gerenciar_usuarios()
        {
            InitializeComponent();
        }


        private void btnBusca_Click(object sender, EventArgs e)
        {
            string pesquisa = (txtPesquisa.Text).ToLower();
            tblUsuarios.Rows.Clear();


            if (pesquisa == "")
            {
                MessageBox.Show("Insira o nome / login do usuário!", "Bibliotec", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Listar_usuarios listar_usuarios = new Listar_usuarios();
            foreach (Usuario usuario in listar_usuarios.Listar_usuario(pesquisa))
            {
                tblUsuarios.Rows.Add(usuario.Login.ToString(), usuario.Nome.ToString(), usuario.Data_bloqueio.ToString(), usuario.Bloqueado);
            }

        }

        private void gerenciar_usuarios_Load(object sender, EventArgs e)
        {
            
            btnConfirmar.Visible = btn_visible;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(tblUsuarios?.CurrentRow is null || tblUsuarios.CurrentRow.Index == -1)
            {
                MessageBox.Show("Selecione o Usuário!", "Bibliotec", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string codigo_livro_celula = tblUsuarios.Rows[tblUsuarios.CurrentRow.Index].Cells[0].Value.ToString();
            Listar_usuarios listar_usuarios = new Listar_usuarios();
            Usuario usuario = listar_usuarios.Dados_usuario(codigo_livro_celula);
            Usuario = usuario;
            this.Close();
        }

        private void tblUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            btnConfirmar.Enabled = true;
            if (tblUsuarios.Rows[tblUsuarios.CurrentRow.Index].Cells[3].Value.ToString() == "True")
            {
                btnConfirmar.Enabled = false;
            }
        }
    }
}
