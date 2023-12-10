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
                return context.PuestoTrabajos.Where(e=> !e.Is_Deleted).ToList();
            }
        }
        public PuestoTrabajo crearPuesto(PuestoTrabajo puesto)
        {
            using var context = new CapitalHumanoContext();
            try
            {
                PuestoTrabajo puesto = new PuestoTrabajo
                {
                    Descripcion = puestoDTO.Descripcion,
                    Nombre = puestoDTO.Nombre,
                    Is_Deleted = false
                };
                EntityEntry<PuestoTrabajo> entityEntry = context.PuestoTrabajos.Add(puesto);
                context.SaveChanges();
                return entityEntry.Entity;
            }catch (Exception ex)
            {
                Console.WriteLine($"Error al crear Puesto Trabajo " + ex.Message);
                throw;
            }            
        }

        public bool deletePuesto(int id)
        {
            using var context = new CapitalHumanoContext();
            var puestoExistente = context.PuestoTrabajos.FirstOrDefault(e => e.IdPuestoTrabajo == id); 
            if (puestoExistente != null)
            {
                puestoExistente.Is_Deleted = true;
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public PuestoTrabajo editarPuesto(int id, PuestoTrabajo puesto)
        {
            using var context = new CapitalHumanoContext();
            var puestoExistente = context.PuestoTrabajos.FirstOrDefault(e => e.IdPuestoTrabajo == id);
            if(puestoExistente != null)
            {
                puestoExistente.Descripcion = puesto.Descripcion;
                puestoExistente.Nombre = puesto.Nombre;
                puestoExistente.Is_Deleted = puesto.Is_Deleted;
                context.SaveChanges();
            }
            return puestoExistente;
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
