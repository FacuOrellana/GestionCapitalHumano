using GestionCapitalHumano.Models;

namespace GestionCapitalHumano.Interfaces
{
    public interface IAreasManager
    {
        List<Area> GetAllAreas();

        public void crearArea(string descripcion);
    }
}
