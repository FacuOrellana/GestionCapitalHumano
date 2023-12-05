using GestionCapitalHumano.Models;

namespace GestionCapitalHumano.Interfaces
{
    public interface IAreasManager
    {
        List<Area> GetAllAreas();

        public void crearArea(string descripcion);

        public Area getArea(int id);

        public Area editArea(int id, Area area);   
        public bool deleteArea(int id);
    }
}
