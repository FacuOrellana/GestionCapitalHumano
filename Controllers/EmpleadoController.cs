using GestionCapitalHumano.Managers;
using GestionCapitalHumano.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace GestionCapitalHumano.Controllers
{
    [ApiController]
    [Route("Empleado")]
    public class EmpleadoController: ControllerBase
    {
        private readonly ILogger<EmpleadoController> _logger;
        private EmpleadoManager _manager;

        public EmpleadoController(ILogger<EmpleadoController> logger)
        {
            _logger = logger;
            _manager = new EmpleadoManager();
        }

        [HttpPost]
        public IActionResult Post(Empleado empleado)
        {
            return Ok(_manager.crearEmpleado(empleado));
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
           return Ok(_manager.getEmpleado(id));
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_manager.getEmpleados());
        }
    }
}
