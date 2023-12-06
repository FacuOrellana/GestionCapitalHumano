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

        public Contrato editarContrato(int id, Contrato contrato)
        {
            var context = new CapitalHumanoContext();
            var contratoExistente = context.Contratos.FirstOrDefault(e=>e.IdContrato == id);
            if(contratoExistente != null)
            {
                contratoExistente.Sueldo = contrato.Sueldo;
                contratoExistente.Seniority = contrato.Seniority;
                contratoExistente.FechaFin = contrato.FechaFin;
                context.SaveChanges();
                return contratoExistente;
            }
            else
            {
                return null;
            }
        }

        public bool deleteContrato(int id)
        {
            var context = new CapitalHumanoContext();
            var contratoExistente = (context.Contratos.FirstOrDefault(e=>e.IdContrato==id));
            if(contratoExistente != null)
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
