using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    public class Editora
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public Editora(int cd, string nome)
        {
            this.Codigo = cd;
            this.Nome = nome;
        }
    }
}
