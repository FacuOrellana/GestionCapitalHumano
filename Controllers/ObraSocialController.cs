using GestionCapitalHumano.DTOs;
using GestionCapitalHumano.Interfaces;
using GestionCapitalHumano.Managers;
using GestionCapitalHumano.Models;
using Microsoft.AspNetCore.Mvc;


namespace GestionCapitalHumano.Controllers
{
    [ApiController]
    [Route("/api")]
    public class ObraSocialController : Controller
    {
        private readonly IObraSocialManager _obraSocialManager;
        public ObraSocialController(IObraSocialManager obrasmanager)
        {
            _obraSocialManager = obrasmanager;
        }
        [HttpPost("obrasocial")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Post(ObraSocialDTO    obraSocial)
        {
            return Ok(_obraSocialManager.crearObraSocial(obraSocial));
        }

        [HttpPut("obrasocial")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Put(int id,ObraSocialDTO obraSocial)
        {
            return Ok(_obraSocialManager.editObraSocial(id,obraSocial));
        }

        [HttpDelete("obrasocial")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Delete(int id)
        {
            return Ok(_obraSocialManager.deleteObraSocial(id));
        }
    }
}
