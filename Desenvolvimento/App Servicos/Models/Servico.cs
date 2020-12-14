using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App_Servicos.Models
{
    public class Servico
    {
        public int IdServico { get; set; }
        public int IdTrabalhador { get; set; }
        public int IdCliente { get; set; }
        [Required(ErrorMessage = "campo obrigatorio")]
        public string Endereco { get; set; }
        [Required(ErrorMessage = "campo obrigatorio")]
        public decimal  Valor { get; set; }
        [Required(ErrorMessage = "campo obrigatorio")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "campo obrigatorio")]
        public string NomeServico { get; set; }

    }
}
