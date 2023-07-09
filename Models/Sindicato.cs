using System;
using System.Collections.Generic;

namespace GestionCapitalHumano.Models;

public partial class Sindicato
{
    public string? Descripcion { get; set; }

    public decimal? Aporte { get; set; }

    public int IdSindicato { get; set; }

    public int? IdEmpleado { get; set; }
}
