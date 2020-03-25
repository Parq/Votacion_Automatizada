using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SistemaVotacionAutomatizada.ViewModels
{
    public class CiudadanosViewModel
    {
        [Required]
        [StringLength(11, MinimumLength = 11)]
        public string Id { get; set; }
    }
}