using GestionCapitalHumano.DTOs;
using GestionCapitalHumano.Models;

namespace GestionCapitalHumano.Interfaces
{
    public interface IEmpleadoManager
    {
        public List<Empleado> getEmpleados();

        public String crearEmpleado(EmpleadoDTO empleado);
        public void deleteEmpleado(int id);

        public Empleado getEmpleado(int id);
        public String editarEmpleado(EmpleadoDTO empleado, int id);

    }
}
