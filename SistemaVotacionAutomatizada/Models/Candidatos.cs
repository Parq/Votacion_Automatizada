using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaVotacionAutomatizada.Models
{
    public partial class Candidatos
    {
        public Candidatos()
        {
            VotosElecciones = new HashSet<VotosElecciones>();
        }

        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Photo { get; set; }
        public bool? Estado { get; set; }
        public int? PartidoId { get; set; }
        public int? PuestoElectivosId { get; set; }

        public virtual Partidos Partido { get; set; }
        public virtual PuestoElectivos PuestoElectivos { get; set; }
        public virtual ICollection<VotosElecciones> VotosElecciones { get; set; }
    }
}
