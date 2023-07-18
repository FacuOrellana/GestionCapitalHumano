using GestionCapitalHumano.Interfaces;
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
    }
}
