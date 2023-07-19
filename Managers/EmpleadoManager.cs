﻿using GestionCapitalHumano.Interfaces;
using GestionCapitalHumano.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace GestionCapitalHumano.Managers
{
    public class EmpleadoManager : IEmpleadoManager
    {
        public List<Empleado> getEmpleados()
        {
            using var context = new CapitalHumanoContext();
            return context.Empleados.ToList();
        }

        public Empleado crearEmpleado(Empleado empleado)
        {
            using var context = new CapitalHumanoContext();
            EntityEntry<Empleado> entityEntry = context.Empleados.Add(empleado);
            context.SaveChanges();
            return entityEntry.Entity;
        }

        public Empleado getEmpleado(int id)
        {
            using (var context = new CapitalHumanoContext())
            {
                var empleado = context.Empleados.Find(id);
                if (empleado == null)
                {
                    return null; // Aquí devuelve null en lugar de NotFound() ya que NotFound() no es aplicable en un método que no es un controlador de ASP.NET Core.
                }

                return empleado;
            }
        }

    }
}