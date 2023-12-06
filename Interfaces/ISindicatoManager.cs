using GestionCapitalHumano.DTOs;
using GestionCapitalHumano.Models;

namespace GestionCapitalHumano.Interfaces
{
    public interface ISindicatoManager
    {
        List<Sindicato> GetAllSindicatos();
        Sindicato crearSindicato(SindicatoDTO sindicato);
        Sindicato editarSindicato(int id, SindicatoDTO sindicato);
        bool deleteSindicato(int id);
    }
}
