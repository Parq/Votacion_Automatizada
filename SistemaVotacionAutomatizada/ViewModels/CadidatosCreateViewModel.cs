using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using VotacionAutomatizada.Models;

namespace SistemaVotacionAutomatizada.ViewModels
{
    public class CadidatosCreateViewModel
    {

        [StringLength(50)]
        [Required]
        public string nombre { get; set; }
        [StringLength(70)]
        [Required]
        public string apellido { get; set; }
        [StringLength(30)]
        public IFormFile Photo { get; set; }
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
