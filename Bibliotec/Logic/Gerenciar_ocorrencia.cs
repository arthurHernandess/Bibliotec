using Bibliotec.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotec.Logic
{
    internal class Gerenciar_ocorrencia
    {
        public List<Tipo_ocorrencia> tipo_ocorrencia()
        {
            BancoMySql banco = new BancoMySql();
            banco.Conectar();
            List<Tipo_ocorrencia> tipo_ocorrencia_list = new List<Tipo_ocorrencia>(); 
            MySqlDataReader dados = banco.Consultar($"select * from tipo_ocorrencia;");

            if (dados.HasRows)
            {
                while (dados.Read())
                {
                    Tipo_ocorrencia ocorrencia = new Tipo_ocorrencia(int.Parse(dados["cd_tipo_ocorrencia"].ToString()), dados["nm_tipo_ocorrencia"].ToString());
                    tipo_ocorrencia_list.Add(ocorrencia);
                }
            }
            if (!dados.IsClosed)
                dados.Close();
            banco.Desconectar();

            return tipo_ocorrencia_list;
        }

        public string Ocorrencia(string login, int cd_livro, int cd_exemplar, DateTime Data, int cd_tipo_ocorrencia, string ds_ocorrencia)
        {
            BancoMySql banco = new BancoMySql();
            try
            {
                banco.Conectar();
                banco.Executar($"INSERT INTO ocorrencia VALUES('{login}', {cd_exemplar}, {cd_livro}, '{Data.ToString("yyyy-MM-dd")}', {cd_tipo_ocorrencia}, '{ds_ocorrencia}');");
                banco.Desconectar();
                return "Ocorrência feita com sucesso!";
            }
            catch (Exception)
            {
                return "Houve um problema na Ocorrência!";
            }
        }

        
    }
}
