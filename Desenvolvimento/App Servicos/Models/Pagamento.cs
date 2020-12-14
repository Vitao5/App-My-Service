using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_Servicos.Models
{
    public class Pagamento
    {
        public int IdPagamento { get; set; }
        public string FormaPagamento{ get; set; }
        public string ContaPagante { get; set; }
        public string ContaRecebedora { get; set; }
        public  string NomeTrabalhador { get; set; }
        public string NomeCliente { get; set; }
        public decimal Valor { get; set; }

    }
}
