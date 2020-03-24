using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SistemaVotacionAutomatizada.Models;

namespace SistemaVotacionAutomatizada.DTO
{
    public partial class PuestoElectivosDTO
    {
        public PuestoElectivosDTO()
        {
            Candidatos = new HashSet<Candidatos>();
        }

        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Descripcion { get; set; }
        public bool? Estado { get; set; }

        public virtual ICollection<Candidatos> Candidatos { get; set; }
    }
}
