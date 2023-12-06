using GestionCapitalHumano.Models;

namespace GestionCapitalHumano.Interfaces
{
    public interface IEquipoTrabajoManager
    {
        List<EquipoTrabajo> GetAllEquipoTrabajo();
        EquipoTrabajo crearEquipoTrabajo(EquipoTrabajo equipoTrabajo);
        EquipoTrabajo editarEquipoTrabajo(int id, EquipoTrabajo equipoTrabajo) ;
        bool deleteEquipoTrabajo(int id);
    }
}
