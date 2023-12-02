using GestionCapitalHumano.Interfaces;
using GestionCapitalHumano.Managers;
using GestionCapitalHumano.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestionCapitalHumano.Controllers
{
    [ApiController]
    [Route("/api")]
    public class PuestoController : Controller
    {
        private readonly IPuestoTrabajoManager _puestoTrabajoManager;
        public PuestoController (IPuestoTrabajoManager puestoTrabajoManager)
        {
            _puestoTrabajoManager = puestoTrabajoManager;
        }

        [HttpPost("puestosTrabajo")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Post(PuestoTrabajo puesto)
        {
            return Ok(_puestoTrabajoManager.crearPuesto(puesto));
        }       

        [HttpDelete("puestoTrabajo")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Delete(PuestoTrabajo puesto)
        {
            return Ok(_puestoTrabajoManager.deletePuesto(puesto));
        }

        [HttpPut("puestoTrabajo")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Put(PuestoTrabajo puesto)
        {
            return Ok(_puestoTrabajoManager.editarPuesto(puesto));
        }

        [HttpGet("puestoTrabajo/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult Get(int id)
        {
            return Ok(_puestoTrabajoManager.getPuesto(id));
        }

        [HttpGet("puestoTrabajo")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult Get()
        {
            return Ok(_puestoTrabajoManager.GetAllPuestos());
        }
    }
}
