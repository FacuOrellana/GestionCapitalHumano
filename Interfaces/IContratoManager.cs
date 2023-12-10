using GestionCapitalHumano.DTOs;
using GestionCapitalHumano.Models;

namespace GestionCapitalHumano.Interfaces
{
    public interface IContratoManager
    {
        List<Contrato> GetAllContratos();
        Contrato GetContratoById(int id);
        Contrato CrearContrato(DateTime fechainicio, DateTime fechafin, decimal sueldo, string seniority, int Empleado);
        Contrato editarContrato(int id, ContratoDTO contrato);
        bool deleteContrato(int id);
    }
}
