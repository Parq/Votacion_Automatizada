using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VotacionAutomatizada.Models
{
    public class Partidos
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public string descripcion { get; set; }
        public string logo { get; set; }
        public bool estado { get; set; }

        public List<Candidatos> Candidatos { get; set; }
        public Partidos()
        {
            Candidatos = new List<Candidatos>();
        }
    }
}
