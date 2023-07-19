using GestionCapitalHumano.Models;

namespace GestionCapitalHumano.Interfaces
{
    public interface IContratoManager
    {
        List<Contrato> GetAllContratos();

        List<Contrato> GetContratosById(int id);
    }
}
