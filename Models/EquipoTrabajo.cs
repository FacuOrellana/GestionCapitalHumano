using System;
using System.Collections.Generic;

namespace GestionCapitalHumano.Models;

public partial class EquipoTrabajo
{
    public int IdEquipoTrabajo { get; set; }

    public string? Descripcion { get; set; }

    public int? DepartamentoIdDepartamento { get; set; }
    public virtual Departamento Departamento { get; set; }
    public bool Is_Deleted { get; set; }
}
