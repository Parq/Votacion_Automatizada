using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using VotacionAutomatizada.Models;

namespace SistemaVotacionAutomatizada.ViewModels
{
    public class Puesto_electivoCreateViewModel
    {

        [Required]
        [StringLength(40)]
        public string nombre { get; set; }
        [Required]
        public string descripcion { get; set; }
        public bool estado { get; set; }

        public List<Candidatos> Candidatos { get; set; }

        public Puesto_electivoCreateViewModel()
        {

            Candidatos = new List<Candidatos>();

        }
    }
}
