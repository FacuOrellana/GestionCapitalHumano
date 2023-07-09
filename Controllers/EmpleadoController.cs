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

        public EmpleadoController(ILogger<EmpleadoController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetEmpleados")]
        public IEnumerable<Empleado> Get()
        {
            return new List<Empleado>().ToArray();
        }
    }
}
