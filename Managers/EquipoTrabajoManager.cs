using GestionCapitalHumano.Interfaces;
using GestionCapitalHumano.Models;

namespace GestionCapitalHumano.Managers
{
    public class EquipoTrabajoManager: IEquipoTrabajoManager
    {
        public List<EquipoTrabajo> GetAllEquipoTrabajo()
        {
            using (var context = new CapitalHumanoContext())
            {
                return context.EquipoTrabajos.Where(e => e.Is_Deleted == false).ToList();
            }
        }
    }
}
