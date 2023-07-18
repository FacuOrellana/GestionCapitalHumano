using GestionCapitalHumano.Interfaces;
using GestionCapitalHumano.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestionCapitalHumano.Controllers
{
    [ApiController]
    [Route("/api")]
    public class AreaController
    {
        private readonly IAreasManager _areasManager;

        public AreaController(IAreasManager areasManager)
        {
            _areasManager = areasManager;
        }


        [HttpGet("areas")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public ActionResult<List<Area>> GetAllAreas()
        { 
            var areas = _areasManager.GetAllAreas();
            return areas;

        }
    }
}
