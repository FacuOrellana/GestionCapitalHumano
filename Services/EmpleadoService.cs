using GestionCapitalHumano.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace GestionCapitalHumano.Services
{
    public class EmpleadoService
    {

        private CapitalHumanoContext _context;

        public EmpleadoService()
        {
            _context = new CapitalHumanoContext();
        }

        public Empleado crearEmpleado(Empleado empleado)
        {
            EntityEntry<Empleado> entityEntry = _context.Empleados.Add(empleado);
            _context.SaveChanges(); // Guardar los cambios en la base de datos.
            return entityEntry.Entity;
        }

        }



    }
}
