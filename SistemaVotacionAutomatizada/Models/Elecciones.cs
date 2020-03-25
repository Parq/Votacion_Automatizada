using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaVotacionAutomatizada.Models
{
    public partial class Elecciones
    {
        public Elecciones()
        {
            VotosElecciones = new HashSet<VotosElecciones>();
        }

        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime? Fecha { get; set; }

        //Pablo: remover el tema nulleable
        public bool Estado { get; set; }

        public virtual ICollection<VotosElecciones> VotosElecciones { get; set; }
    }
}
