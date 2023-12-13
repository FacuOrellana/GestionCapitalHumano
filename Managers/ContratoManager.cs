using System.Diagnostics;
using GestionCapitalHumano.DTOs;
using GestionCapitalHumano.Interfaces;
using GestionCapitalHumano.Models;
using System.Diagnostics.Contracts;
using Microsoft.EntityFrameworkCore;

namespace GestionCapitalHumano.Managers
{
    public class ContratoManager : IContratoManager
    {
        public List<Contrato> GetAllContratos()
        {
            using var context = new CapitalHumanoContext();
            var contratos = context.Contratos.Include(c => c.Empleado).
                Where(c => c.Is_Deleted == false && c.Empleado.Is_Deleted == false).ToList();
            return contratos;
        }
        public Contrato GetContratoById(int id)
        {
            using (var context = new CapitalHumanoContext())
            {
                return context.Contratos.Include(c => c.Empleado).FirstOrDefault(c => c.IdContrato == id);
            }
        }

        public Contrato CrearContrato(DateTime fechainicio, DateTime fechafin, decimal sueldo, string seniority, int Empleado)
        {
            using (var context = new CapitalHumanoContext())
            {
                var createdContrato = new Contrato
                {
                    FechaFin = fechafin,
                    FechaInicio = fechainicio,
                    EmpleadoIdEmpleado = Empleado,
                    Seniority = seniority,
                    Sueldo = sueldo
                };
                context.Contratos.Add(createdContrato);
                context.SaveChanges();
                return createdContrato;
            }
        }

        public Contrato editarContrato(int id, ContratoDTO contrato)
        {
            var context = new CapitalHumanoContext();
            try
            {
                var contratoExistente = context.Contratos.FirstOrDefault(e => e.IdContrato == id);
                if (contratoExistente != null)
                {
                    contratoExistente.Sueldo = contrato.Sueldo;
                    contratoExistente.Seniority = contrato.Seniority;
                    contratoExistente.FechaFin = contrato.FechaFin;
                    context.SaveChanges();
                    return contratoExistente;
                }
                else
                {
                    Console.WriteLine($"No se encontró el contrato con Id {id}");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al editar Contrato: {ex.Message}");
                throw;
            }
        }

        public bool deleteContrato(int id)
        {
            var context = new CapitalHumanoContext();
            var contratoExistente = (context.Contratos.FirstOrDefault(e => e.IdContrato == id));
            if (contratoExistente != null)
            {
                contratoExistente.Is_Deleted = true;
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
