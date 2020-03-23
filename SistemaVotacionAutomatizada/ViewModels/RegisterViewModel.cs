using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVotacionAutomatizada.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name ="Usuario")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Contraseña")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name ="Confirmar contraseña")]
        [Compare("Password", ErrorMessage ="Contraseñas no coinciden")]
        public string ConfirmPassword { get; set; }
    }
}
