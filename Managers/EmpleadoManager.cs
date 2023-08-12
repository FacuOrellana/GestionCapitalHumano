using GestionCapitalHumano.Interfaces;
using GestionCapitalHumano.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace GestionCapitalHumano.Managers
{
    public class EmpleadoManager : IEmpleadoManager
    {
        public List<Empleado> getEmpleados()
        {
            using var context = new CapitalHumanoContext();
            return context.Empleados.
                Include(e => e.ObraSocial).
                Include(e => e.Contrato).
                Include(e => e.Sindicato).
                Include(e => e.PuestoTrabajo).
                Include(e => e.EquipoTrabajo).ToList(); ;
        }

        public Empleado crearEmpleado(Empleado empleado)
        {
            using var context = new CapitalHumanoContext();
            EntityEntry<Empleado> entityEntry = context.Empleados.Add(empleado);
            context.SaveChanges();
            return entityEntry.Entity;
        }

        public Empleado getEmpleado(int id)
        {
            using (var context = new CapitalHumanoContext())
            {
                var empleado = context.Empleados.
                    Include(e => e.ObraSocial).
                    Include(e => e.Contrato).
                    Include(e => e.Sindicato).
                    Include(e => e.PuestoTrabajo).
                    Include(e => e.EquipoTrabajo).
                    FirstOrDefault(e => e.IdEmpleado == id);
                if (empleado == null)
                {
                    return null; // Aquí devuelve null en lugar de NotFound() ya que NotFound() no es aplicable en un método que no es un controlador de ASP.NET Core.
                }

                return empleado;
            }
        }

    }
}
