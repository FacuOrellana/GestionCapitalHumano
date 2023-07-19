using GestionCapitalHumano.Interfaces;
using GestionCapitalHumano.Models;

namespace GestionCapitalHumano.Managers
{
    public class PuestoTrabajoManager: IPuestoTrabajoManager
    {
        public List<PuestoTrabajo> GetAllPuestos()
        {
            using (var context = new CapitalHumanoContext())
            {
                return context.PuestoTrabajos.ToList();
            }
        }
    }
}
