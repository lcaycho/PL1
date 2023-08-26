using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PL1.Models;

namespace PL1.Controllers
{
    public class JugadorController : Controller
    {
        private readonly ILogger<JugadorController> _logger;

        public JugadorController(ILogger<JugadorController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Jugador objJugador)
        {
            decimal costoInscripcion = 300; // Costo base de inscripción
            decimal impuesto = 0.19m; // 19% de impuesto

            // Calcula el costo total basado en la cantidad de temporadas seleccionadas
            objJugador.CostoTotal = costoInscripcion * objJugador.Temporada * (1 + impuesto);

            ViewData["Message"] = $"Estimado {objJugador.Name}, está registrado en el equipo {objJugador.Equipo}. El costo total de inscripción por {objJugador.Temporada} temporada(s) es: {objJugador.CostoTotal:C}";

            return View("Index", objJugador);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}