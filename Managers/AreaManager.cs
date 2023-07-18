using GestionCapitalHumano.Interfaces;
using GestionCapitalHumano.Models;

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
    }
}
