using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VotacionAutomatizada.Models
{
    public class Candidatos
    {


        public int Id { get; set; }
        [StringLength(50)]
        [Required]
        public string nombre { get; set; }
        [StringLength(70)]
        [Required]
        public string apellido { get; set; }
        [StringLength(30)]
        public string foto { get; set; }
        public bool estado { get; set; }


        //[Column("Puesto Electivo")]
        [ForeignKey("Puesto_electivo")]
        public int Puesto_electivoId { get; set; }
        public Puesto_electivo Puesto_electivo { get; set; }


        [ForeignKey("Partido")]
        public int PartidoId { get; set; }
        public Partidos Partido { get; set; }

    }
}
