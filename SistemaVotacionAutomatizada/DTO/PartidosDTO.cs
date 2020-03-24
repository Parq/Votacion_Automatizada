using Microsoft.AspNetCore.Http;
using SistemaVotacionAutomatizada.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVotacionAutomatizada.DTO
{
    public class PartidosDTO
    {
        public PartidosDTO()
        {
            Candidatos = new HashSet<Candidatos>();
        }

        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public IFormFile Logo { get; set; }
        public bool? Estado { get; set; }

        public virtual ICollection<Candidatos> Candidatos { get; set; }
    }
}
