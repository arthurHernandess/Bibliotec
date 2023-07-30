using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    public class Bolsa
    {
        public Exemplar Exemplar { get; set; }
        public Livro Livro { get; set; }
        public Tipo_emprestimo Tipo_emprestimo { get; set; }

        public Bolsa(Exemplar exemplar, Livro livro, Tipo_emprestimo tipo)
        {
            this.Exemplar = exemplar;
            this.Livro = livro;
            this.Tipo_emprestimo = tipo;
        }
    }
}
