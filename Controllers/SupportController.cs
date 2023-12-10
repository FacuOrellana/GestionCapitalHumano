using GestionCapitalHumano.Interfaces;
using GestionCapitalHumano.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestionCapitalHumano.Controllers
{
    [ApiController]
    [Route("/api")]
    public class SupportController : Controller
    {
        private readonly IAreasManager _areasManager;
        private readonly IObraSocialManager _obraSocialManager;
        private readonly IEquipoTrabajoManager _equipoTrabajoManager;
        private readonly ISindicatoManager _sindicatoManager;
        private readonly IPuestoTrabajoManager _puestoTrabajoManager;
        private readonly IDepartamentoManager _departamentoManager;

        public SupportController(
            IAreasManager areasManager,
            IObraSocialManager obraSocialManager,
            IEquipoTrabajoManager equipoTrabajoManager,
            ISindicatoManager sindicatoManager,
            IPuestoTrabajoManager puestoTrabajoManager,
            IDepartamentoManager departamentoManager
            )
        {
            _departamentoManager = departamentoManager;
            _areasManager = areasManager;
            _obraSocialManager = obraSocialManager;
            _equipoTrabajoManager = equipoTrabajoManager;
            _sindicatoManager = sindicatoManager;
            _puestoTrabajoManager = puestoTrabajoManager;
        }

        /// <summary>
        /// Get all Areas
        /// </summary>
        /// <returns></returns>
        [HttpGet("areas")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public ActionResult<List<Area>> GetAllAreas()
        {
            var areas = _areasManager.GetAllAreas();
            return areas;

        }

        /// <summary>
        /// Get all Obra Social
        /// </summary>
        /// <returns></returns>
        [HttpGet("obraSociales")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public ActionResult<List<ObraSocial>> GetAllObraSocial()
        {
            var obras = _obraSocialManager.GetAllObraSocial();
            return obras;

        }

        /// <summary>
        /// Get all Equipo de trabajo 
        /// </summary>
        /// <returns></returns>
        [HttpGet("equipos")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public ActionResult<List<EquipoTrabajo>> GetAllEquipoTrabajo()
        {
            var equipos = _equipoTrabajoManager.GetAllEquipoTrabajo();
            return equipos;

        }

        /// <summary>
        /// Get all Sindicatos 
        /// </summary>
        /// <returns></returns>
        [HttpGet("sindicatos")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public ActionResult<List<Sindicato>> GetAllSindicatos()
        {
            var sindicatos = _sindicatoManager.GetAllSindicatos();
            return sindicatos;

        }

        /// <summary>
        /// Get all puestos de trabajo 
        /// </summary>
        /// <returns></returns>
        [HttpGet("puestos")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public ActionResult<List<PuestoTrabajo>> GetAllPuestos()
        {
            var puestos = _puestoTrabajoManager.GetAllPuestos();
            return puestos;

        }

        /// <summary>
        /// Get all departamentos 
        /// </summary>
        /// <returns></returns>
        [HttpGet("departamentos")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public ActionResult<List<Departamento>> GetAllDepartamentos()
        {
            var departamentos = _departamentoManager.GetAllDepartamentos();
            return departamentos;

        }

    }
}
