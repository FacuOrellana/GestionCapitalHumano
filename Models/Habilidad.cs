using System;
using System.Collections.Generic;

namespace GestionCapitalHumano.Models;

public partial class Habilidad
{
    public int IdHabilidad { get; set; }

    public string? Descripcion { get; set; }
    public bool Is_Deleted { get; set; }

    public virtual ICollection<EmpleadoHabilidad> EmpleadoHabilidads { get; set; } = new List<EmpleadoHabilidad>();
}
