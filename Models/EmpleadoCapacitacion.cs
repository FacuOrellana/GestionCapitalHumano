using System;
using System.Collections.Generic;

namespace GestionCapitalHumano.Models;

public partial class EmpleadoCapacitacion
{
    public int? IdEmpleado { get; set; }

    public int? IdCapacitacion { get; set; }

    public int IdEmpleadoCapacitacion { get; set; }

    public virtual Capacitacion? IdCapacitacionNavigation { get; set; }

    public virtual Empleado? IdEmpleadoNavigation { get; set; }
}
