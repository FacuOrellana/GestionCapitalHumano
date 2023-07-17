using System;
using System.Collections.Generic;

namespace GestionCapitalHumano.Models;

public partial class Asistencia
{
    public int IdAsistencia { get; set; }

    public DateTime Fecha { get; set; }

    public DateTime HoraEntrada { get; set; }

    public DateTime HoraSalida { get; set; }

    public int IdEmpleado { get; set; }

    public virtual Empleado IdEmpleadoNavigation { get; set; }
}
