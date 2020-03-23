using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVotacionAutomatizada.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Usuario")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Contraseña")]
        public string Password { get; set; }

        [Display(Name ="Recuérdame")]
        public bool RememberMe { get; set; }

    }
}
