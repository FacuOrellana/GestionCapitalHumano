using GestionCapitalHumano.DTOs;
using GestionCapitalHumano.Models;

namespace GestionCapitalHumano.Interfaces
{
    public interface IPuestoTrabajoManager
    {
        List<PuestoTrabajo> GetAllPuestos();
        PuestoTrabajo crearPuesto(PuestoTrabajoDTO puesto);
        bool deletePuesto(int id);
        PuestoTrabajo editarPuesto(int id, PuestoTrabajoDTO puesto);
        PuestoTrabajo getPuesto(int id);
    }
}
