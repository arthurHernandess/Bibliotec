using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    internal class Ocorrencia
    {
        public Emprestimo emprestimo { get; set; }
        public Tipo_ocorrencia tipo_Ocorrencia { get; set; }
        public string Observacao { get; set; }

        public Ocorrencia(Emprestimo emprestimo, Tipo_ocorrencia tipo_Ocorrencia, string observacao)
        {
            this.emprestimo = emprestimo;
            this.tipo_Ocorrencia = tipo_Ocorrencia;
            Observacao = observacao;
        }
    }
}
