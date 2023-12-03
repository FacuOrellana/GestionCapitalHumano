using System;
using System.Collections.Generic;

namespace GestionCapitalHumano.Models;

public partial class Tarea
{
    public int IdTarea { get; set; }

    public string? Descripcion { get; set; }

    public int? IdPuestoTrabajo { get; set; }
    public bool Is_Deleted { get; set; }
}
