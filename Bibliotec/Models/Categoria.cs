using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    public class Categoria
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public Categoria(int cd, string Nome)
        {
            this.Codigo = cd;
            this.Nome = Nome;
        }

    }
}
