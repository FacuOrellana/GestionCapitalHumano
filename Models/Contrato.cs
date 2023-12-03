using System;
using System.Collections.Generic;

namespace GestionCapitalHumano.Models;

public partial class Contrato
{
    public int IdContrato { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime FechaFin { get; set; }

    public decimal Sueldo { get; set; }

    public string Seniority { get; set; }

    public int IdEmpleado { get; set; }
    public bool Is_Deleted { get; set; }
}
