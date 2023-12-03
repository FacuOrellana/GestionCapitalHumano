using GestionCapitalHumano.Interfaces;
using GestionCapitalHumano.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionCapitalHumano.Managers
{
    public class AreaManager: IAreasManager
    {
        public List<Area> GetAllAreas()
        {
            using (var context = new CapitalHumanoContext())
            {
                return context.Areas.ToList();
            }
        }
        public void crearArea(string descripcion) 
        {
            using (var context = new CapitalHumanoContext())
            {
               var area = context.Areas.Add(new Area { Descripcion = descripcion });
                context.SaveChanges();
            }
        }

        public Area getArea(int id)
        {
            using (var context = new CapitalHumanoContext())
            {
                var area = context.Areas.
                    FirstOrDefault(a => a.IdArea == id);
                if (area == null)
                {
                    return null; // Aquí devuelve null en lugar de NotFound() ya que NotFound() no es aplicable en un método que no es un controlador de ASP.NET Core.
                }

                return area;
            }
        }
    }
}
