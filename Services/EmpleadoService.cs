using GestionCapitalHumano.Models;

namespace GestionCapitalHumano.Services
{
    public class EmpleadoService
    {

        private CapitalHumanoContext _context;

        public EmpleadoService(CapitalHumanoContext capitalHumanoContext)
        {
            _context = capitalHumanoContext;
        }

        public Empleado crearEmpleado(Empleado empleado)
        {
            //new method
            return _context.Empleados.Add(empleado);

        }



    }
}
