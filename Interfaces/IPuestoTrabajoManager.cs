using GestionCapitalHumano.Models;

namespace GestionCapitalHumano.Interfaces
{
    public interface IPuestoTrabajoManager
    {
        List<PuestoTrabajo> GetAllPuestos();
        PuestoTrabajo crearPuesto(PuestoTrabajo puesto);
        PuestoTrabajo deletePuesto(PuestoTrabajo puesto);
        PuestoTrabajo editarPuesto(PuestoTrabajo puesto);
        PuestoTrabajo getPuesto(int id);
    }
}
