using GestionCapitalHumano.DTOs;
using GestionCapitalHumano.Interfaces;
using GestionCapitalHumano.Managers;
using Microsoft.AspNetCore.Mvc;

namespace GestionCapitalHumano.Controllers
{
    [ApiController]
    [Route("/api")]
    public class DepartamentoController : Controller
    {
        private readonly IDepartamentoManager _deptoManager;

        public DepartamentoController(IDepartamentoManager deptoManager)
        {
            _deptoManager = deptoManager;
        }

        [HttpDelete("departamento/{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Delete(int id)
        {
            var result = _deptoManager.deleteDepartamento(id);

            if (result)
            {
                return Ok("Soft delete realizado correctamente.");
            }
            else
            {
                return BadRequest("No se pudo realizar el soft delete.");
            }
        }
        [HttpPut("departamento/{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Put(int id, DepartamentoDTO depto)
        {
            return Ok(_deptoManager.editDepartamento(id, depto));
        }

        [HttpPost("departamento")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Post(DepartamentoDTO depto)
        {
            return Ok(_deptoManager.crearDepartamento(depto));
        }

        [HttpGet("departamento/{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Get(int id)
        {
            return Ok(_deptoManager.GetDepartamento(id));
        }
    }
}
