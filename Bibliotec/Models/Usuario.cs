using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool Bloqueado { get; set; }
        public string Data_bloqueio { get; set; }
        public Tipo_usuario tipo_Usuario { get; set; }

        public Usuario(string nome, string login, string senha, bool bloqueado, string data_bloqueio, Tipo_usuario tipo_usuario)
        {
            Nome = nome;
            Login = login;
            Senha = senha;
            Bloqueado = bloqueado;
            Data_bloqueio = data_bloqueio;
            tipo_Usuario = tipo_usuario;
        }
        public Usuario( )
        {
             
        }
    }
}
