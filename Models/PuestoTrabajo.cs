using System;
using System.Collections.Generic;

namespace GestionCapitalHumano.Models;

public partial class PuestoTrabajo
{
    public int IdPuestoTrabajo { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public bool Is_Deleted { get; set; }

}
