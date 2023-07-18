using GestionCapitalHumano.Models;
using GestionCapitalHumano.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace GestionCapitalHumano.Controllers
{
    [ApiController]
    [Route("Empleado")]
    public class EmpleadoController: ControllerBase
    {
        private readonly ILogger<EmpleadoController> _logger;
        private EmpleadoService _service;

        public EmpleadoController(ILogger<EmpleadoController> logger)
        {
            _logger = logger;
            _service = new EmpleadoService();
        }

        [HttpPost]
        public IActionResult Post(Empleado empleado)
        {
            return Ok(_service.crearEmpleado(empleado));
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
           return Ok(new Empleado());

           
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.getEmpleados());
        }
    }
}
