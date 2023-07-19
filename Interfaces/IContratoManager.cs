using GestionCapitalHumano.DTOs;
using GestionCapitalHumano.Models;

namespace GestionCapitalHumano.Interfaces
{
    public interface IContratoManager
    {
        List<Contrato> GetAllContratos();
        List<Contrato> GetContratosById(int id);
        public Contrato CrearContrato(DateTime fechainicio, DateTime fechafin, decimal sueldo, string seniority, int idEmpleado);
    }
}
