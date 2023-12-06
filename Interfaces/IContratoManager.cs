using GestionCapitalHumano.DTOs;
using GestionCapitalHumano.Models;

namespace GestionCapitalHumano.Interfaces
{
    public interface IContratoManager
    {
        List<Contrato> GetAllContratos();
        List<Contrato> GetContratosById(int id);
        Contrato CrearContrato(DateTime fechainicio, DateTime fechafin, decimal sueldo, string seniority, Empleado Empleado);
        Contrato editarContrato(int id, Contrato contrato);
        bool deleteContrato(int id);
    }
}
