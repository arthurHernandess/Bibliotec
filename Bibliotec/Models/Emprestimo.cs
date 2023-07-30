using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    internal class Emprestimo
    {
        public Usuario Usuario { get; set; }
		public Exemplar Exemplar{ get; set; }
		public Livro Livro { get; set; }
		public DateTime Data_emprestimo { get; set; }
		public TimeSpan Hora_emprestimo { get; set; }
		public DateTime Devolucao_estimada { get; set; }
		public DateTime? Devolucao { get; set; }
		public Tipo_emprestimo Tipo_emprestimo { get; set; }
        public Emprestimo(Usuario usuario, Exemplar exemplar, Livro livro, DateTime data_emprestimo, TimeSpan hora_emprestimo, DateTime devolucao_estimada, DateTime? devolucao, Tipo_emprestimo tipo_emprestimo)
        {
            Usuario = usuario;
            Exemplar = exemplar;
            Livro = livro;
            Data_emprestimo = data_emprestimo;
            Hora_emprestimo = hora_emprestimo;
            Devolucao_estimada = devolucao_estimada;
            Devolucao = devolucao;
            Tipo_emprestimo = tipo_emprestimo;
        }
		 
	}
}

