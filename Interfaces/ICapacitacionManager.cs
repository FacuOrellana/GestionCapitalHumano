using GestionCapitalHumano.DTOs;
using GestionCapitalHumano.Models;

namespace GestionCapitalHumano.Interfaces
{
    public interface ICapacitacionManager
    {
        List<Capacitacion> GetCapacitaciones();

        Capacitacion GetCapacitacion(int id);

        bool deleteCapacitacion(int id);

        Capacitacion editCapacitacion(int id, CapacitacionDTO capacitacion);

        Capacitacion crearCapacitacion(CapacitacionDTO capacitacion);
    }
}
