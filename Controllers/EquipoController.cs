using GestionCapitalHumano.Interfaces;
using GestionCapitalHumano.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestionCapitalHumano.Controllers
{
    [ApiController]
    [Route("/api")]
    public class EquipoController : Controller
    {
        private readonly IEquipoTrabajoManager _equipoTrabajoManager;
        public EquipoController(IEquipoTrabajoManager equipoTrabajoManager)
        {
            _equipoTrabajoManager = equipoTrabajoManager;
        }

        [HttpPost("equipotrabajo")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult Post(EquipoTrabajo equipo)
        {
            return Ok(_equipoTrabajoManager.crear);
        }
    }
}
