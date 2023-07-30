using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    public class Exemplar
    {
        public int Codigo { get; set; }
        public string RFID { get; set; }
        public Livro Livro { get; set; }
        public Localizacao Localizacao { get; set; }
        public bool Fixo { get; set; }

        public Exemplar(int cd, Livro livro, bool fixo, Localizacao localizacao, string rfid)
        {
            this.Codigo = cd;
            this.Livro = livro;
            this.Fixo = fixo;
            this.Localizacao = localizacao;
            this.RFID = rfid;
        }

        public Exemplar(int codigo)
        {
            Codigo = codigo;
        }
    }
}
