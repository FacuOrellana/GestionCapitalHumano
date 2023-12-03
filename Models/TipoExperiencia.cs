using System;
using System.Collections.Generic;

namespace GestionCapitalHumano.Models;

public partial class TipoExperiencia
{
    public int IdTipoExperiencia { get; set; }

    public string? Descripcion { get; set; }
    public bool Is_Deleted { get; set; }
}
