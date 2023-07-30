using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotec.Logic
{
    internal class BancoMySql
    {
        public string LinhaConexao { get; set; }
        MySqlConnection conexao = null;

        public BancoMySql()
        {
            LinhaConexao = Conexao.String_conexao;
        }

        public void Conectar()
        {
            conexao = new MySqlConnection(LinhaConexao);
            try
            {
                conexao.Open();
            }
            catch
            {
                throw new Exception("Não foi possível conectar ao servidor.");
            }
        }

        public void Desconectar()
        {
            if (conexao != null)
            {
                if (conexao.State == System.Data.ConnectionState.Open)
                    conexao.Close();
            }
        }

        public MySqlDataReader Consultar(string comando)
        {
            if (conexao != null)
            {
                MySqlCommand cSQL = new MySqlCommand(comando, conexao);
                return cSQL.ExecuteReader();
            }
            else
                throw new Exception("Erro ao tentar realizar consulta. Tente novamente.");
        }

        public string Executar(string comando)
        {
            if (comando != null)
            {
                MySqlCommand cSQL = new MySqlCommand(comando, conexao);
                cSQL.ExecuteNonQuery();
                return null;
            }
            else
                throw new Exception("Erro ao tentar inserir dados. Tente novamente.");
        }
    }
}
