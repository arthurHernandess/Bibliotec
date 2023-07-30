using Bibliotec.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotec.Logic
{
    internal class Gerenciar_bolsa
    {
        public List<Bolsa> ItensBolsa = new List<Bolsa>();
        public int? tamanho { get; set; }
        public void AdicionarNaBolsa(Exemplar exemplar, Livro livro, Tipo_emprestimo tipo)
        {
            Bolsa bolsa = new Bolsa(exemplar, livro, tipo);
            ItensBolsa.Add(bolsa);
            tamanho = ItensBolsa.Count;
        }
        public void LimparBolsa()
        {
            for(int i = 0; i < ItensBolsa.Count; i++)
            {
                ItensBolsa.Clear();
            }
            tamanho = null;
        }
    }
}
