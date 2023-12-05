using GestionCapitalHumano.Interfaces;
using GestionCapitalHumano.Models;

namespace GestionCapitalHumano.Managers
{
    public class EquipoTrabajoManager: IEquipoTrabajoManager
    {
        public EquipoTrabajo crearEquipoTrabajo(EquipoTrabajo equipoTrabajo)
        {
            var context = new CapitalHumanoContext();
            context.EquipoTrabajos.Add(equipoTrabajo);
            context.SaveChanges();
            return equipoTrabajo;
        }

        public bool deleteEquipoTrabajo(int id)
        {
            var context = new CapitalHumanoContext();
            var equipoExistente = context.EquipoTrabajos.FirstOrDefault(e=>e.IdEquipoTrabajo==id);
            if(equipoExistente != null)
            {
                equipoExistente.Is_Deleted = true;
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public EquipoTrabajo editarEquipoTrabajo(int id, EquipoTrabajo equipoTrabajo)
        {
            var context = new CapitalHumanoContext();
            var equipoExistente = context.EquipoTrabajos.FirstOrDefault(e => e.IdEquipoTrabajo == id);
            if(equipoExistente != null)
            {
                equipoExistente.Descripcion = equipoTrabajo.Descripcion;
                equipoExistente.Is_Deleted = equipoTrabajo.Is_Deleted;
                context.SaveChanges();
                return equipoExistente;
            }
            return null;
        }

        public List<EquipoTrabajo> GetAllEquipoTrabajo()
        {
            using (var context = new CapitalHumanoContext())
            {
                return context.EquipoTrabajos.Where(e => e.Is_Deleted == false).ToList();
            }
        }


    }
}
