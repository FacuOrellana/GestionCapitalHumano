using GestionCapitalHumano.Models;

namespace GestionCapitalHumano.DTOs
{
    public class EmpleadoDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Apellido { get; set; }
         
        public int Legajo { get; set; }
        public int Dni { get; set; }
        public string Celular { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string Direccion { get; set; }

        public string Ciudad { get; set; }

        public int IdObraSocial  { get; set; }
        public int IdSindicato  { get; set; }
        public int IdPuestoTrabajo { get; set; }
        public int  IdEquipoTrabajo { get; set; }
    }
}
