using GestionCapitalHumano.Models;

namespace GestionCapitalHumano.Interfaces
{
    public interface IPuestoTrabajoManager
    {
        List<PuestoTrabajo> GetAllPuestos();
        PuestoTrabajo crearPuesto(PuestoTrabajo puesto);
        bool deletePuesto(int id);
        PuestoTrabajo editarPuesto(int id, PuestoTrabajo puesto);
        PuestoTrabajo getPuesto(int id);
    }
}
