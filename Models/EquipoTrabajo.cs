using System;
using System.Collections.Generic;

namespace GestionCapitalHumano.Models;

public partial class EquipoTrabajo
{
    public int IdEquipoTrabajo { get; set; }

    public string? Descripcion { get; set; }

    public int? IdDepartamento { get; set; }
}
