using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotec.Logic
{
    internal class Devolucao
    {
        public string _Devolucao(string login, int cd_livro, int cd_exemplar, DateTime Data)
        {
            BancoMySql banco = new BancoMySql();
            try
            {
                DateTime? Devolucao = null;
                DateTime? Devolucao_estimada = null;
                banco.Conectar();
                banco.Executar($"UPDATE emprestimo SET dt_devolucao = '{DateTime.Now.ToString("yyyy-MM-dd")}' WHERE cd_livro = {cd_livro} and nm_login = '{login}' and cd_exemplar = {cd_exemplar} and dt_emprestimo = '{Data.ToString("yyyy-MM-dd")}'; ");

                MySqlDataReader dados = banco.Consultar($"select * from emprestimo WHERE cd_livro = {cd_livro} and nm_login = '{login}' and cd_exemplar = {cd_exemplar} and dt_emprestimo = '{Data.ToString("yyyy-MM-dd")}'");

                if (dados.HasRows)
                {
                    if (dados.Read())
                    {
                        Devolucao = (DateTime)dados["dt_devolucao"];
                        Devolucao_estimada = (DateTime)dados["dt_devolucao_estimada"];
                    }
                }
                if (!dados.IsClosed)
                    dados.Close();
                if (Devolucao > Devolucao_estimada)
                {
                    banco.Executar($"update usuario set dt_bloqueio = curdate() where nm_login = '{login}';");
                    banco.Executar($"update usuario set ic_bloqueado = 1 where nm_login = '{login}';");
                }
                banco.Desconectar();
                return "Devolução feita com sucesso!";
            }
            catch (Exception)
            {
                return "Houve um problema na devolução!";
            }
        }
    }
}
