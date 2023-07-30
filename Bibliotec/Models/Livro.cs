using Bibliotec.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    public class Livro
    {
        public int Codigo { get; set; }
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public int AnoEdicao { get; set; }
        public string Sinopse { get; set; }
        public string Capa { get; set; }
        public Editora Editora { get; set; }

        public List<Autor> Autor_list = new List<Autor>();

        public List<Categoria> Categoria_list = new List<Categoria>();

        public Livro(int cd, string isbn, string titulo, int ano, string sinopse, Editora editora)
        {
            this.Codigo = cd;
            this.ISBN = isbn;
            this.Titulo = titulo;
            this.AnoEdicao = ano;
            this.Sinopse = sinopse;
            this.Editora = editora;
        }
        public Livro(int cd)
        {
            this.Codigo = cd;
        }
        public Livro(int cd, string isbn, string titulo, Editora editora)
        {
            this.Codigo = cd;
            this.ISBN = isbn;
            this.Titulo = titulo;
            this.Editora = editora;
        }
        public Livro()
        { }


    }
}
