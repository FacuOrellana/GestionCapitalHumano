using GestionCapitalHumano.DTOs;
using GestionCapitalHumano.Interfaces;
using GestionCapitalHumano.Models;

namespace GestionCapitalHumano.Managers
{
    public class EquipoTrabajoManager: IEquipoTrabajoManager
    {
        public EquipoTrabajo crearEquipoTrabajo(EquipoTrabajoDTO equipoTrabajo)
        {
            using(var context = new CapitalHumanoContext())
            {
                try
                {
                    EquipoTrabajo equipo = new EquipoTrabajo
                    {
                        Descripcion = equipoTrabajo.Descripcion,
                        IdDepartamento = equipoTrabajo.IdDepartamento,
                        Is_Deleted = false,
                    };
                    context.EquipoTrabajos.Add(equipo);
                    context.SaveChanges();
                    return equipo;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al crear equipo de trabajo: {ex.Message}");
                    throw;
                }
            }
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

        public EquipoTrabajo editarEquipoTrabajo(int id, EquipoTrabajoDTO equipoTrabajo)
        {
            var context = new CapitalHumanoContext();
            var equipoExistente = context.EquipoTrabajos.FirstOrDefault(e => e.IdEquipoTrabajo == id);
            if(equipoExistente != null)
            {
                equipoExistente.Descripcion = equipoTrabajo.Descripcion;
                equipoExistente.IdDepartamento = equipoTrabajo.IdDepartamento;
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
