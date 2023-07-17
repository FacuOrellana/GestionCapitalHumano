using System;
using System.Collections.Generic;

namespace GestionCapitalHumano.Models;

public partial class Departamento
{
    public int IdDepartamento { get; set; }

    public string Descripcion { get; set; }

    public int IdArea { get; set; }
}
