using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaVotacionAutomatizada.Models;
using SistemaVotacionAutomatizada.ViewModels;

namespace SistemaVotacionAutomatizada.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MenuAdmin()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ValidadorCedula()
        {
            return View();
        }

        /*[HttpPost]
        public IActionResult ValidadorCedula(CiudadanosViewModel ciudadanosViewModel)
        {
            if (ciudadanosViewModel.Id)
            {
                return ("Usted ya ha votado en las elecciones vigentes!");
            }
            else if (ciudadanosViewModel.Id)
            {
                return ("No existen procesos electorales activos en este momento.");
            }
            else if (ciudadanosViewModel.Id)
            {
                return ("Este número de cédula se encuentra en estado inactivo!");
            }
            else
            {
                return View("MenuCiudadano");
            }
        }*/

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
