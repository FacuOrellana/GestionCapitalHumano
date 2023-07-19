﻿using GestionCapitalHumano.DTOs;
using GestionCapitalHumano.Interfaces;
using GestionCapitalHumano.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestionCapitalHumano.Controllers
{
    [ApiController]
    [Route("/api")]
    public class AreaController : Controller
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

        ///<summary>
        /// Create a new area.
        /// </summary>
        /// <param name="descripcion"
        /// <returns>
        /// - 201, and information about the created area if the operation succeeded.
        /// - 400 if the request is incorrect.
        /// </returns>
        [HttpPost("areas")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<AreaDTO> createArea([FromBody] AreaDTO areaDTO)
        {
            if ( string.IsNullOrWhiteSpace(areaDTO.Descripcion))
            {
                return BadRequest("La descripción del área es requerida.");
            }

             _areasManager.crearArea(areaDTO.Descripcion);
            return CreatedAtAction(nameof(createArea), areaDTO.Descripcion);
        }
    }
}
