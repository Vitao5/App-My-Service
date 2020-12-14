using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_Servicos.Models
{
    public class PrestadorServico
    {
        public int IdTrabalhador { get; set; }
        public  string NomeTrabalhador { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
    }
}
