using System;
using System.Collections.Generic;

namespace GestionCapitalHumano.Models;

public partial class EmpleadoHabilidad
{
    public int IdEmpleadoHabilidad { get; set; }

    public int? IdEmpleado { get; set; }

    public int? IdHabilidad { get; set; }

    public bool Is_Deleted { get; set; }
    public virtual Empleado? IdEmpleadoNavigation { get; set; }

    public virtual Habilidad? IdHabilidadNavigation { get; set; }
}
