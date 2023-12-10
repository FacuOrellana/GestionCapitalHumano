using GestionCapitalHumano.Models;

namespace GestionCapitalHumano.DTOs
{
    public struct ContratoDTO
    {
        public DateTime FechaInicio { get; set; }

        public DateTime ? FechaFin { get; set; }

        public decimal Sueldo { get; set; }

        public string Seniority { get; set; }

        public int idEmpleado{ get; set; }
    }
}
