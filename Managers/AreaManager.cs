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
                return context.Areas.Where(e=> e.Is_Deleted == false).ToList();
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

        public Area editArea(int id, Area area)
        {
            using(var context = new CapitalHumanoContext())
            {
                try
                {
                    var areaExistente = context.Areas.FirstOrDefault(a => a.IdArea == id);
                    if (areaExistente != null)
                    {
                        areaExistente.Descripcion = area.Descripcion;
                        context.SaveChanges();
                        return areaExistente;
                    }
                }catch(Exception ex)
                {

                }
            }
        }

        public bool deleteArea(int id)
        {
            using var context = new CapitalHumanoContext();
            var areaExistente = context.Areas.FirstOrDefault(e => e.IdArea == id);
            if (areaExistente != null)
            {
                areaExistente.Is_Deleted = true;
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
