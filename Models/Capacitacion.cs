using System;
using System.Collections.Generic;

namespace GestionCapitalHumano.Models;

public partial class Capacitacion
{
    public int IdCapacitacion { get; set; }

    public string Descripcion { get; set; }

    public DateTime Fecha { get; set; }

    public int DuracionHoras { get; set; }

    public virtual ICollection<EmpleadoCapacitacion> EmpleadoCapacitaciones { get; set; } = new List<EmpleadoCapacitacion>();
}
