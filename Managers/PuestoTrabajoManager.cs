using GestionCapitalHumano.Interfaces;
using GestionCapitalHumano.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace GestionCapitalHumano.Managers
{
    public class PuestoTrabajoManager: IPuestoTrabajoManager
    {
        public List<PuestoTrabajo> GetAllPuestos()
        {
            using (var context = new CapitalHumanoContext())
            {
                return context.PuestoTrabajos.ToList();
            }
        }
        public PuestoTrabajo crearPuesto(PuestoTrabajo puesto)
        {
            using var context = new CapitalHumanoContext();
            EntityEntry<PuestoTrabajo> entityEntry = context.PuestoTrabajos.Add(puesto);
            context.SaveChanges();
            return entityEntry.Entity;
        }

        public PuestoTrabajo deletePuesto(PuestoTrabajo puesto)
        {
            using var context = new CapitalHumanoContext();
            EntityEntry<PuestoTrabajo> entityEntry = context.PuestoTrabajos.Add(puesto);
            context.SaveChanges();
            return entityEntry.Entity;
        }
        public PuestoTrabajo editarPuesto(PuestoTrabajo puesto)
        {
            using var context = new CapitalHumanoContext();
            EntityEntry<PuestoTrabajo> entityEntry = context.PuestoTrabajos.Add(puesto);
            context.SaveChanges();
            return entityEntry.Entity;
        }

        public PuestoTrabajo getPuesto(int id)
        {
            using (var context = new CapitalHumanoContext())
            {
                var puesto = context.PuestoTrabajos.
                    FirstOrDefault(e => e.IdPuestoTrabajo == id);
                if (puesto == null)
                {
                    return null; // Aquí devuelve null en lugar de NotFound() ya que NotFound() no es aplicable en un método que no es un controlador de ASP.NET Core.
                }
                return puesto;
            }
        }
    }
}
