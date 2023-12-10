using GestionCapitalHumano.DTOs;
using GestionCapitalHumano.Interfaces;
using GestionCapitalHumano.Managers;
using Microsoft.AspNetCore.Mvc;

namespace GestionCapitalHumano.Controllers
{
    [ApiController]
    [Route("/api")]
    public class CapacitacionController : Controller
    {
        private readonly ICapacitacionManager _capacitacionManager;
        public CapacitacionController(ICapacitacionManager manager) 
        {
            _capacitacionManager = manager;
        }

        [HttpPost("capacitacion")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Post(CapacitacionDTO capacitacion)
        {
            return Ok(_capacitacionManager.crearCapacitacion(capacitacion));
        }

        [HttpGet("capacitacion")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetAll()
        {
            return Ok(_capacitacionManager.GetCapacitaciones());
        }

        [HttpGet("capacitacion/{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Get(int id)
        {
            return Ok(_capacitacionManager.GetCapacitacion(id));
        }

        [HttpDelete("capacitacion/{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Delete(int id)
        {
            return Ok(_capacitacionManager.deleteCapacitacion(id));
        }

        [HttpPut("capacitacion/{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Put(int id, CapacitacionDTO capacitacion)
        {
            return Ok(_capacitacionManager.editCapacitacion(id,capacitacion));
        }
    }
}
