using GestionCapitalHumano.DTOs;
using GestionCapitalHumano.Interfaces;
using GestionCapitalHumano.Models;
using Microsoft.AspNetCore.Mvc;


namespace GestionCapitalHumano.Controllers
{
    [ApiController]
    [Route("/api")]
    public class EmpleadoController: ControllerBase
    {
        private readonly IEmpleadoManager _empleadoManager;

        public EmpleadoController(IEmpleadoManager empleadoManager)
        {
            _empleadoManager = empleadoManager;
        }

        [HttpPost("empleados")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Post(EmpleadoDTO empleado)
        {
            return Ok(_empleadoManager.crearEmpleado(empleado));
        }

        [HttpPut("empleados/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult Put(EmpleadoDTO empleado, int id)
        {
            return Ok(_empleadoManager.editarEmpleado(empleado,id));
        }
        [HttpGet("empleados/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult Get(int id)
        {
           return Ok(_empleadoManager.getEmpleado(id));
        }

        [HttpGet("empleados")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult Get()
        {
            return Ok(_empleadoManager.getEmpleados());
        }

        [HttpDelete("empleados/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult Delete(int id)
        {
            _empleadoManager.deleteEmpleado(id);
            return Ok("Empleado eliminado con exito!");
        }
    }
}
