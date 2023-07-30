using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    public class Tipo_emprestimo
    {
		public int Codigo { get; set; }
		public string Tipo { get; set; }

		public Tipo_emprestimo(int Codigo, string Tipo)
		{
			this.Codigo = Codigo;
			this.Tipo = Tipo;
		}

        public Tipo_emprestimo( )
        { 
        }
    }
}
