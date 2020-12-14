using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App_Servicos.Models
{
    public class LoginSistema
    {
        public int IdUsuario { get; set; }
        [Required(ErrorMessage = "campo obrigatorio")]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "campo obrigatorio")]
        public string Senha { get; set; }

    }
}
