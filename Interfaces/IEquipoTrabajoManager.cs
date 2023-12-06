using GestionCapitalHumano.DTOs;
using GestionCapitalHumano.Models;

namespace GestionCapitalHumano.Interfaces
{
    public interface IEquipoTrabajoManager
    {
        List<EquipoTrabajo> GetAllEquipoTrabajo();
        EquipoTrabajo crearEquipoTrabajo(EquipoTrabajoDTO equipoTrabajo);
        EquipoTrabajo editarEquipoTrabajo(int id, EquipoTrabajoDTO equipoTrabajo) ;
        bool deleteEquipoTrabajo(int id);
    }
}
