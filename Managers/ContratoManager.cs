using GestionCapitalHumano.DTOs;
using GestionCapitalHumano.Interfaces;
using GestionCapitalHumano.Models;
using System.Diagnostics.Contracts;

namespace GestionCapitalHumano.Managers
{
    public class ContratoManager : IContratoManager
    {
        public List<Contrato> GetAllContratos()
        {
            using (var context = new CapitalHumanoContext())
            {
                return context.Contratos.ToList();
            }
        }
        public List<Contrato> GetContratosById(int id)
        {
            using (var context = new CapitalHumanoContext())
            {
                return context.Contratos.
                    Where(c=>c.IdEmpleado== id).ToList();
            }
        }

        public Contrato CrearContrato(DateTime fechainicio,DateTime fechafin,decimal sueldo, string seniority, int idEmpleado)
        {
            using (var context = new CapitalHumanoContext())
            {
                var createdContrato= new Contrato
                {
                    FechaFin = fechafin,
                    FechaInicio = fechainicio,
                    IdEmpleado = idEmpleado,
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
