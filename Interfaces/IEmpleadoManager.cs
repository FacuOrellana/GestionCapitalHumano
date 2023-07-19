using GestionCapitalHumano.Models;

namespace GestionCapitalHumano.Interfaces
{
    public interface IEmpleadoManager
    {
        public List<Empleado> getEmpleados();

        public Empleado crearEmpleado(Empleado empleado);

        public Empleado getEmpleado(int id);

    }
}
