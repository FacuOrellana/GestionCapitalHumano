using GestionCapitalHumano.DTOs;
using GestionCapitalHumano.Interfaces;
using GestionCapitalHumano.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestionCapitalHumano.Controllers
{
    [ApiController]
    [Route("/api")]
    public class ContratoController : Controller
    {
        private readonly IContratoManager _contratoManager;

        public ContratoController(IContratoManager contratoManager)
        {
            _contratoManager = contratoManager;
        }


        [HttpGet("contratos")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public ActionResult<List<Contrato>> GetAllContratos()
        {
            var contratos = _contratoManager.GetAllContratos();
            return contratos;

        }

        [HttpGet("contratos/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public ActionResult<List<Contrato>> GetContratosById(int Id)
        {
            var contratos = _contratoManager.GetContratosById(Id);
            return contratos;

        }

        /// <summary>
        /// Create a new contrato
        /// </summary>
        /// <param name="contrato"></param>
        /// <returns></returns>

        [HttpPost("contratos")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Contrato> crearContrato([FromBody] ContratoDTO contrato)
        {
            var createdContrato = _contratoManager.CrearContrato(contrato.FechaInicio,contrato.FechaFin,contrato.Sueldo,contrato.Seniority,contrato.IdEmpleado);
            return createdContrato;

        }

    }
}
