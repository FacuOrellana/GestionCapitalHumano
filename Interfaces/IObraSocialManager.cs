using GestionCapitalHumano.DTOs;
using GestionCapitalHumano.Models;

namespace GestionCapitalHumano.Interfaces
{
    public interface IObraSocialManager
    {
        List<ObraSocial> GetAllObraSocial();
        ObraSocial crearObraSocial(ObraSocialDTO obraSocial);

        ObraSocial editObraSocial(int id, ObraSocialDTO obraSocial);

        bool deleteObraSocial(int id);
    }
}
