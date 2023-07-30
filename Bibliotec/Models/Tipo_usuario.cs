using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    public class Tipo_usuario
    {   
        public int Codigo { get; set; }
        public string Nome { get; set; }

       public Tipo_usuario(int cd, string nome)
        {
            Codigo = cd;
            Nome = nome;
        }
    }
}
