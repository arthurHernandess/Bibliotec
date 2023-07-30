using Bibliotec.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Bibliotec.Logic
{
    internal class Listar_usuarios
    {
        public List<Usuario> Listar_usuario(string usuario)
        {
            List<Usuario> Usuarios_lista = new List<Usuario>();
            BancoMySql banco = new BancoMySql();
            banco.Conectar();
            MySqlDataReader dados = banco.Consultar($"select * from usuario u join tipo_usuario tu on (tu.cd_tipo_usuario = u.cd_tipo_usuario) where Lower(nm_usuario) like '{usuario}%' or Lower(nm_login) like '{usuario}%';");
            if (dados.HasRows)
            {
                while (dados.Read())
                {
                    Tipo_usuario tipo_Usuario = new Tipo_usuario(int.Parse(dados["cd_tipo_usuario"].ToString()), dados["nm_tipo_usuario"].ToString());
                    Usuario Usuario = new Usuario(dados["nm_usuario"].ToString(), dados["nm_login"].ToString(),
                        dados["nm_senha"].ToString(), bool.Parse(dados["ic_bloqueado"].ToString()), dados["dt_bloqueio"].ToString(), tipo_Usuario);

                    Usuarios_lista.Add(Usuario);

                }
            }
            if (!dados.IsClosed)
                dados.Close();

            banco.Desconectar();
            return Usuarios_lista;
        }
        public Usuario Dados_usuario(string usuario)
        {
            BancoMySql banco = new BancoMySql();
            banco.Conectar();
            MySqlDataReader dados = banco.Consultar($"select * from usuario u join tipo_usuario tu on (tu.cd_tipo_usuario = u.cd_tipo_usuario) where Lower(nm_login) = '{usuario}';");
            if (dados.HasRows)
            {
                if (dados.Read())
                {
                    Tipo_usuario tipo_Usuario = new Tipo_usuario(int.Parse(dados["cd_tipo_usuario"].ToString()), dados["nm_tipo_usuario"].ToString());
                    Usuario Usuario = new Usuario(dados["nm_usuario"].ToString(), dados["nm_login"].ToString(),
                        dados["nm_senha"].ToString(), bool.Parse(dados["ic_bloqueado"].ToString()), dados["dt_bloqueio"].ToString(), tipo_Usuario);
                    return Usuario;
                }
            }
            if (!dados.IsClosed)
                dados.Close();

            banco.Desconectar();
            return null;
        }
    }
}
