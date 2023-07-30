using Bibliotec.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotec.Logic
{
    internal class Gerenciar_livro
    {
        public List<Autor> Listar_Autor(string cd, string nome)
        {
            List<Autor> Autor_list = new List<Autor>();
            List<string>  Nome_list = nome.Split(',').ToList();
            List<string>  Codigo_list = cd.Split(',').ToList();

            for (int i = 0; i < Codigo_list.Count; i++)
            {
                Autor autor = new Autor(int.Parse(Codigo_list[i]), Nome_list[i]);
                Autor_list.Add(autor);
            }
            return Autor_list;
        }

        public List<Categoria> Listar_Categoria(string cd, string nome)
        {
            List<Categoria> Categoria_list = new List<Categoria>();
            List<string> Nome_list = nome.Split(',').ToList();
            List<string> Codigo_list = cd.Split(',').ToList();

            for (int i = 0; i < Codigo_list.Count; i++)
            {
                Categoria categoria = new Categoria(int.Parse(Codigo_list[i]), Nome_list[i]);
                Categoria_list.Add(categoria);
            }
            return Categoria_list;
        }

        
    }
}
