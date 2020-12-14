using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_Servicos.Models
{
    public class VisualizarTrabalhos
    {
        public  int IdVisualizacao { get; set; }
        public string NomeTrabalhador { get; set; }
        public string DescricaoTrabalho { get; set; }
        public string Cidade { get; set; }
        public decimal Valor { get; set; }
    }
}
