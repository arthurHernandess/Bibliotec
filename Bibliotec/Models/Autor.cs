using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    public class Autor
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public Autor(int cd, string nome)
        {
            this.Codigo = cd;
            this.Nome = nome;
        }
    }
}
