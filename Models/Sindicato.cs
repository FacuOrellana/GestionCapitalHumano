using System;
using System.Collections.Generic;

namespace GestionCapitalHumano.Models;

public partial class Sindicato
{
    public int IdSindicato { get; set; }

    public string? Descripcion { get; set; }

    public decimal? Aporte { get; set; }

    public bool Is_Deleted { get; set; }
}
