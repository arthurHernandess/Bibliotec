using Bibliotec.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Bibliotec.Logic
{
    internal class Listar_livros
    {

        private string SelectLivros(string where)
        {
            return $@"select
            l. *,
            e.nm_editora as Editora,
            group_concat(distinct(l_au.cd_autor)) as 'Código autores',
            group_concat(distinct(au.nm_autor)) as Autores,
            group_concat(distinct(l_cat.cd_categoria)) as 'Código categoria',
            group_concat(distinct(cat.nm_categoria)) as Categorias
            from livro l join editora e ON(l.cd_editora = e.cd_editora)
            join livro_autor l_au ON(l.cd_livro = l_au.cd_livro)
            join autor au ON(l_au.cd_autor = au.cd_autor)
            join livro_categoria l_cat ON(l.cd_livro = l_cat.cd_livro)
            join categoria cat ON(cat.cd_categoria = l_cat.cd_categoria)
            where {where}
            group by l.cd_livro;";
        }

        
        public List<Livro> Listar(string pesquisa)
        {
            List<Livro> Lista = new List<Livro>();

            BancoMySql banco = new BancoMySql();
            Gerenciar_livro gerenciar = new Gerenciar_livro();

            banco.Conectar();
            MySqlDataReader dados = banco.Consultar(SelectLivros($"l.cd_livro like '{pesquisa}' or l.cd_isbn like '{pesquisa}%' or LOWER(l.nm_livro) like '{pesquisa}%'"));

            if (dados.HasRows)
            {
                while (dados.Read())
                    {
                    Lista.Add(DataReader_to_Livro(gerenciar, dados));
                }
            }
            if (!dados.IsClosed)
                dados.Close();
            banco.Desconectar();

            return Lista;
        }

        public Livro Mostrar_dados_livro(string cod)
        {
            BancoMySql banco = new BancoMySql();
            Gerenciar_livro gerenciar = new Gerenciar_livro();
            Livro livro = null;
            banco.Conectar();
            MySqlDataReader dados = banco.Consultar(SelectLivros($"l.cd_livro = '{cod}'"));

            if (dados.HasRows)
            {
                if (dados.Read())
                {
                    livro = DataReader_to_Livro(gerenciar, dados);
                    #region Foto da Capa
                    livro.Capa = "";
                    if (!String.IsNullOrEmpty(dados["img_capa"].ToString()))
                    {
                        byte[] foto = null;
                        foto = (byte[])dados["img_capa"];
                        string base64String = Convert.ToBase64String(foto, 0, foto.Length);
                        livro.Capa = base64String;
                    }
                    #endregion
                }
            }
            if (!dados.IsClosed)
                dados.Close();

            banco.Desconectar();
            return livro;
        }

        private static Livro DataReader_to_Livro(Gerenciar_livro gerenciar, MySqlDataReader dados)
        {
            Livro livro;
            #region Modelos
            Editora editora_livro = new Editora(int.Parse(dados["cd_editora"].ToString()), dados["Editora"].ToString());

            var Autor_List = gerenciar.Listar_Autor(dados["Código autores"].ToString(), dados["Autores"].ToString());
            var Categoria_List = gerenciar.Listar_Categoria(dados["Código categoria"].ToString(), dados["Categorias"].ToString());

            livro = new Livro(int.Parse(dados["cd_livro"].ToString()), dados["cd_ISBN"].ToString(), dados["nm_livro"].ToString(), int.Parse(dados["aa_edicao"].ToString()), dados["ds_sinopse"].ToString(), editora_livro);
            #endregion

            #region Adcionar Autores e Categorias
            foreach (var Autor in Autor_List)
                livro.Autor_list.Add(Autor);

            foreach (var categoria in Categoria_List)
                livro.Categoria_list.Add(categoria);
            #endregion
            return livro;
        }

        public List<Exemplar> Listar_exemplares_disponiveis(int cd_livro)
        {
            List<Exemplar> Exemplares = new List<Exemplar>();
            BancoMySql banco = new BancoMySql();
            banco.Conectar();

            MySqlDataReader dados = banco.Consultar("select ex.*, l.* from exemplar ex join localizacao l on (ex.cd_localizacao = l.cd_localizacao) where cd_exemplar not in"
                + $" (select cd_exemplar from emprestimo where cd_livro = {cd_livro} and dt_devolucao is null) and cd_livro = {cd_livro};");

            if (dados.HasRows)
            {
                while (dados.Read())
                {
                    Exemplar exemplar = DataReader_to_Exemplar(cd_livro, dados);

                    Exemplares.Add(exemplar);
                }
            }
            if (!dados.IsClosed)
                dados.Close();

            banco.Desconectar();

            return Exemplares;
        }

        private static Exemplar DataReader_to_Exemplar(int cd_livro, MySqlDataReader dados)
        {
            Localizacao localizacao = new Localizacao(int.Parse(dados["cd_localizacao"].ToString()), dados["nm_localizacao"].ToString());

            Livro livro = new Livro(cd_livro);

            Exemplar exemplar = new Exemplar(int.Parse(dados["cd_exemplar"].ToString()), livro, bool.Parse(dados["ic_fixo"].ToString()), localizacao, dados["cd_rfid"].ToString());
            return exemplar;
        }

        public List<Exemplar> Listar_exemplares(int cd_livro)
        {
            List<Exemplar> Exemplares_Totais = new List<Exemplar>();

            BancoMySql banco = new BancoMySql();
            banco.Conectar();
            MySqlDataReader dados = banco.Consultar($"select ex.*, l.* from exemplar ex join localizacao l on (ex.cd_localizacao = l.cd_localizacao) where cd_livro = {cd_livro};");

            if (dados.HasRows)
            {
                while (dados.Read())
                {
                    Exemplares_Totais.Add(DataReader_to_Exemplar(cd_livro, dados));
                }
            }
            if (!dados.IsClosed)
                dados.Close();
            banco.Desconectar();
            return Exemplares_Totais;

        }
    }
}
