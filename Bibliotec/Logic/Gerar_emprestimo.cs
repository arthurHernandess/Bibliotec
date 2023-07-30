using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotec.Logic
{
    internal class Gerar_emprestimo
    {
        public Gerar_emprestimo(string usuario, int exemplar, int cd_livro, int cd_tipo)
        {
            string data_estimada = null;

            DateTime dateTime = DateTime.Now;
            string data_atual = dateTime.ToString("yyyy/MM/d");
            string hora_atual = dateTime.ToString("T");
            if (cd_tipo == 2)
                data_estimada = (dateTime.AddDays(14)).ToString("yyyy/MM/d");
            else
                data_estimada = (dateTime).ToString("yyyy/MM/d");
            if (cd_livro == 1)
            {
                data_estimada = data_atual;
            }
            BancoMySql banco = new BancoMySql();
            banco.Conectar();
            banco.Executar($"insert into emprestimo values('{usuario}', {exemplar}, {cd_livro}, '{data_atual}', '{hora_atual}', '{data_estimada}', null, {cd_tipo});");
            banco.Desconectar();
        }

    }
}
