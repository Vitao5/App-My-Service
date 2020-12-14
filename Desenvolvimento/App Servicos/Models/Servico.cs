using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_Servicos.Models
{
    public class Servico
    {
        public int IdServico { get; set; }
        public int IdTrabalhador { get; set; }
        public int IdCliente { get; set; }
        public string Endereco { get; set; }
        public decimal  Valor { get; set; }
        public string Descricao { get; set; }
        public string NomeServico { get; set; }

    }
}
