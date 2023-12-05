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
        public IActionResult Delete(int id, PuestoTrabajo puesto)
        {
            var result = _puestoTrabajoManager.deletePuesto(id);

            if (result)
            {
                return Ok("Soft delete realizado correctamente.");
            }
            else
            {
                return BadRequest("No se pudo realizar el soft delete.");
            }
        }



        [HttpPut("puestoTrabajo")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Put(int id,PuestoTrabajo puesto)
        {
            return Ok(_puestoTrabajoManager.editarPuesto(id,puesto));
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
        public ActionResult<List<PuestoTrabajo>> Get()
        {
            var puestos = _puestoTrabajoManager.GetAllPuestos();
            return puestos;
        }
    }
}
