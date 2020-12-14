using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_Servicos.Models
{
    public class Cliente
    {
        public int IdCliente  { get; set; }
        public string NomeCliente { get; set; }
        public DateTime DataNasc { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public int  VisualizarTrabalhos { get; set; }
    }
}
