using Bibliotec.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotec.Logic
{
    internal class Gerenciar_emprestimo
    {
        private string SelectEmprestimos(string where)
        {
            return $@"
            select 
                em.*, l.nm_livro, tem.nm_tipo_emprestimo
            from
                emprestimo em
                    join
                tipo_emprestimo tem ON (em.cd_tipo_emprestimo = tem.cd_tipo_emprestimo)
		            join
	            exemplar ex on (em.cd_livro = ex.cd_livro and em.cd_exemplar = ex.cd_exemplar)
		            join
	            livro l on (em.cd_livro = l.cd_livro)
            where
                {where}";

        }
        public List<Emprestimo> Listar_Emprestimo(string pesquisa)
        {
            BancoMySql banco = new BancoMySql();
            banco.Conectar();
            List<Emprestimo> emprestimo_list = new List<Emprestimo>();

            MySqlDataReader dados = banco.Consultar(SelectEmprestimos($"em.nm_login like '{pesquisa}%' or em.cd_livro = '{pesquisa}' or Lower(l.nm_livro) like '{pesquisa}% ';"));

            if (dados.HasRows)
            {
                while (dados.Read())
                {
                    Livro livro = new Livro() { Codigo = int.Parse(dados["cd_Livro"].ToString()), Titulo = dados["nm_Livro"].ToString() };
                    Exemplar exemplar = new Exemplar(int.Parse(dados["cd_exemplar"].ToString()));
                    Usuario usuario = new Usuario() { Login = dados["nm_login"].ToString() };
                    Tipo_emprestimo tipo_emprestimo = new Tipo_emprestimo() { Codigo = int.Parse(dados["cd_tipo_emprestimo"].ToString()), Tipo = dados["nm_tipo_emprestimo"].ToString() };
                    DateTime? devolucao = dados["dt_devolucao"] == dados["dt_devolucao"] ? null : (DateTime?)dados["dt_devolucao"];
                    Emprestimo emprestimo = new Emprestimo(usuario, exemplar, livro, (DateTime)dados["dt_emprestimo"], (TimeSpan)dados["hr_emprestimo"], (DateTime)dados["dt_devolucao_estimada"], devolucao , tipo_emprestimo);
                    emprestimo_list.Add(emprestimo);
                }
            }
            if (!dados.IsClosed)
                dados.Close();
            banco.Desconectar();
            return emprestimo_list;
        }

        public Emprestimo Emprestimo(string cd_livro, string login, string cd_exemplar)
        {
            BancoMySql banco = new BancoMySql();
            banco.Conectar();
            Emprestimo emprestimo = null;

            MySqlDataReader dados = banco.Consultar(SelectEmprestimos($"em.cd_livro = {cd_livro} and em.nm_login = '{login}' and em.cd_exemplar = {cd_exemplar};"));

            if (dados.HasRows)
            {
                if (dados.Read())
                {
                    Livro livro = new Livro() { Codigo = int.Parse(dados["cd_Livro"].ToString()), Titulo = dados["nm_Livro"].ToString() };
                    Exemplar exemplar = new Exemplar(int.Parse(dados["cd_exemplar"].ToString()));
                    Usuario usuario = new Usuario() { Login = dados["nm_login"].ToString() };
                    Tipo_emprestimo tipo_emprestimo = new Tipo_emprestimo() { Codigo = int.Parse(dados["cd_tipo_emprestimo"].ToString()), Tipo = dados["nm_tipo_emprestimo"].ToString() };
                    DateTime? devolucao = dados["dt_devolucao"] == dados["dt_devolucao"] ? null : (DateTime?)dados["dt_devolucao"];
                    emprestimo = new Emprestimo(usuario, exemplar, livro, (DateTime)dados["dt_emprestimo"], (TimeSpan)dados["hr_emprestimo"], (DateTime)dados["dt_devolucao_estimada"], devolucao, tipo_emprestimo);
                }
            }
            if (!dados.IsClosed)
                dados.Close();
            banco.Desconectar();
            return emprestimo;
        }

        public Ocorrencia Ocorrencia_emprestimo(int cd_livro, string login, int cd_exemplar, DateTime Data)
        {
            BancoMySql banco = new BancoMySql();
            banco.Conectar();
            MySqlDataReader dados = banco.Consultar($@"
            select * from ocorrencia o
                join
            tipo_ocorrencia ot on (o.cd_tipo_ocorrencia = ot.cd_tipo_ocorrencia)
            WHERE cd_livro = {cd_livro} and nm_login = '{login}' and dt_emprestimo = '{Data.ToString("yyyy-MM-dd")}' and cd_exemplar = {cd_exemplar};");
            Ocorrencia ocorrencia = null;

            if (dados.HasRows)
            {
                if (dados.Read())
                {
                    Tipo_ocorrencia tipo = new Tipo_ocorrencia(int.Parse(dados["cd_tipo_ocorrencia"].ToString()), dados["nm_tipo_ocorrencia"].ToString());
                    ocorrencia = new Ocorrencia(Emprestimo(cd_livro.ToString(), login, cd_exemplar.ToString()), tipo, dados["ds_ocorrencia"].ToString());
                    if (ocorrencia.Observacao == null)
                        ocorrencia.Observacao = "";
                }
            }
            if (!dados.IsClosed)
                dados.Close();
            banco.Desconectar();
            return ocorrencia;

        }

        public List<Emprestimo> Emprestimos_devolucao_nula(string user )
        {
            BancoMySql banco = new BancoMySql();
            banco.Conectar();
            List<Emprestimo> emprestimo_list = new List<Emprestimo>();

            MySqlDataReader dados = banco.Consultar(SelectEmprestimos($"nm_login = '{user}' and dt_devolucao is null;"));

            if (dados.HasRows)
            {
                while (dados.Read())
                {
                    Livro livro = new Livro() { Codigo = int.Parse(dados["cd_Livro"].ToString()), Titulo = dados["nm_Livro"].ToString() };
                    Exemplar exemplar = new Exemplar(int.Parse(dados["cd_exemplar"].ToString()));
                    Usuario usuario = new Usuario() { Login = dados["nm_login"].ToString() };
                    Tipo_emprestimo tipo_emprestimo = new Tipo_emprestimo() { Codigo = int.Parse(dados["cd_tipo_emprestimo"].ToString()), Tipo = dados["nm_tipo_emprestimo"].ToString() };

                    DateTime? devolucao = dados["dt_devolucao"] == dados["dt_devolucao"] ? null : (DateTime?)dados["dt_devolucao"];
                   
                    Emprestimo emprestimo = new Emprestimo(usuario, exemplar, livro, (DateTime)dados["dt_emprestimo"], (TimeSpan)dados["hr_emprestimo"], (DateTime)dados["dt_devolucao_estimada"], devolucao, tipo_emprestimo);
                    emprestimo_list.Add(emprestimo);
                }
            }
            if (!dados.IsClosed)
                dados.Close();
            banco.Desconectar();
            return emprestimo_list;
        }
    }
}
