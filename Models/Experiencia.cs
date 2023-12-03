using System;
using System.Collections.Generic;

namespace GestionCapitalHumano.Models;

public partial class Experiencia
{
    public int IdExperiencia { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public TimeSpan? Duracion { get; set; }

    public int? IdEmpleado { get; set; }

    public int? IdTipoExperiencia { get; set; }
    public bool Is_Deleted { get; set; }
}
