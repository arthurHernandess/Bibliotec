using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    internal class Tipo_ocorrencia
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public Tipo_ocorrencia(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }

    }
}
