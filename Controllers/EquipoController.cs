using GestionCapitalHumano.Interfaces;
using GestionCapitalHumano.Managers;
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
            return Ok(_equipoTrabajoManager.crearEquipoTrabajo(equipo));
        }

        [HttpPut("equipotrabajo/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult Put(int id, EquipoTrabajo equipo)
        {
            return Ok(_equipoTrabajoManager.editarEquipoTrabajo(id, equipo));
        }

        [HttpDelete("equipotrabajo/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult Delete(int id)
        {
            var result = _equipoTrabajoManager.deleteEquipoTrabajo(id);

            if (result)
            {
                return Ok("Soft delete realizado correctamente.");
            }
            else
            {
                return BadRequest("No se pudo realizar el soft delete.");
            }
        }
    }
}
