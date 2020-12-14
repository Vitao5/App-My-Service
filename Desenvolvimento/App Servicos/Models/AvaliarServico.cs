using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_Servicos.Models
{
    public class AvaliarServico
    {
        public int IdAvaliacao { get; set; }
        public  string Descricao  { get; set; }
        public string NomeCliente { get; set; }
        public string NomeTrabalhador { get; set; }
        public int IdServico { get; set; }

        public Servico Servico { get; set; }

    }
}
