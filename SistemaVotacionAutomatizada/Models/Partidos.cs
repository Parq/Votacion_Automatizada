using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaVotacionAutomatizada.Models
{
    public partial class Partidos
    {
        public Partidos()
        {
            Candidatos = new HashSet<Candidatos>();
        }

        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Logo { get; set; }
        public bool? Estado { get; set; }

        public virtual ICollection<Candidatos> Candidatos { get; set; }
    }
}
