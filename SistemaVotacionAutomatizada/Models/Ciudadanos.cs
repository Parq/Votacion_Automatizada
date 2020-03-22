﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaVotacionAutomatizada.Models
{
    public partial class Ciudadanos
    {
        [Required]
        [StringLength(11, MinimumLength = 11)]
        public string Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        
        public bool? Estado { get; set; }
    }
}
