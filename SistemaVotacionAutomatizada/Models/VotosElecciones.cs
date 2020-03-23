using System;
using System.Collections.Generic;

namespace SistemaVotacionAutomatizada.Models
{
    public partial class VotosElecciones
    {
        public int Id { get; set; }
        public int? EleccionId { get; set; }
        public int? CandidatoId { get; set; }
        public string CiudadanoId { get; set; }

        public virtual Candidatos Candidato { get; set; }
        public virtual Ciudadanos Ciudadano { get; set; }
        public virtual Elecciones Eleccion { get; set; }
    }
}
