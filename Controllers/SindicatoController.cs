using GestionCapitalHumano.DTOs;
using GestionCapitalHumano.Interfaces;
using GestionCapitalHumano.Managers;
using GestionCapitalHumano.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestionCapitalHumano.Controllers
{
    [ApiController]
    [Route("/api")]
    public class SindicatoController : Controller
    {
        private readonly ISindicatoManager _sindicatoManager;
        public SindicatoController(ISindicatoManager sindicatoManager)
        {
            _sindicatoManager = sindicatoManager;
        }

        [HttpPost("sindicato")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Post(Sindicato sindicato)
        {
            return Ok(_sindicatoManager.crearSindicato(sindicato));
        }

        [HttpPut("sindicato/{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Put(int id, Sindicato sindicato)
        {
            return Ok(_sindicatoManager.editarSindicato(id,sindicato));
        }

        [HttpDelete("sindicato/{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Delete(int id)
        {
            var result = _sindicatoManager.deleteSindicato(id);

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
