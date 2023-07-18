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

        public EmpleadoController(ILogger<EmpleadoController> logger, EmpleadoService _empleadoService)
        {
            _logger = logger;
            _service = _empleadoService;
        }

        //[HttpPost(Name = "PostEmpleado")]
        //public Empleado Post(Empleado empleado)
        //{
        //    return _service.crearEmpleado(empleado);
        //}

        [HttpGet(Name = "GetEmpleados")]
        public IEnumerable<Empleado> Get()
        {
            return new List<Empleado>().ToArray();
        }
    }
}
