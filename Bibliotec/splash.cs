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
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }
        public Usuario usuario { get; set; }
        private void btnEntrar_Click(object sender, EventArgs e)
        {

            if (txtLogin.Text == "")
            {
                MessageBox.Show("Insira o login do usuário!", "Bibliotec", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Listar_usuarios listar_Usuario = new Listar_usuarios();
                usuario = listar_Usuario.Dados_usuario(txtLogin.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro a consultar o banco de dados", "Bibliotec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (usuario == null)
            {
                MessageBox.Show("Usuário não encontrado!", "Bibliotec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (usuario.Login == txtLogin.Text && usuario.Senha == txtSenha.Text && usuario.tipo_Usuario.Codigo == 2 || usuario.tipo_Usuario.Codigo == 1)
            {
                main main = new main();
                main.usuario = usuario;
                main.Show();
                this.Hide();
            }
            else if (usuario.Senha != txtSenha.Text)
            {
                MessageBox.Show("Senha do usuário incorreta", "Bibliotec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (usuario.Login != txtLogin.Text)
            {
                MessageBox.Show("Login do usuário incorreta", "Bibliotec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Acesso não permitido para esse usuário", "Bibliotec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void splash_Load(object sender, EventArgs e)
        {
        }
    }
}
