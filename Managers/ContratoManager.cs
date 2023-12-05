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
                Where(c=> c.Is_Deleted == false).ToList();
            return contratos;
        }
        public List<Contrato> GetContratosById(int id)
        {
            using (var context = new CapitalHumanoContext())
            {
                return context.Contratos.
                    Where(c => c.Empleado.IdEmpleado == id).ToList();
            }
        }

        public Contrato CrearContrato(DateTime fechainicio, DateTime fechafin, decimal sueldo, string seniority, Empleado Empleado)
        {
            using (var context = new CapitalHumanoContext())
            {
                var createdContrato = new Contrato
                {
                    FechaFin = fechafin,
                    FechaInicio = fechainicio,
                    Empleado = Empleado,
                    Seniority = seniority,
                    Sueldo = sueldo
                };
                context.Contratos.Add(createdContrato);
                context.SaveChanges();
                return createdContrato;
            }
        }
    }
}
