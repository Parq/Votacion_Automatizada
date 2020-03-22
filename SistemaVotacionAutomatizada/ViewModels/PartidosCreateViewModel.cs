using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VotacionAutomatizada.Models;

namespace SistemaVotacionAutomatizada.ViewModels
{
    public class PartidosCreateViewModel
    {

        public string nombre { get; set; }
        public string descripcion { get; set; }
        public IFormFile Photo { get; set; }

        public bool estado { get; set; }
        public List<Candidatos> Candidatos { get; set; }
        public PartidosCreateViewModel()
        {

            Candidatos = new List<Candidatos>();

        }
    }
}
