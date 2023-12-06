using GestionCapitalHumano.DTOs;
using GestionCapitalHumano.Interfaces;
using GestionCapitalHumano.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace GestionCapitalHumano.Managers
{
    public class EmpleadoManager : IEmpleadoManager
    {
        public List<Empleado> getEmpleados()
        {
            using var context = new CapitalHumanoContext();
            return context.Empleados.
                Include(e => e.ObraSocial).
                Include(e => e.Sindicato).
                Include(e => e.PuestoTrabajo).
                Include(e => e.EquipoTrabajo).
                Where(e => e.Is_Deleted == false).ToList(); 
        }

        public Empleado crearEmpleado(EmpleadoDTO empleadoDTO)
        {
            using (var context = new CapitalHumanoContext())
            {
                try
                {
                    // Mapear los datos de EmpleadoDTO a Empleado
                    Empleado empleado = new Empleado
                    {
                        Nombre = empleadoDTO.Nombre,
                        Apellido = empleadoDTO.Apellido,
                        Legajo = empleadoDTO.Legajo,
                        Dni = empleadoDTO.Dni,
                        Celular = empleadoDTO.Celular,
                        FechaNacimiento = empleadoDTO.FechaNacimiento,
                        Direccion = empleadoDTO.Direccion,
                        Ciudad = empleadoDTO.Ciudad,
                        ObrasocialIdObraSocial = empleadoDTO.IdObraSocial,
                        SindicatoIdSindicato = empleadoDTO.IdSindicato,
                        PuestoTrabajoIdPuestoTrabajo = empleadoDTO.IdPuestoTrabajo,
                        EquipoTrabajoIdEquipoTrabajo = empleadoDTO.IdEquipoTrabajo
                    };

                    // Agregar el empleado a la base de datos
                    EntityEntry<Empleado> entityEntry = context.Empleados.Add(empleado);
                    context.SaveChanges();

                    return entityEntry.Entity;
                }
                catch (Exception ex)
                {
                    // Manejar la excepción según tus necesidades
                    Console.WriteLine($"Error al crear empleado: {ex.Message}");
                    throw; // Puedes manejar la excepción aquí o relanzarla para que la capa superior la maneje
                }
            }
        }
        public Empleado editarEmpleado(EmpleadoDTO empleadoDTO, int id)
        {
            using (var context = new CapitalHumanoContext())
            {
                try
                {
                    // Buscar el empleado existente por su Id
                    Empleado empleadoExistente = context.Empleados.Find(id);

                    if (empleadoExistente != null)
                    {
                        // Actualizar las propiedades del empleado con los valores proporcionados en empleadoDTO
                        empleadoExistente.Nombre = empleadoDTO.Nombre;
                        empleadoExistente.Apellido = empleadoDTO.Apellido;
                        empleadoExistente.Legajo = empleadoDTO.Legajo;
                        empleadoExistente.Dni = empleadoDTO.Dni;
                        empleadoExistente.Celular = empleadoDTO.Celular;
                        empleadoExistente.FechaNacimiento = empleadoDTO.FechaNacimiento;
                        empleadoExistente.Direccion = empleadoDTO.Direccion;
                        empleadoExistente.Ciudad = empleadoDTO.Ciudad;
                        empleadoExistente.ObrasocialIdObraSocial = empleadoDTO.IdObraSocial;
                        empleadoExistente.SindicatoIdSindicato = empleadoDTO.IdSindicato;
                        empleadoExistente.PuestoTrabajoIdPuestoTrabajo = empleadoDTO.IdPuestoTrabajo;
                        empleadoExistente.EquipoTrabajoIdEquipoTrabajo = empleadoDTO.IdEquipoTrabajo;

                        // Guardar los cambios en la base de datos
                        context.SaveChanges();

                        return empleadoExistente;
                    }
                    else
                    {
                        // Manejar el caso en que no se encuentre el empleado
                        Console.WriteLine($"No se encontró el empleado con Id {id}");
                        return null; // Puedes manejarlo devolviendo null u otro valor según tus necesidades
                    }
                }
                catch (Exception ex)
                {
                    // Manejar la excepción según tus necesidades
                    Console.WriteLine($"Error al editar empleado: {ex.Message}");
                    throw; // Puedes manejar la excepción aquí o relanzarla para que la capa superior la maneje
                }
            }
        }

        public Empleado getEmpleado(int id)
        {
            using (var context = new CapitalHumanoContext())
            {
                var empleado = context.Empleados.
                    Include(e => e.ObraSocial).
                    Include(e => e.Sindicato).
                    Include(e => e.PuestoTrabajo).
                    Include(e => e.EquipoTrabajo).
                    FirstOrDefault(e => e.IdEmpleado == id);
                if (empleado == null)
                {
                    return null; // Aquí devuelve null en lugar de NotFound() ya que NotFound() no es aplicable en un método que no es un controlador de ASP.NET Core.
                }

                return empleado;
            }
        }
     

    }
}
