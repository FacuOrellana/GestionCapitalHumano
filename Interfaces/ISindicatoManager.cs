using GestionCapitalHumano.Models;

namespace GestionCapitalHumano.Interfaces
{
    public interface ISindicatoManager
    {
        List<Sindicato> GetAllSindicatos();
        Sindicato crearSindicato(Sindicato sindicato);
        Sindicato editarSindicato(int id, Sindicato sindicato);
        bool deleteSindicato(int id);
    }
}
