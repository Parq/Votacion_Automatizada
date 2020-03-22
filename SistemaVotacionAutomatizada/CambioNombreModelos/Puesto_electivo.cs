using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VotacionAutomatizada.Models
{
    public class Puesto_electivo
    {

        public int Id { get; set; }
        [Required]
        [StringLength(40)]
        public string nombre { get; set; }
        [Required]
        public string descripcion { get; set; }
        public bool estado { get; set; }

        public List<Candidatos> Candidatos{ get; set; }
        public Puesto_electivo()
        {
            Candidatos = new List<Candidatos>();
        }
    }
}
