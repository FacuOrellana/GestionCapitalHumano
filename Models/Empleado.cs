using System;
using System.Collections.Generic;

namespace GestionCapitalHumano.Models;

public partial class Empleado
{
    public int IdEmpleado { get; set; }
    public string Nombre { get; set; }

    public string Apellido { get; set; }

    public int Legajo { get; set; }
    public int Dni { get; set; }
    public string Celular { get; set; }

    public DateTime FechaNacimiento { get; set; }

    public string Direccion { get; set; }

    public string Ciudad { get; set; }

    public virtual ObraSocial ObraSocial { get; set; }
    public virtual Sindicato Sindicato { get; set; }
    public virtual PuestoTrabajo PuestoTrabajo { get; set; }
    public virtual EquipoTrabajo EquipoTrabajo { get; set; }

    public virtual ICollection<Asistencia> Asistencia { get; set; } = new List<Asistencia>();

    public virtual ICollection<EmpleadoCapacitacion> EmpleadoCapacitacions { get; set; } = new List<EmpleadoCapacitacion>();

    public virtual ICollection<EmpleadoHabilidad> EmpleadoHabilidads { get; set; } = new List<EmpleadoHabilidad>();
}
