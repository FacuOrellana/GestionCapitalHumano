using GestionCapitalHumano.DTOs;
using GestionCapitalHumano.Models;

namespace GestionCapitalHumano.Interfaces
{
    public interface IAreasManager
    {
        List<Area> GetAllAreas();

        public void crearArea(string descripcion);

        public Area getArea(int id);

        public Area editArea(int id, AreaDTO area);   
        public bool deleteArea(int id);
    }
}
