using System;
using System.Collections.Generic;

namespace GestionCapitalHumano.Models;

public class Contrato
{
    public int IdContrato { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime FechaFin { get; set; }

    public decimal Sueldo { get; set; }

    public string Seniority { get; set; }

    public bool Is_Deleted { get; set; }

    public virtual Empleado Empleado { get; set; }
}
